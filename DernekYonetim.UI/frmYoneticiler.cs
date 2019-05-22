using DernekYonetim.BLL;
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
using DernekYonetim.UI.ViewModels;
namespace DernekYonetim.UI
{
    public partial class frmYoneticiler : Form
    {
        private YoneticiService yoneticiService;
        YoneticiDTO YoneticiDto;
        private bool isEditMode = false;
        private YoneticilerListeVM _yoneticiVM;
        public YoneticilerListeVM yoneticiVM
        {
            get { return _yoneticiVM; }
            set { _yoneticiVM = value; }
        }
        public frmYoneticiler()
        {
            InitializeComponent();
            yoneticiService = new YoneticiService();
        }

        private void frmYoneticiler_Load(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void lstYoneticiler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstYoneticiler.SelectedItem == null) return;
            if (isEditMode) ClobeEditMode();
            var selected = (YoneticiDTO)lstYoneticiler.SelectedItem;
            var detay = new YoneticilerListeVM()
            {
                yonetici = yoneticiService.IdyeGoreYoneticiGetir(selected.UnvanId)
            };
        }
        private void ClobeEditMode()
        {
            foreach (var item in grpYoneticiDetaylari.Controls)
            {
                (item as Control).Enabled = false;
            }
            isEditMode = false;
        }
    }
}
