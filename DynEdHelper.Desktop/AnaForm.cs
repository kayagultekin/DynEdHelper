using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynEdHelper.Desktop
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void OpenToolStripButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
 
        private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            if (GBilerleme.Visible)
            {
                GBilerleme.Visible = false;
            }
            groupBox1.Visible = true;
            SaveToolStripButton.Enabled = true;
        }

        private void SaveToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Open the Excel file using ClosedXML.
                using (XLWorkbook workBook = new XLWorkbook(openFileDialog1.FileName.ToString()))
                {
                    //Read the first Sheet from Excel file.
                    IXLWorksheet workSheet = workBook.Worksheet(1);
                    #region GuardCode

                    if (workSheet.LastColumnUsed().ColumnNumber() > 8 || workSheet.LastColumnUsed().ColumnNumber() < 7)
                    {
                        MessageBox.Show("Dosyadaki sütun sayısı olması gerekenden farklı, E-Okuldan verileri sütunlarıyla birlikte aldığınızdan emin olur musunuz?");

                        return;
                    }
                    if (workSheet.Cell(1, 2).GetString() != "T.C. Kimlik No")
                    {
                        MessageBox.Show("T.C. Kimlik No Sütun başlığı yerinde değil, E-Okuldan verileri sütunlarıyla birlikte aldığınızdan emin olur musunuz?");
                        return;
                    }
                    if (workSheet.Cell(1, 3).GetString() != "Adı")
                    {
                        MessageBox.Show("Adı Sütun başlığı yerinde değil, E-Okuldan verileri sütunlarıyla birlikte aldığınızdan emin olur musunuz?");

                        return;
                    }
                    if (workSheet.Cell(1, 4).GetString() != "Soyadı")
                    {
                        MessageBox.Show("Soyadı Sütun başlığı yerinde değil, E-Okuldan verileri sütunlarıyla birlikte aldığınızdan emin olur musunuz?");

                        return;
                    }
                    if (workSheet.Cell(1, 5).GetString() != "Okul No")
                    {
                        MessageBox.Show("Okul No Sütun başlığı yerinde değil, E-Okuldan verileri sütunlarıyla birlikte aldığınızdan emin olur musunuz?");

                        return;
                    }
                    if (! workSheet.Cell(2,1).IsEmpty())
                    {
                        workSheet.Column("A").Clear();
                    }
                    #endregion

                    int ÖğrenciSayısı = workSheet.LastRowUsed().RowNumber() - 1;
                    ToolStripProgressBar1.Minimum = 0;
                    ToolStripProgressBar1.Maximum = ÖğrenciSayısı;
                    ToolStripProgressBar1.Value = 0;

                    //Create a new DataTable.
                    DataTable dt = new DataTable();

                    //Loop through the Worksheet rows.
                    bool firstRow = true;
                    foreach (IXLRow row in workSheet.Rows())
                    {
                        //Use the first row to add columns to DataTable.
                        if (firstRow)
                        {
                            foreach (IXLCell cell in row.Cells())
                            {
                                dt.Columns.Add(cell.Value.ToString());
                            }
                            firstRow = false;
                        }
                        else
                        {
                            //Add rows to DataTable.
                            dt.Rows.Add();
                            int i = 0;
                            foreach (IXLCell cell in row.Cells())
                            {
                                dt.Rows[dt.Rows.Count - 1][i] = cell.Value.ToString();
                                i++;
                            }
                        }
                        // GridOgrenciler.DataSource = dt;
                    }

                    DataTable distinctValuesHelperDt = new DataTable();
                    distinctValuesHelperDt = dt.Copy();
                    DataView view = new DataView(distinctValuesHelperDt);
                    DataTable distinctValues = new DataTable();
                    distinctValues = view.ToTable(true, "Sınıfı");

                    //GridSiniflar.DataSource = distinctValues;

                    foreach (DataRow sınıf in distinctValues.Rows)
                    {
                        DataTable DistinctMalzeme = new DataTable();
                        DistinctMalzeme = dt.Copy();
                        DataView dv = new DataView(DistinctMalzeme);

                        string MyFilter = String.Format("Sınıfı='{0}'", sınıf[0].ToString());
                        dv.RowFilter = MyFilter;
                        DistinctMalzeme = dv.ToTable(false, "Adı", "Soyadı", "T.C. Kimlik No", "Okul No");
                        //DistinctMalzeme.Columns.Remove("Column 1");

                        // GridPerSınıf.DataSource = DistinctMalzeme;
                        // MessageBox.Show(ReplaceSpecialChars.SystemFriendly(sınıf[0].ToString()));
                        if (!GBilerleme.Visible)
                        {
                            GBilerleme.Visible = true;
                        }
                        // lblilerleme.Text = sınıf[0].ToString();

                        //MessageBox.Show(String.Format("Sınıfı='{0}'", sınıf[0].ToString()));

                        DataTable table = new DataTable();
                        table.Columns.Add("Ad Soyad", typeof(string));
                        table.Columns.Add("E-Postası", typeof(string));
                        table.Columns.Add("Şifresi", typeof(string));

                        foreach (DataRow ogrenci in DistinctMalzeme.Rows)
                        {
                            string AdSoyad = ogrenci[0].ToString() + " " + ogrenci[1].ToString();
                            string Epostası = ReplaceSpecialChars.SystemFriendly(ogrenci[1].ToString()) + "." + ogrenci[3].ToString() + tbDomain.Text.ToLower();
                            string Şifresi = ogrenci[2].ToString().Substring(1, 6);

                            table.Rows.Add(AdSoyad, Epostası, Şifresi);

                            // lblilerlemeOgrenci.Text = AdSoyad;
                            ToolStripProgressBar1.Visible = true;
                            ToolStripProgressBar1.Value += 1;
                        }

                        var wb = new XLWorkbook();

                        // Add a DataTable as a worksheet
                        wb.Worksheets.Add(table, "Sayfa 1");
                        string path = Path.GetDirectoryName(openFileDialog1.FileName.ToString());
                        wb.SaveAs(path + "/Sınıflar/" + ReplaceSpecialChars.SystemFriendly(sınıf[0].ToString()) + ".xlsx");
                    }
                    LBLilerleme.Text = "Tüm sınıflar tamamlandı!";
                    LBLilerlemeOgrenci.Text = "Tüm öğrenciler tamamlandı!";
                    System.Diagnostics.Process.Start(Path.GetDirectoryName(openFileDialog1.FileName.ToString()) + "/Sınıflar/");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                throw;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                linkLabel1.LinkVisited = true;
                System.Diagnostics.Process.Start("https://dynedkayityonetimisistemi.meb.gov.tr/");
            }
            catch (Exception)
            {
                MessageBox.Show("DynEd Kayıt Yönetim Sistemini açamadık :(");
            }
        }
    }
}
