using DernekYonetim.BLL;
using DernekYonetim.UI.ViewModels;
using DernekYonetim.BLL.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DernekYonetim.UI
{
    public partial class FrmUyeler : Form
    {
        private UyeService uyeService;
        private MaliHareketlerService malihareketlerService;
        private bool isEditMode = false;
        private UyeDetayVM _uyedetayVM;
        private UyeDetayVM uyedetayVM
        {
            get { return _uyedetayVM; }
            set
            {
                _uyedetayVM = value;
                RefreshDetaySection();
            }
        }
        public FrmUyeler()
        {
            InitializeComponent();
            uyeService = new UyeService();
            malihareketlerService = new MaliHareketlerService();
        }
        private void FrmUyeler_Load(object sender, EventArgs e)
        {
            RefreshListe();
        }
        private void lstUyeler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstUyeler.SelectedItem == null) return;
            if (isEditMode)
            {
                CloseEditMode();
            }
            var selected = (UyeDTO)lstUyeler.SelectedItem;
            var detay = new UyeDetayVM()
            {
                Uye = uyeService.IdyeGoreUyeGetir(selected.UyeId)
            };
            detay.MaliHareketler = malihareketlerService.KisiIdyeGoreMaliHareketleriGetir(detay.Uye.KisiId);
            detay.GecikmisAidatlar = malihareketlerService.KisiIdyeGoreGecikmisAidatGetir(detay.Uye.KisiId);
            uyedetayVM = detay;
        }
        private void dÜZENLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isEditMode) return;
            else OpenEditMode();
        }
        private void CloseEditMode()
        {
            foreach (var item in grpUyeDetaylari.Controls)
            {
                (item as Control).Enabled = false;
            }
            isEditMode = false;
        }
        private void OpenEditMode()
        {
            foreach (var item in grpUyeDetaylari.Controls)
            {
                (item as Control).Enabled = true;
            }
            isEditMode = true;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            UyeDTO duzenlenmis = new UyeDTO()
            {
                Ad = txtAd.Text,
                Soyad = txtSoyad.Text,
                AktifMi = !chkPasif.Checked,
                Email = txtMail.Text,
                KisiId = (lstUyeler.SelectedItem as UyeDTO).KisiId,
                //(lstUyeler.SelectedItem object ti onu "as" ile cast ettik.
                Telefon = txtTelefon.Text,
                UyeId = (lstUyeler.SelectedItem as UyeDTO).UyeId,
                UyelikBaslangicTarihi = dtpBaslangic.Value
                //UyelikBitisTarihi bu da olmayıversin dedi
            };
            uyeService.UyeGuncelle(duzenlenmis);
            RefreshListe();
        }
        private void RefreshListe()
        {
            lstUyeler.DataSource = null;
            lstUyeler.DataSource = uyeService.UyeListesi().Select(x => new UyeListeVM() { UyeId = x.UyeId, AdSoyad = x.ToString() }).ToList();
            lstUyeler.DisplayMember = "AdSoyad";
            lstUyeler.ValueMember = "UyeId";
        }
        private void RefreshDetaySection()
        {
            txtAd.Text = uyedetayVM.Uye.Ad;
            txtSoyad.Text = uyedetayVM.Uye.Soyad;
            txtTelefon.Text = uyedetayVM.Uye.Telefon;
            txtMail.Text = uyedetayVM.Uye.Email;
            dtpBaslangic.Value = uyedetayVM.Uye.UyelikBaslangicTarihi;
            dtpBitis.Value = uyedetayVM.Uye.UyelikBitisTarihi.HasValue ? uyedetayVM.Uye.UyelikBitisTarihi.Value : default(DateTime);
            chkPasif.Checked = !uyedetayVM.Uye.AktifMi;
            RefreshAidatList();
            RefreshGridSource();
        }

        private void öDEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAidatOde aidatForm = new frmAidatOde((AidatDTO)
                lstOdenmemisAidat.SelectedItem);
            if (aidatForm.ShowDialog() == DialogResult.OK)
                AidatOdendi();
        }
        public void RefreshGridSource()
        {
            grdMaliHareket.DataSource = null;
            grdMaliHareket.DataSource = uyedetayVM.MaliHareketler;
        }
        public void RefreshAidatList()
        {
            lstOdenmemisAidat.DataSource = null;
            lstOdenmemisAidat.DataSource = uyedetayVM.GecikmisAidatlar;
        }
        public void AidatOdendi()
        {
            uyedetayVM.MaliHareketler = malihareketlerService.KisiIdyeGoreMaliHareketleriGetir(uyedetayVM.Uye.KisiId);
            uyedetayVM.GecikmisAidatlar = malihareketlerService.KisiIdyeGoreGecikmisAidatGetir(uyedetayVM.Uye.KisiId);
            RefreshAidatList();
            RefreshGridSource();
        }
    }
}
