namespace DernekYonetim.UI
{
    partial class frmYoneticiler
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
            this.grpYoneticiDetaylari = new System.Windows.Forms.GroupBox();
            this.btnIptal = new System.Windows.Forms.Button();
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
            this.grdYoneticiHareket = new System.Windows.Forms.DataGridView();
            this.lstYoneticiler = new System.Windows.Forms.ListBox();
            this.ctxList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dÜZENLEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblDonem = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.grpYoneticiDetaylari.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdYoneticiHareket)).BeginInit();
            this.ctxList.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpYoneticiDetaylari
            // 
            this.grpYoneticiDetaylari.BackColor = System.Drawing.Color.SlateGray;
            this.grpYoneticiDetaylari.Controls.Add(this.btnIptal);
            this.grpYoneticiDetaylari.Controls.Add(this.dtpBitis);
            this.grpYoneticiDetaylari.Controls.Add(this.dtpBaslangic);
            this.grpYoneticiDetaylari.Controls.Add(this.txtSoyad);
            this.grpYoneticiDetaylari.Controls.Add(this.txtTelefon);
            this.grpYoneticiDetaylari.Controls.Add(this.txtMail);
            this.grpYoneticiDetaylari.Controls.Add(this.txtAd);
            this.grpYoneticiDetaylari.Controls.Add(this.chkPasif);
            this.grpYoneticiDetaylari.Controls.Add(this.btnKaydet);
            this.grpYoneticiDetaylari.Controls.Add(this.label7);
            this.grpYoneticiDetaylari.Controls.Add(this.label6);
            this.grpYoneticiDetaylari.Controls.Add(this.label5);
            this.grpYoneticiDetaylari.Controls.Add(this.label4);
            this.grpYoneticiDetaylari.Controls.Add(this.label3);
            this.grpYoneticiDetaylari.Controls.Add(this.label2);
            this.grpYoneticiDetaylari.Controls.Add(this.label1);
            this.grpYoneticiDetaylari.Enabled = false;
            this.grpYoneticiDetaylari.Font = new System.Drawing.Font("Impact", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpYoneticiDetaylari.Location = new System.Drawing.Point(226, 45);
            this.grpYoneticiDetaylari.Name = "grpYoneticiDetaylari";
            this.grpYoneticiDetaylari.Size = new System.Drawing.Size(338, 315);
            this.grpYoneticiDetaylari.TabIndex = 2;
            this.grpYoneticiDetaylari.TabStop = false;
            this.grpYoneticiDetaylari.Text = "YÖNETİCİ DETAYLARI";
            // 
            // btnIptal
            // 
            this.btnIptal.Enabled = false;
            this.btnIptal.Font = new System.Drawing.Font("Impact", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.Location = new System.Drawing.Point(185, 269);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(146, 39);
            this.btnIptal.TabIndex = 15;
            this.btnIptal.Text = "İPTAL";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // dtpBitis
            // 
            this.dtpBitis.Enabled = false;
            this.dtpBitis.Location = new System.Drawing.Point(147, 209);
            this.dtpBitis.Name = "dtpBitis";
            this.dtpBitis.Size = new System.Drawing.Size(184, 25);
            this.dtpBitis.TabIndex = 14;
            // 
            // dtpBaslangic
            // 
            this.dtpBaslangic.Enabled = false;
            this.dtpBaslangic.Location = new System.Drawing.Point(147, 172);
            this.dtpBaslangic.Name = "dtpBaslangic";
            this.dtpBaslangic.Size = new System.Drawing.Size(184, 25);
            this.dtpBaslangic.TabIndex = 13;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Enabled = false;
            this.txtSoyad.Location = new System.Drawing.Point(147, 60);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(184, 25);
            this.txtSoyad.TabIndex = 12;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Enabled = false;
            this.txtTelefon.Location = new System.Drawing.Point(147, 97);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(184, 25);
            this.txtTelefon.TabIndex = 11;
            // 
            // txtMail
            // 
            this.txtMail.Enabled = false;
            this.txtMail.Location = new System.Drawing.Point(147, 130);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(184, 25);
            this.txtMail.TabIndex = 10;
            // 
            // txtAd
            // 
            this.txtAd.Enabled = false;
            this.txtAd.Location = new System.Drawing.Point(147, 23);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(184, 25);
            this.txtAd.TabIndex = 9;
            // 
            // chkPasif
            // 
            this.chkPasif.AutoSize = true;
            this.chkPasif.Enabled = false;
            this.chkPasif.Location = new System.Drawing.Point(147, 247);
            this.chkPasif.Name = "chkPasif";
            this.chkPasif.Size = new System.Drawing.Size(61, 23);
            this.chkPasif.TabIndex = 8;
            this.chkPasif.Text = "PASİF";
            this.chkPasif.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Enabled = false;
            this.btnKaydet.Font = new System.Drawing.Font("Impact", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(15, 270);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(146, 39);
            this.btnKaydet.TabIndex = 7;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "ÜYELİK DURUMU";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "BİTİŞ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "SOYAD: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "TELEFON: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "MAİL: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "BAŞLANGIÇ: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "AD: ";
            // 
            // grdYoneticiHareket
            // 
            this.grdYoneticiHareket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdYoneticiHareket.Enabled = false;
            this.grdYoneticiHareket.Location = new System.Drawing.Point(570, 45);
            this.grdYoneticiHareket.Name = "grdYoneticiHareket";
            this.grdYoneticiHareket.Size = new System.Drawing.Size(261, 316);
            this.grdYoneticiHareket.TabIndex = 17;
            // 
            // lstYoneticiler
            // 
            this.lstYoneticiler.ContextMenuStrip = this.ctxList;
            this.lstYoneticiler.Enabled = false;
            this.lstYoneticiler.FormattingEnabled = true;
            this.lstYoneticiler.Location = new System.Drawing.Point(16, 44);
            this.lstYoneticiler.Name = "lstYoneticiler";
            this.lstYoneticiler.Size = new System.Drawing.Size(204, 316);
            this.lstYoneticiler.TabIndex = 16;
            this.lstYoneticiler.SelectedIndexChanged += new System.EventHandler(this.lstYoneticiler_SelectedIndexChanged);
            // 
            // ctxList
            // 
            this.ctxList.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctxList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dÜZENLEToolStripMenuItem});
            this.ctxList.Name = "ctxList";
            this.ctxList.Size = new System.Drawing.Size(125, 26);
            // 
            // dÜZENLEToolStripMenuItem
            // 
            this.dÜZENLEToolStripMenuItem.Name = "dÜZENLEToolStripMenuItem";
            this.dÜZENLEToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.dÜZENLEToolStripMenuItem.Text = "DÜZENLE";
            // 
            // lblDonem
            // 
            this.lblDonem.AutoSize = true;
            this.lblDonem.BackColor = System.Drawing.Color.Transparent;
            this.lblDonem.Font = new System.Drawing.Font("Impact", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDonem.Location = new System.Drawing.Point(222, 9);
            this.lblDonem.Name = "lblDonem";
            this.lblDonem.Size = new System.Drawing.Size(24, 19);
            this.lblDonem.TabIndex = 15;
            this.lblDonem.Text = ". . .";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Impact", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 19);
            this.label8.TabIndex = 18;
            this.label8.Text = "DÖNEM: ";
            // 
            // frmYoneticiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 365);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblDonem);
            this.Controls.Add(this.grdYoneticiHareket);
            this.Controls.Add(this.lstYoneticiler);
            this.Controls.Add(this.grpYoneticiDetaylari);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmYoneticiler";
            this.Text = "YÖNETİCİLER";
            this.Load += new System.EventHandler(this.frmYoneticiler_Load);
            this.grpYoneticiDetaylari.ResumeLayout(false);
            this.grpYoneticiDetaylari.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdYoneticiHareket)).EndInit();
            this.ctxList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpYoneticiDetaylari;
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
        private System.Windows.Forms.DataGridView grdYoneticiHareket;
        private System.Windows.Forms.ListBox lstYoneticiler;
        private System.Windows.Forms.ContextMenuStrip ctxList;
        private System.Windows.Forms.ToolStripMenuItem dÜZENLEToolStripMenuItem;
        private System.Windows.Forms.Label lblDonem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnIptal;
    }
}