using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DernekYonetim.BLL;

namespace DernekYonetim.UI
{
    public partial class frmMain : Form
    {
        private UyeService uyeService;
        private ToplantiService toplantiService;
        private MaliHareketlerService malihareketlerService;
        private YoneticiService yoneticiService;

        public frmMain()
        {
            InitializeComponent();
            uyeService = new UyeService();
            toplantiService = new ToplantiService();
            malihareketlerService = new MaliHareketlerService();
            yoneticiService = new YoneticiService();
        }
        
        private void frmMain_Load(object sender, EventArgs e)
        {
            FillDashBoard();
        }

        private void FillDashBoard()
        {
            lblAktifUye.Text = uyeService.AktifUyeSayisi().ToString();
            lblAktifYonetici.Text = yoneticiService.AktifYoneticiSayisi().ToString();
            lblGuncelDonemAidat.Text = malihareketlerService.GuncelOdenmisAidatMiktar().ToString();
            lblBuAyUyeOlanlar.Text = uyeService.BuaykiUyeSayisi().ToString();
            lblGuncelOdenmisAidat.Text = malihareketlerService.GuncelOdenmisAidatSayisi().ToString();
            lblGuncelBakiye.Text = malihareketlerService.GuncelBakiye().ToString();
            lblKasadanCikan.Text = malihareketlerService.ToplamCikanParaMiktar().ToString();
            lblPlanlananToplanti.Text = toplantiService.PlanlananToplantiSayisi().ToString();
            lblTamamlananToplanti.Text = toplantiService.TamamlananToplantiSayisi().ToString();
            lblToplananBagis.Text = malihareketlerService.ToplamOdenmisBagisMiktar().ToString();
            lblToplamOdenenAidat.Text = malihareketlerService.ToplamOdenmisAidatMiktar().ToString();
            
        }

        private void üYEİŞLEMLERİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUyeler uyeForm = new FrmUyeler();
            uyeForm.ShowDialog();
        }

        private void yÖNETİCİİŞLEMLERİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmYoneticiler yoneticilerForm = new frmYoneticiler();
            yoneticilerForm.ShowDialog();
        }

        private void tOPLANTIİŞLEMLERİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmToplantiIslemleri toplantiIslemleriForm = new frmToplantiIslemleri();
            toplantiIslemleriForm.Show();
        }
    }
}
