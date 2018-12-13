namespace MasrafOtomasyonu
{
    partial class frmAnaForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnaForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grpMasrafDetay = new System.Windows.Forms.GroupBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.flpButonlar = new System.Windows.Forms.FlowLayoutPanel();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.nudTutar = new System.Windows.Forms.NumericUpDown();
            this.lblTutar = new System.Windows.Forms.Label();
            this.txtBaslik = new System.Windows.Forms.TextBox();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.lblTarih = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstMasraflar = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cmbMasrafSahibi = new System.Windows.Forms.ComboBox();
            this.menuTop = new System.Windows.Forms.MenuStrip();
            this.lblPersonelAdSoyad = new System.Windows.Forms.ToolStripMenuItem();
            this.cmenuMasrafYonet = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmenuOnayla = new System.Windows.Forms.ToolStripMenuItem();
            this.cmenuGuncelle = new System.Windows.Forms.ToolStripMenuItem();
            this.cmenuReddet = new System.Windows.Forms.ToolStripMenuItem();
            this.cmenuMuhasebe = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmenuOdendi = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grpMasrafDetay.SuspendLayout();
            this.flpButonlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTutar)).BeginInit();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.menuTop.SuspendLayout();
            this.cmenuMasrafYonet.SuspendLayout();
            this.cmenuMuhasebe.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grpMasrafDetay);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(12);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.menuTop);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.splitContainer1.Size = new System.Drawing.Size(794, 530);
            this.splitContainer1.SplitterDistance = 292;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // grpMasrafDetay
            // 
            this.grpMasrafDetay.Controls.Add(this.txtAciklama);
            this.grpMasrafDetay.Controls.Add(this.flpButonlar);
            this.grpMasrafDetay.Controls.Add(this.lblAciklama);
            this.grpMasrafDetay.Controls.Add(this.nudTutar);
            this.grpMasrafDetay.Controls.Add(this.lblTutar);
            this.grpMasrafDetay.Controls.Add(this.txtBaslik);
            this.grpMasrafDetay.Controls.Add(this.lblBaslik);
            this.grpMasrafDetay.Controls.Add(this.dtpTarih);
            this.grpMasrafDetay.Controls.Add(this.lblTarih);
            this.grpMasrafDetay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpMasrafDetay.Location = new System.Drawing.Point(12, 12);
            this.grpMasrafDetay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpMasrafDetay.Name = "grpMasrafDetay";
            this.grpMasrafDetay.Padding = new System.Windows.Forms.Padding(12);
            this.grpMasrafDetay.Size = new System.Drawing.Size(268, 506);
            this.grpMasrafDetay.TabIndex = 0;
            this.grpMasrafDetay.TabStop = false;
            this.grpMasrafDetay.Text = " Masraf Detayları";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAciklama.Location = new System.Drawing.Point(12, 217);
            this.txtAciklama.MaxLength = 150;
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(244, 234);
            this.txtAciklama.TabIndex = 9;
            // 
            // flpButonlar
            // 
            this.flpButonlar.Controls.Add(this.btnEkle);
            this.flpButonlar.Controls.Add(this.btnKaydet);
            this.flpButonlar.Controls.Add(this.btnSil);
            this.flpButonlar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpButonlar.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpButonlar.Location = new System.Drawing.Point(12, 451);
            this.flpButonlar.Name = "flpButonlar";
            this.flpButonlar.Size = new System.Drawing.Size(244, 43);
            this.flpButonlar.TabIndex = 8;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(166, 3);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 37);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(85, 3);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 37);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "Güncelle";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(4, 3);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 37);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // lblAciklama
            // 
            this.lblAciklama.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAciklama.Location = new System.Drawing.Point(12, 187);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblAciklama.Size = new System.Drawing.Size(244, 30);
            this.lblAciklama.TabIndex = 6;
            this.lblAciklama.Text = "Açıklama :";
            this.lblAciklama.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // nudTutar
            // 
            this.nudTutar.DecimalPlaces = 2;
            this.nudTutar.Dock = System.Windows.Forms.DockStyle.Top;
            this.nudTutar.Location = new System.Drawing.Point(12, 164);
            this.nudTutar.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            131072});
            this.nudTutar.Name = "nudTutar";
            this.nudTutar.Size = new System.Drawing.Size(244, 23);
            this.nudTutar.TabIndex = 5;
            // 
            // lblTutar
            // 
            this.lblTutar.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTutar.Location = new System.Drawing.Point(12, 134);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblTutar.Size = new System.Drawing.Size(244, 30);
            this.lblTutar.TabIndex = 4;
            this.lblTutar.Text = "Tutar :";
            this.lblTutar.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtBaslik
            // 
            this.txtBaslik.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtBaslik.Location = new System.Drawing.Point(12, 111);
            this.txtBaslik.MaxLength = 50;
            this.txtBaslik.Name = "txtBaslik";
            this.txtBaslik.Size = new System.Drawing.Size(244, 23);
            this.txtBaslik.TabIndex = 3;
            // 
            // lblBaslik
            // 
            this.lblBaslik.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBaslik.Location = new System.Drawing.Point(12, 81);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblBaslik.Size = new System.Drawing.Size(244, 30);
            this.lblBaslik.TabIndex = 2;
            this.lblBaslik.Text = "Başlık :";
            this.lblBaslik.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // dtpTarih
            // 
            this.dtpTarih.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtpTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTarih.Location = new System.Drawing.Point(12, 58);
            this.dtpTarih.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(244, 23);
            this.dtpTarih.TabIndex = 1;
            // 
            // lblTarih
            // 
            this.lblTarih.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTarih.Location = new System.Drawing.Point(12, 28);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblTarih.Size = new System.Drawing.Size(244, 30);
            this.lblTarih.TabIndex = 0;
            this.lblTarih.Text = "Tarih :";
            this.lblTarih.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lstMasraflar);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 24);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(495, 506);
            this.panel1.TabIndex = 1;
            // 
            // lstMasraflar
            // 
            this.lstMasraflar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstMasraflar.FormattingEnabled = true;
            this.lstMasraflar.ItemHeight = 16;
            this.lstMasraflar.Location = new System.Drawing.Point(10, 46);
            this.lstMasraflar.Name = "lstMasraflar";
            this.lstMasraflar.Size = new System.Drawing.Size(475, 450);
            this.lstMasraflar.TabIndex = 1;
            this.lstMasraflar.SelectedIndexChanged += new System.EventHandler(this.lstMasraflar_SelectedIndexChanged);
            this.lstMasraflar.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.lstMasraflar_Format);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.cmbMasrafSahibi);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(475, 36);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // cmbMasrafSahibi
            // 
            this.cmbMasrafSahibi.FormattingEnabled = true;
            this.cmbMasrafSahibi.Location = new System.Drawing.Point(245, 3);
            this.cmbMasrafSahibi.Name = "cmbMasrafSahibi";
            this.cmbMasrafSahibi.Size = new System.Drawing.Size(227, 24);
            this.cmbMasrafSahibi.TabIndex = 0;
            this.cmbMasrafSahibi.SelectedIndexChanged += new System.EventHandler(this.cmbMasrafSahibi_SelectedIndexChanged);
            this.cmbMasrafSahibi.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cmbMasrafSahibi_Format);
            // 
            // menuTop
            // 
            this.menuTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblPersonelAdSoyad});
            this.menuTop.Location = new System.Drawing.Point(2, 0);
            this.menuTop.Name = "menuTop";
            this.menuTop.Size = new System.Drawing.Size(495, 24);
            this.menuTop.TabIndex = 0;
            this.menuTop.Text = "menuStrip1";
            // 
            // lblPersonelAdSoyad
            // 
            this.lblPersonelAdSoyad.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblPersonelAdSoyad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPersonelAdSoyad.Name = "lblPersonelAdSoyad";
            this.lblPersonelAdSoyad.Size = new System.Drawing.Size(123, 20);
            this.lblPersonelAdSoyad.Text = "[PersonelAdSoyad]";
            this.lblPersonelAdSoyad.Click += new System.EventHandler(this.lblPersonelAdSoyad_Click);
            // 
            // cmenuMasrafYonet
            // 
            this.cmenuMasrafYonet.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmenuOnayla,
            this.cmenuGuncelle,
            this.cmenuReddet});
            this.cmenuMasrafYonet.Name = "cmenuMasrafYonet";
            this.cmenuMasrafYonet.Size = new System.Drawing.Size(121, 70);
            // 
            // cmenuOnayla
            // 
            this.cmenuOnayla.Name = "cmenuOnayla";
            this.cmenuOnayla.Size = new System.Drawing.Size(120, 22);
            this.cmenuOnayla.Text = "Onayla";
            this.cmenuOnayla.Click += new System.EventHandler(this.cmenuOnayla_Click);
            // 
            // cmenuGuncelle
            // 
            this.cmenuGuncelle.Name = "cmenuGuncelle";
            this.cmenuGuncelle.Size = new System.Drawing.Size(120, 22);
            this.cmenuGuncelle.Text = "Güncelle";
            this.cmenuGuncelle.Click += new System.EventHandler(this.cmenuGuncelle_Click);
            // 
            // cmenuReddet
            // 
            this.cmenuReddet.Name = "cmenuReddet";
            this.cmenuReddet.Size = new System.Drawing.Size(120, 22);
            this.cmenuReddet.Text = "Reddet";
            this.cmenuReddet.Click += new System.EventHandler(this.cmenuReddet_Click);
            // 
            // cmenuMuhasebe
            // 
            this.cmenuMuhasebe.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmenuOdendi});
            this.cmenuMuhasebe.Name = "cmenuMuhasebe";
            this.cmenuMuhasebe.Size = new System.Drawing.Size(114, 26);
            // 
            // cmenuOdendi
            // 
            this.cmenuOdendi.Name = "cmenuOdendi";
            this.cmenuOdendi.Size = new System.Drawing.Size(113, 22);
            this.cmenuOdendi.Text = "Ödendi";
            this.cmenuOdendi.Click += new System.EventHandler(this.cmenuOdendi_Click);
            // 
            // frmAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 530);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuTop;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Masraf Otomasyonu : Masraflar";
            this.Load += new System.EventHandler(this.frmAnaForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.grpMasrafDetay.ResumeLayout(false);
            this.grpMasrafDetay.PerformLayout();
            this.flpButonlar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudTutar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.menuTop.ResumeLayout(false);
            this.menuTop.PerformLayout();
            this.cmenuMasrafYonet.ResumeLayout(false);
            this.cmenuMuhasebe.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox grpMasrafDetay;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.FlowLayoutPanel flpButonlar;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.NumericUpDown nudTutar;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.TextBox txtBaslik;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox cmbMasrafSahibi;
        private System.Windows.Forms.MenuStrip menuTop;
        private System.Windows.Forms.ToolStripMenuItem lblPersonelAdSoyad;
        private System.Windows.Forms.ListBox lstMasraflar;
        private System.Windows.Forms.ContextMenuStrip cmenuMasrafYonet;
        private System.Windows.Forms.ToolStripMenuItem cmenuOnayla;
        private System.Windows.Forms.ToolStripMenuItem cmenuGuncelle;
        private System.Windows.Forms.ToolStripMenuItem cmenuReddet;
        private System.Windows.Forms.ContextMenuStrip cmenuMuhasebe;
        private System.Windows.Forms.ToolStripMenuItem cmenuOdendi;
    }
}