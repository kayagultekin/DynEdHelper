namespace DynEdHelper.Desktop
{
    partial class AnaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.OpenToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SaveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.HelpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tbDomain = new System.Windows.Forms.TextBox();
            this.GBAyarlar = new System.Windows.Forms.GroupBox();
            this.CBOpenDynEd = new System.Windows.Forms.CheckBox();
            this.CBOpenFolder = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GBilerleme = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.LBLilerlemeOgrenci = new System.Windows.Forms.Label();
            this.LBLilerleme = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.ToolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1.SuspendLayout();
            this.GBAyarlar.SuspendLayout();
            this.GBilerleme.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripButton,
            this.toolStripSeparator1,
            this.SaveToolStripButton,
            this.toolStripSeparator,
            this.HelpToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(394, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // OpenToolStripButton
            // 
            this.OpenToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("OpenToolStripButton.Image")));
            this.OpenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenToolStripButton.Name = "OpenToolStripButton";
            this.OpenToolStripButton.Size = new System.Drawing.Size(91, 22);
            this.OpenToolStripButton.Text = "Dosya Yükle";
            this.OpenToolStripButton.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.OpenToolStripButton.Click += new System.EventHandler(this.OpenToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // SaveToolStripButton
            // 
            this.SaveToolStripButton.Enabled = false;
            this.SaveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveToolStripButton.Image")));
            this.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveToolStripButton.Name = "SaveToolStripButton";
            this.SaveToolStripButton.Size = new System.Drawing.Size(134, 22);
            this.SaveToolStripButton.Text = "Listeyi İşle ve Kaydet";
            this.SaveToolStripButton.Click += new System.EventHandler(this.SaveToolStripButton_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // HelpToolStripButton
            // 
            this.HelpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HelpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("HelpToolStripButton.Image")));
            this.HelpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HelpToolStripButton.Name = "HelpToolStripButton";
            this.HelpToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.HelpToolStripButton.Text = "He&lp";
            this.HelpToolStripButton.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialog1_FileOk);
            // 
            // tbDomain
            // 
            this.tbDomain.Location = new System.Drawing.Point(178, 23);
            this.tbDomain.Name = "tbDomain";
            this.tbDomain.Size = new System.Drawing.Size(157, 20);
            this.tbDomain.TabIndex = 1;
            this.tbDomain.Text = "@site.net";
            // 
            // GBAyarlar
            // 
            this.GBAyarlar.Controls.Add(this.CBOpenDynEd);
            this.GBAyarlar.Controls.Add(this.CBOpenFolder);
            this.GBAyarlar.Controls.Add(this.label1);
            this.GBAyarlar.Controls.Add(this.tbDomain);
            this.GBAyarlar.Location = new System.Drawing.Point(22, 44);
            this.GBAyarlar.Name = "GBAyarlar";
            this.GBAyarlar.Size = new System.Drawing.Size(353, 132);
            this.GBAyarlar.TabIndex = 2;
            this.GBAyarlar.TabStop = false;
            this.GBAyarlar.Text = "Ayarlar";
            this.GBAyarlar.Visible = false;
            // 
            // CBOpenDynEd
            // 
            this.CBOpenDynEd.AutoSize = true;
            this.CBOpenDynEd.Checked = true;
            this.CBOpenDynEd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBOpenDynEd.Location = new System.Drawing.Point(21, 84);
            this.CBOpenDynEd.Name = "CBOpenDynEd";
            this.CBOpenDynEd.Size = new System.Drawing.Size(188, 17);
            this.CBOpenDynEd.TabIndex = 4;
            this.CBOpenDynEd.Text = "DynEd Kayıt Yönetimi Sistemi\'ni aç";
            this.CBOpenDynEd.UseVisualStyleBackColor = true;
            // 
            // CBOpenFolder
            // 
            this.CBOpenFolder.AutoSize = true;
            this.CBOpenFolder.Checked = true;
            this.CBOpenFolder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBOpenFolder.Location = new System.Drawing.Point(21, 59);
            this.CBOpenFolder.Name = "CBOpenFolder";
            this.CBOpenFolder.Size = new System.Drawing.Size(179, 17);
            this.CBOpenFolder.TabIndex = 3;
            this.CBOpenFolder.Text = "İşlenen dosyaları klasörde göster";
            this.CBOpenFolder.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "e-Posta için domain uzantısı:";
            // 
            // GBilerleme
            // 
            this.GBilerleme.Controls.Add(this.linkLabel1);
            this.GBilerleme.Controls.Add(this.LBLilerlemeOgrenci);
            this.GBilerleme.Controls.Add(this.LBLilerleme);
            this.GBilerleme.Location = new System.Drawing.Point(22, 44);
            this.GBilerleme.Name = "GBilerleme";
            this.GBilerleme.Size = new System.Drawing.Size(353, 113);
            this.GBilerleme.TabIndex = 3;
            this.GBilerleme.TabStop = false;
            this.GBilerleme.Text = "İlerleme";
            this.GBilerleme.Visible = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(21, 80);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(142, 13);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "DynEd Kayıt Yönetim Sistemi";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // LBLilerlemeOgrenci
            // 
            this.LBLilerlemeOgrenci.AutoSize = true;
            this.LBLilerlemeOgrenci.Location = new System.Drawing.Point(21, 50);
            this.LBLilerlemeOgrenci.Name = "LBLilerlemeOgrenci";
            this.LBLilerlemeOgrenci.Size = new System.Drawing.Size(98, 13);
            this.LBLilerlemeOgrenci.TabIndex = 1;
            this.LBLilerlemeOgrenci.Text = "LBLilerlemeOgrenci";
            // 
            // LBLilerleme
            // 
            this.LBLilerleme.AutoSize = true;
            this.LBLilerleme.Location = new System.Drawing.Point(21, 25);
            this.LBLilerleme.Name = "LBLilerleme";
            this.LBLilerleme.Size = new System.Drawing.Size(61, 13);
            this.LBLilerleme.TabIndex = 0;
            this.LBLilerleme.Text = "LBLilerleme";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabel1,
            this.ToolStripProgressBar1,
            this.ToolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 184);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(394, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ToolStripStatusLabel1
            // 
            this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
            this.ToolStripStatusLabel1.Size = new System.Drawing.Size(171, 17);
            this.ToolStripStatusLabel1.Text = "Gültekin KAYA @ DynEd Isparta";
            // 
            // ToolStripProgressBar1
            // 
            this.ToolStripProgressBar1.Name = "ToolStripProgressBar1";
            this.ToolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            this.ToolStripProgressBar1.Visible = false;
            // 
            // ToolStripStatusLabel2
            // 
            this.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2";
            this.ToolStripStatusLabel2.Size = new System.Drawing.Size(60, 17);
            this.ToolStripStatusLabel2.Text = "Ekim 2019";
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 206);
            this.Controls.Add(this.GBilerleme);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.GBAyarlar);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AnaForm";
            this.Text = "DynEd Helper (v1.2.0)";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.GBAyarlar.ResumeLayout(false);
            this.GBAyarlar.PerformLayout();
            this.GBilerleme.ResumeLayout(false);
            this.GBilerleme.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton OpenToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton SaveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton HelpToolStripButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox tbDomain;
        private System.Windows.Forms.GroupBox GBAyarlar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GBilerleme;
        private System.Windows.Forms.Label LBLilerleme;
        private System.Windows.Forms.Label LBLilerlemeOgrenci;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel2;
        private System.Windows.Forms.ToolStripProgressBar ToolStripProgressBar1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.CheckBox CBOpenDynEd;
        private System.Windows.Forms.CheckBox CBOpenFolder;
    }
}