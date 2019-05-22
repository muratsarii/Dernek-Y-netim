namespace DernekYonetim.UI
{
    partial class frmMain
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
            this.grpUyeler = new System.Windows.Forms.GroupBox();
            this.lblAktifYonetici = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblBuAyUyeOlanlar = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAktifUye = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpMuhasebe = new System.Windows.Forms.GroupBox();
            this.lblKasadanCikan = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblGuncelBakiye = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lblToplananBagis = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.grpAidatlar = new System.Windows.Forms.GroupBox();
            this.lblGuncelDonemAidat = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblToplamOdenenAidat = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblGuncelOdenmisAidat = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.grpToplantilar = new System.Windows.Forms.GroupBox();
            this.lblTamamlananToplanti = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblPlanlananToplanti = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.üYEİŞLEMLERİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yÖNETİCİİŞLEMLERİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tOPLANTIİŞLEMLERİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpUyeler.SuspendLayout();
            this.grpMuhasebe.SuspendLayout();
            this.grpAidatlar.SuspendLayout();
            this.grpToplantilar.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpUyeler
            // 
            this.grpUyeler.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpUyeler.Controls.Add(this.lblAktifYonetici);
            this.grpUyeler.Controls.Add(this.label6);
            this.grpUyeler.Controls.Add(this.lblBuAyUyeOlanlar);
            this.grpUyeler.Controls.Add(this.label4);
            this.grpUyeler.Controls.Add(this.lblAktifUye);
            this.grpUyeler.Controls.Add(this.label1);
            this.grpUyeler.Location = new System.Drawing.Point(12, 39);
            this.grpUyeler.Name = "grpUyeler";
            this.grpUyeler.Size = new System.Drawing.Size(317, 152);
            this.grpUyeler.TabIndex = 0;
            this.grpUyeler.TabStop = false;
            this.grpUyeler.Text = "ÜYELER";
            // 
            // lblAktifYonetici
            // 
            this.lblAktifYonetici.AutoSize = true;
            this.lblAktifYonetici.Enabled = false;
            this.lblAktifYonetici.Location = new System.Drawing.Point(191, 74);
            this.lblAktifYonetici.Name = "lblAktifYonetici";
            this.lblAktifYonetici.Size = new System.Drawing.Size(0, 24);
            this.lblAktifYonetici.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(222, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "AKTİF TÖNETİCİ SAYISI:";
            // 
            // lblBuAyUyeOlanlar
            // 
            this.lblBuAyUyeOlanlar.AutoSize = true;
            this.lblBuAyUyeOlanlar.Enabled = false;
            this.lblBuAyUyeOlanlar.Location = new System.Drawing.Point(191, 115);
            this.lblBuAyUyeOlanlar.Name = "lblBuAyUyeOlanlar";
            this.lblBuAyUyeOlanlar.Size = new System.Drawing.Size(0, 24);
            this.lblBuAyUyeOlanlar.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "BU AYKİ ÜYELER";
            // 
            // lblAktifUye
            // 
            this.lblAktifUye.AutoSize = true;
            this.lblAktifUye.Enabled = false;
            this.lblAktifUye.Location = new System.Drawing.Point(191, 33);
            this.lblAktifUye.Name = "lblAktifUye";
            this.lblAktifUye.Size = new System.Drawing.Size(0, 24);
            this.lblAktifUye.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "AKTİF ÜYE SAYISI: ";
            // 
            // grpMuhasebe
            // 
            this.grpMuhasebe.BackColor = System.Drawing.Color.OrangeRed;
            this.grpMuhasebe.Controls.Add(this.lblKasadanCikan);
            this.grpMuhasebe.Controls.Add(this.label16);
            this.grpMuhasebe.Controls.Add(this.lblGuncelBakiye);
            this.grpMuhasebe.Controls.Add(this.label20);
            this.grpMuhasebe.Controls.Add(this.lblToplananBagis);
            this.grpMuhasebe.Controls.Add(this.label22);
            this.grpMuhasebe.Location = new System.Drawing.Point(344, 197);
            this.grpMuhasebe.Name = "grpMuhasebe";
            this.grpMuhasebe.Size = new System.Drawing.Size(317, 152);
            this.grpMuhasebe.TabIndex = 1;
            this.grpMuhasebe.TabStop = false;
            this.grpMuhasebe.Text = "MUHASEBE";
            // 
            // lblKasadanCikan
            // 
            this.lblKasadanCikan.AutoSize = true;
            this.lblKasadanCikan.Enabled = false;
            this.lblKasadanCikan.Location = new System.Drawing.Point(266, 73);
            this.lblKasadanCikan.Name = "lblKasadanCikan";
            this.lblKasadanCikan.Size = new System.Drawing.Size(0, 24);
            this.lblKasadanCikan.TabIndex = 17;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(10, 73);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(171, 24);
            this.label16.TabIndex = 16;
            this.label16.Text = "KASADAN ÇIKAN: ";
            // 
            // lblGuncelBakiye
            // 
            this.lblGuncelBakiye.AutoSize = true;
            this.lblGuncelBakiye.Enabled = false;
            this.lblGuncelBakiye.Location = new System.Drawing.Point(266, 114);
            this.lblGuncelBakiye.Name = "lblGuncelBakiye";
            this.lblGuncelBakiye.Size = new System.Drawing.Size(0, 24);
            this.lblGuncelBakiye.TabIndex = 15;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(10, 114);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(168, 24);
            this.label20.TabIndex = 14;
            this.label20.Text = "GUNCEL BAKİYE: ";
            // 
            // lblToplananBagis
            // 
            this.lblToplananBagis.AutoSize = true;
            this.lblToplananBagis.Enabled = false;
            this.lblToplananBagis.Location = new System.Drawing.Point(266, 32);
            this.lblToplananBagis.Name = "lblToplananBagis";
            this.lblToplananBagis.Size = new System.Drawing.Size(0, 24);
            this.lblToplananBagis.TabIndex = 13;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(10, 32);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(183, 24);
            this.label22.TabIndex = 12;
            this.label22.Text = "TOPLANAN BAĞIŞ: ";
            // 
            // grpAidatlar
            // 
            this.grpAidatlar.BackColor = System.Drawing.Color.DimGray;
            this.grpAidatlar.Controls.Add(this.lblGuncelDonemAidat);
            this.grpAidatlar.Controls.Add(this.label8);
            this.grpAidatlar.Controls.Add(this.lblToplamOdenenAidat);
            this.grpAidatlar.Controls.Add(this.label10);
            this.grpAidatlar.Controls.Add(this.lblGuncelOdenmisAidat);
            this.grpAidatlar.Controls.Add(this.label12);
            this.grpAidatlar.Location = new System.Drawing.Point(344, 39);
            this.grpAidatlar.Name = "grpAidatlar";
            this.grpAidatlar.Size = new System.Drawing.Size(317, 152);
            this.grpAidatlar.TabIndex = 1;
            this.grpAidatlar.TabStop = false;
            this.grpAidatlar.Text = "AİDATLAR";
            // 
            // lblGuncelDonemAidat
            // 
            this.lblGuncelDonemAidat.AutoSize = true;
            this.lblGuncelDonemAidat.Enabled = false;
            this.lblGuncelDonemAidat.Location = new System.Drawing.Point(191, 74);
            this.lblGuncelDonemAidat.Name = "lblGuncelDonemAidat";
            this.lblGuncelDonemAidat.Size = new System.Drawing.Size(0, 24);
            this.lblGuncelDonemAidat.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(228, 24);
            this.label8.TabIndex = 10;
            this.label8.Text = "GÜNCEL DÖNEM AİDAT:";
            // 
            // lblToplamOdenenAidat
            // 
            this.lblToplamOdenenAidat.AutoSize = true;
            this.lblToplamOdenenAidat.Enabled = false;
            this.lblToplamOdenenAidat.Location = new System.Drawing.Point(191, 115);
            this.lblToplamOdenenAidat.Name = "lblToplamOdenenAidat";
            this.lblToplamOdenenAidat.Size = new System.Drawing.Size(0, 24);
            this.lblToplamOdenenAidat.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(240, 24);
            this.label10.TabIndex = 8;
            this.label10.Text = "TOPLAM ÖDENEN AİDAT:";
            // 
            // lblGuncelOdenmisAidat
            // 
            this.lblGuncelOdenmisAidat.AutoSize = true;
            this.lblGuncelOdenmisAidat.Enabled = false;
            this.lblGuncelOdenmisAidat.Location = new System.Drawing.Point(191, 33);
            this.lblGuncelOdenmisAidat.Name = "lblGuncelOdenmisAidat";
            this.lblGuncelOdenmisAidat.Size = new System.Drawing.Size(0, 24);
            this.lblGuncelOdenmisAidat.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(244, 24);
            this.label12.TabIndex = 6;
            this.label12.Text = "GÜNCEL ÖDENMİŞ AİDAT:";
            // 
            // grpToplantilar
            // 
            this.grpToplantilar.BackColor = System.Drawing.Color.Peru;
            this.grpToplantilar.Controls.Add(this.lblTamamlananToplanti);
            this.grpToplantilar.Controls.Add(this.label14);
            this.grpToplantilar.Controls.Add(this.lblPlanlananToplanti);
            this.grpToplantilar.Controls.Add(this.label18);
            this.grpToplantilar.Location = new System.Drawing.Point(12, 197);
            this.grpToplantilar.Name = "grpToplantilar";
            this.grpToplantilar.Size = new System.Drawing.Size(317, 152);
            this.grpToplantilar.TabIndex = 1;
            this.grpToplantilar.TabStop = false;
            this.grpToplantilar.Text = "TOPLANTILAR";
            // 
            // lblTamamlananToplanti
            // 
            this.lblTamamlananToplanti.AutoSize = true;
            this.lblTamamlananToplanti.Enabled = false;
            this.lblTamamlananToplanti.Location = new System.Drawing.Point(191, 87);
            this.lblTamamlananToplanti.Name = "lblTamamlananToplanti";
            this.lblTamamlananToplanti.Size = new System.Drawing.Size(0, 24);
            this.lblTamamlananToplanti.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 87);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(246, 24);
            this.label14.TabIndex = 16;
            this.label14.Text = "TAMAMLANAN TOPLANTI:";
            // 
            // lblPlanlananToplanti
            // 
            this.lblPlanlananToplanti.AutoSize = true;
            this.lblPlanlananToplanti.Enabled = false;
            this.lblPlanlananToplanti.Location = new System.Drawing.Point(191, 46);
            this.lblPlanlananToplanti.Name = "lblPlanlananToplanti";
            this.lblPlanlananToplanti.Size = new System.Drawing.Size(0, 24);
            this.lblPlanlananToplanti.TabIndex = 13;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 46);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(225, 24);
            this.label18.TabIndex = 12;
            this.label18.Text = "PLANLANAN TOPLANTI:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Impact", 11F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.üYEİŞLEMLERİToolStripMenuItem,
            this.yÖNETİCİİŞLEMLERİToolStripMenuItem,
            this.tOPLANTIİŞLEMLERİToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(673, 31);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // üYEİŞLEMLERİToolStripMenuItem
            // 
            this.üYEİŞLEMLERİToolStripMenuItem.Name = "üYEİŞLEMLERİToolStripMenuItem";
            this.üYEİŞLEMLERİToolStripMenuItem.Size = new System.Drawing.Size(126, 27);
            this.üYEİŞLEMLERİToolStripMenuItem.Text = "ÜYE İŞLEMLERİ";
            this.üYEİŞLEMLERİToolStripMenuItem.Click += new System.EventHandler(this.üYEİŞLEMLERİToolStripMenuItem_Click);
            // 
            // yÖNETİCİİŞLEMLERİToolStripMenuItem
            // 
            this.yÖNETİCİİŞLEMLERİToolStripMenuItem.Name = "yÖNETİCİİŞLEMLERİToolStripMenuItem";
            this.yÖNETİCİİŞLEMLERİToolStripMenuItem.Size = new System.Drawing.Size(166, 27);
            this.yÖNETİCİİŞLEMLERİToolStripMenuItem.Text = "YÖNETİCİ İŞLEMLERİ";
            this.yÖNETİCİİŞLEMLERİToolStripMenuItem.Click += new System.EventHandler(this.yÖNETİCİİŞLEMLERİToolStripMenuItem_Click);
            // 
            // tOPLANTIİŞLEMLERİToolStripMenuItem
            // 
            this.tOPLANTIİŞLEMLERİToolStripMenuItem.Name = "tOPLANTIİŞLEMLERİToolStripMenuItem";
            this.tOPLANTIİŞLEMLERİToolStripMenuItem.Size = new System.Drawing.Size(168, 27);
            this.tOPLANTIİŞLEMLERİToolStripMenuItem.Text = "TOPLANTI İŞLEMLERİ";
            this.tOPLANTIİŞLEMLERİToolStripMenuItem.Click += new System.EventHandler(this.tOPLANTIİŞLEMLERİToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(673, 362);
            this.Controls.Add(this.grpMuhasebe);
            this.Controls.Add(this.grpAidatlar);
            this.Controls.Add(this.grpUyeler);
            this.Controls.Add(this.grpToplantilar);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = "MAİN";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpUyeler.ResumeLayout(false);
            this.grpUyeler.PerformLayout();
            this.grpMuhasebe.ResumeLayout(false);
            this.grpMuhasebe.PerformLayout();
            this.grpAidatlar.ResumeLayout(false);
            this.grpAidatlar.PerformLayout();
            this.grpToplantilar.ResumeLayout(false);
            this.grpToplantilar.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpUyeler;
        private System.Windows.Forms.GroupBox grpMuhasebe;
        private System.Windows.Forms.GroupBox grpAidatlar;
        private System.Windows.Forms.GroupBox grpToplantilar;
        private System.Windows.Forms.Label lblAktifYonetici;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblBuAyUyeOlanlar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAktifUye;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblKasadanCikan;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblGuncelBakiye;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblToplananBagis;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lblGuncelDonemAidat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblToplamOdenenAidat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblGuncelOdenmisAidat;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblTamamlananToplanti;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblPlanlananToplanti;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem üYEİŞLEMLERİToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yÖNETİCİİŞLEMLERİToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tOPLANTIİŞLEMLERİToolStripMenuItem;
    }
}