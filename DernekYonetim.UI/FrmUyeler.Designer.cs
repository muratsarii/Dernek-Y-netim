namespace DernekYonetim.UI
{
    partial class FrmUyeler
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
            this.lstUyeler = new System.Windows.Forms.ListBox();
            this.ctxUyeList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dÜZENLEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpUyeDetaylari = new System.Windows.Forms.GroupBox();
            this.dtpBitis = new System.Windows.Forms.DateTimePicker();
            this.dtpBaslangic = new System.Windows.Forms.DateTimePicker();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.chkPasif = new System.Windows.Forms.CheckBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grdMaliHareket = new System.Windows.Forms.DataGridView();
            this.lstOdenmemisAidat = new System.Windows.Forms.ListBox();
            this.ctxAidatListele = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.öDEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxUyeList.SuspendLayout();
            this.grpUyeDetaylari.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMaliHareket)).BeginInit();
            this.ctxAidatListele.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstUyeler
            // 
            this.lstUyeler.ContextMenuStrip = this.ctxUyeList;
            this.lstUyeler.Enabled = false;
            this.lstUyeler.FormattingEnabled = true;
            this.lstUyeler.ItemHeight = 16;
            this.lstUyeler.Location = new System.Drawing.Point(15, 14);
            this.lstUyeler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstUyeler.Name = "lstUyeler";
            this.lstUyeler.Size = new System.Drawing.Size(271, 628);
            this.lstUyeler.TabIndex = 0;
            this.lstUyeler.SelectedIndexChanged += new System.EventHandler(this.lstUyeler_SelectedIndexChanged);
            // 
            // ctxUyeList
            // 
            this.ctxUyeList.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctxUyeList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dÜZENLEToolStripMenuItem});
            this.ctxUyeList.Name = "ctxUyeList";
            this.ctxUyeList.Size = new System.Drawing.Size(143, 28);
            // 
            // dÜZENLEToolStripMenuItem
            // 
            this.dÜZENLEToolStripMenuItem.Name = "dÜZENLEToolStripMenuItem";
            this.dÜZENLEToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.dÜZENLEToolStripMenuItem.Text = "DÜZENLE";
            this.dÜZENLEToolStripMenuItem.Click += new System.EventHandler(this.dÜZENLEToolStripMenuItem_Click);
            // 
            // grpUyeDetaylari
            // 
            this.grpUyeDetaylari.BackColor = System.Drawing.Color.SlateGray;
            this.grpUyeDetaylari.Controls.Add(this.dtpBitis);
            this.grpUyeDetaylari.Controls.Add(this.dtpBaslangic);
            this.grpUyeDetaylari.Controls.Add(this.txtSoyad);
            this.grpUyeDetaylari.Controls.Add(this.txtTelefon);
            this.grpUyeDetaylari.Controls.Add(this.txtMail);
            this.grpUyeDetaylari.Controls.Add(this.txtAd);
            this.grpUyeDetaylari.Controls.Add(this.chkPasif);
            this.grpUyeDetaylari.Controls.Add(this.btnKaydet);
            this.grpUyeDetaylari.Controls.Add(this.label7);
            this.grpUyeDetaylari.Controls.Add(this.label6);
            this.grpUyeDetaylari.Controls.Add(this.label5);
            this.grpUyeDetaylari.Controls.Add(this.label4);
            this.grpUyeDetaylari.Controls.Add(this.label3);
            this.grpUyeDetaylari.Controls.Add(this.label2);
            this.grpUyeDetaylari.Controls.Add(this.label1);
            this.grpUyeDetaylari.Enabled = false;
            this.grpUyeDetaylari.Font = new System.Drawing.Font("Impact", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpUyeDetaylari.Location = new System.Drawing.Point(295, 15);
            this.grpUyeDetaylari.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpUyeDetaylari.Name = "grpUyeDetaylari";
            this.grpUyeDetaylari.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpUyeDetaylari.Size = new System.Drawing.Size(451, 388);
            this.grpUyeDetaylari.TabIndex = 1;
            this.grpUyeDetaylari.TabStop = false;
            this.grpUyeDetaylari.Text = "ÜYE DETAYLARI";
            // 
            // dtpBitis
            // 
            this.dtpBitis.Enabled = false;
            this.dtpBitis.Location = new System.Drawing.Point(196, 257);
            this.dtpBitis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpBitis.Name = "dtpBitis";
            this.dtpBitis.Size = new System.Drawing.Size(244, 30);
            this.dtpBitis.TabIndex = 14;
            // 
            // dtpBaslangic
            // 
            this.dtpBaslangic.Enabled = false;
            this.dtpBaslangic.Location = new System.Drawing.Point(196, 212);
            this.dtpBaslangic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpBaslangic.Name = "dtpBaslangic";
            this.dtpBaslangic.Size = new System.Drawing.Size(244, 30);
            this.dtpBaslangic.TabIndex = 13;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Enabled = false;
            this.txtSoyad.Location = new System.Drawing.Point(196, 74);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(244, 30);
            this.txtSoyad.TabIndex = 12;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Enabled = false;
            this.txtTelefon.Location = new System.Drawing.Point(196, 119);
            this.txtTelefon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(244, 30);
            this.txtTelefon.TabIndex = 11;
            // 
            // txtMail
            // 
            this.txtMail.Enabled = false;
            this.txtMail.Location = new System.Drawing.Point(196, 160);
            this.txtMail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(244, 30);
            this.txtMail.TabIndex = 10;
            // 
            // txtAd
            // 
            this.txtAd.Enabled = false;
            this.txtAd.Location = new System.Drawing.Point(196, 28);
            this.txtAd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(244, 30);
            this.txtAd.TabIndex = 9;
            // 
            // chkPasif
            // 
            this.chkPasif.AutoSize = true;
            this.chkPasif.Enabled = false;
            this.chkPasif.Location = new System.Drawing.Point(196, 304);
            this.chkPasif.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkPasif.Name = "chkPasif";
            this.chkPasif.Size = new System.Drawing.Size(74, 27);
            this.chkPasif.TabIndex = 8;
            this.chkPasif.Text = "PASİF";
            this.chkPasif.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Enabled = false;
            this.btnKaydet.Font = new System.Drawing.Font("Impact", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(20, 332);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(421, 48);
            this.btnKaydet.TabIndex = 7;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 305);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "ÜYELİK DURUMU";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 260);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "BİTİŞ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 78);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "SOYAD: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 123);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "TELEFON: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 169);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "MAİL: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 214);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "BAŞLANGIÇ: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "AD: ";
            // 
            // grdMaliHareket
            // 
            this.grdMaliHareket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMaliHareket.Enabled = false;
            this.grdMaliHareket.Location = new System.Drawing.Point(295, 411);
            this.grdMaliHareket.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grdMaliHareket.Name = "grdMaliHareket";
            this.grdMaliHareket.Size = new System.Drawing.Size(764, 230);
            this.grdMaliHareket.TabIndex = 15;
            // 
            // lstOdenmemisAidat
            // 
            this.lstOdenmemisAidat.Enabled = false;
            this.lstOdenmemisAidat.FormattingEnabled = true;
            this.lstOdenmemisAidat.ItemHeight = 16;
            this.lstOdenmemisAidat.Location = new System.Drawing.Point(755, 15);
            this.lstOdenmemisAidat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstOdenmemisAidat.Name = "lstOdenmemisAidat";
            this.lstOdenmemisAidat.Size = new System.Drawing.Size(295, 388);
            this.lstOdenmemisAidat.TabIndex = 16;
            // 
            // ctxAidatListele
            // 
            this.ctxAidatListele.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctxAidatListele.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öDEToolStripMenuItem});
            this.ctxAidatListele.Name = "ctxAidatListele";
            this.ctxAidatListele.Size = new System.Drawing.Size(109, 28);
            // 
            // öDEToolStripMenuItem
            // 
            this.öDEToolStripMenuItem.Name = "öDEToolStripMenuItem";
            this.öDEToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.öDEToolStripMenuItem.Text = "ÖDE";
            this.öDEToolStripMenuItem.Click += new System.EventHandler(this.öDEToolStripMenuItem_Click);
            // 
            // FrmUyeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(1067, 652);
            this.Controls.Add(this.lstOdenmemisAidat);
            this.Controls.Add(this.grdMaliHareket);
            this.Controls.Add(this.grpUyeDetaylari);
            this.Controls.Add(this.lstUyeler);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmUyeler";
            this.Text = "ÜYELER";
            this.Load += new System.EventHandler(this.FrmUyeler_Load);
            this.ctxUyeList.ResumeLayout(false);
            this.grpUyeDetaylari.ResumeLayout(false);
            this.grpUyeDetaylari.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMaliHareket)).EndInit();
            this.ctxAidatListele.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstUyeler;
        private System.Windows.Forms.GroupBox grpUyeDetaylari;
        private System.Windows.Forms.DateTimePicker dtpBitis;
        private System.Windows.Forms.DateTimePicker dtpBaslangic;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.CheckBox chkPasif;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdMaliHareket;
        private System.Windows.Forms.ListBox lstOdenmemisAidat;
        private System.Windows.Forms.ContextMenuStrip ctxUyeList;
        private System.Windows.Forms.ToolStripMenuItem dÜZENLEToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip ctxAidatListele;
        private System.Windows.Forms.ToolStripMenuItem öDEToolStripMenuItem;
    }
}