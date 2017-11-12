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

            Hizmetli.DoWork += Hizmetli_DoWork;
            Hizmetli.WorkerReportsProgress = true;
            Hizmetli.ProgressChanged += Hizmetli_ProgressChanged;
            Hizmetli.RunWorkerCompleted += Hizmetli_RunWorkerCompleted;
            Hizmetli.WorkerSupportsCancellation = true;
        }

        private void Hizmetli_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                lblilerleme.Text = "İşlem iptal edildi.";
            }
            else if (e.Error != null)
            {
                lblilerleme.Text = "İşlem sırasında hata oluştu. Uygulama sonlandı";
            }
            else
            {
                lblilerleme.Text = "İşlem tamamlandı";
            }
        }

        private void Hizmetli_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            toolStripProgressBar1.Value = e.ProgressPercentage;
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            if (gbilerleme.Visible)
            {
                gbilerleme.Visible = false;
            }
            groupBox1.Visible = true;
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            Hizmetli.RunWorkerAsync();
        }

        private void Hizmetli_DoWork(object sender, DoWorkEventArgs e)
        {
            //Avoid Cross-Thread Op mot Valid Exception..
            if (this.InvokeRequired)
            {
                this.Invoke(
                    new MethodInvoker(
                    delegate () { Hizmetli_DoWork(sender,e); }));
            }
            else
            {
                try
                {
                    //Open the Excel file using ClosedXML.
                    using (XLWorkbook workBook = new XLWorkbook(openFileDialog1.FileName.ToString()))
                    {
                        //Read the first Sheet from Excel file.
                        IXLWorksheet workSheet = workBook.Worksheet(1);
                        #region GuardCode


                        if (workSheet.LastColumnUsed().ColumnNumber() != 8)
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
                        #endregion

                        int ÖğrenciSayısı = workSheet.LastRowUsed().RowNumber() - 1;
                        toolStripProgressBar1.Minimum = 0;
                        toolStripProgressBar1.Maximum = 100;
                        toolStripProgressBar1.Value = 0;

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
                        int işlenensayı = 0;
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
                            // MessageBox.Show(RemoveTurkishChars.SystemFriendly(sınıf[0].ToString()));
                            if (!gbilerleme.Visible)
                            {
                                gbilerleme.Visible = true;
                            }
                            // lblilerleme.Text = sınıf[0].ToString();

                            //MessageBox.Show(String.Format("Sınıfı='{0}'", sınıf[0].ToString()));

                            DataTable table = new DataTable();
                            table.Columns.Add("Ad Soyad", typeof(string));
                            table.Columns.Add("E-Postası", typeof(string));
                            table.Columns.Add("Şifresi", typeof(string));
                            
                            for (int i = 0; i < DistinctMalzeme.Rows.Count; i++)
                            {
                                DataRow ogrenci = (DataRow)DistinctMalzeme.Rows[i];
                                string AdSoyad = ogrenci[0].ToString() + " " + ogrenci[1].ToString();
                                string Epostası = RemoveTurkishChars.SystemFriendly(ogrenci[1].ToString()) + "." + ogrenci[3].ToString() + tbDomain.Text.ToLower();
                                string Şifresi = ogrenci[2].ToString().Substring(1, 6);

                                table.Rows.Add(AdSoyad, Epostası, Şifresi);
                                lblilerlemeOgrenci.Text = AdSoyad;
                                if (!toolStripProgressBar1.Visible) { toolStripProgressBar1.Visible = true; }
                                
                                işlenensayı += 1;
                                Hizmetli.ReportProgress((işlenensayı * 100) / ÖğrenciSayısı);
                                //MessageBox.Show(((işlenensayı * 100) / ÖğrenciSayısı).ToString());
                                
                            }


                            //foreach (DataRow ogrenci in DistinctMalzeme.Rows)
                            //{
                            //    string AdSoyad = ogrenci[0].ToString() + " " + ogrenci[1].ToString();
                            //    string Epostası = RemoveTurkishChars.SystemFriendly(ogrenci[1].ToString()) + "." + ogrenci[3].ToString() + tbDomain.Text.ToLower();
                            //    string Şifresi = ogrenci[2].ToString().Substring(1, 6);

                            //    table.Rows.Add(AdSoyad, Epostası, Şifresi);

                            //    // lblilerlemeOgrenci.Text = AdSoyad;

                            //    //toolStripProgressBar1.Visible = true;
                            //    //toolStripProgressBar1.Value += 1;

                            //    Hizmetli.ReportProgress(1);
                            //}

                            var wb = new XLWorkbook();

                            // Add a DataTable as a worksheet
                            wb.Worksheets.Add(table, "Sayfa 1");
                            string path = Path.GetDirectoryName(openFileDialog1.FileName.ToString());
                            wb.SaveAs(path + "/Sınıflar/" + RemoveTurkishChars.SystemFriendly(sınıf[0].ToString()) + ".xlsx");
                        }
                        //lblilerleme.Text = "Tüm sınıflar tamamlandı!";
                        //lblilerlemeOgrenci.Text = "Tüm öğrenciler tamamlandı!";
                        System.Diagnostics.Process.Start(Path.GetDirectoryName(openFileDialog1.FileName.ToString()) + "/Sınıflar/");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                    throw;
                }
            }
        }
    }
}
