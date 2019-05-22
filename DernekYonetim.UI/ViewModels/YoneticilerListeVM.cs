using DernekYonetim.BLL.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DernekYonetim.UI.ViewModels
{
    public class YoneticilerListeVM
    {
        public int YoneticiId { get; set; }
        public string AdSoyad { get; set; }
        public YoneticiDTO yonetici { get; set; }
    }
}
