using DernekYonetim.DAL.Entities;
using DernekYonetim.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DernelYonetim.BLL.Tests.Fakes
{
    internal class UyeRepoFake : IRepo<Uye>
    {
        List<Uye> uyeler = new List<Uye>();
        public UyeRepoFake()
        {
            Uye uye1 = new Uye()
            {
                Id = 1,
                KisiId = 1,
                AktifMi = true,
                UyelikBitisTarihi = null,
                UyelikBaslangicTarihi = new DateTime(1991, 1, 1)
            };
            Uye uye2 = new Uye()
            {
                Id = 1,
                KisiId = 1,
                AktifMi = true,
                UyelikBitisTarihi = null,
                UyelikBaslangicTarihi = DateTime.Now
            };
            uyeler.Add(uye1);
            uyeler.Add(uye2);
        }
        public int Add(Uye item)
        {
            item.Id = uyeler.Count() + 1;
            uyeler.Add(item);
            return item.Id;
        }

        public List<Uye> GetAll()
        {
            return uyeler;
        }

        public Uye GetById(int Id)
        {
            return uyeler.SingleOrDefault(x => x.Id == Id);
        }

        public void Remove(Uye item)
        {
            uyeler.Remove(item);
        }

        public Uye Update(Uye item)
        {
            var degisecekitem = uyeler.SingleOrDefault(x => x.Id == item.Id);
            degisecekitem.KisiId = item.KisiId;
            degisecekitem.AktifMi = item.AktifMi;
            degisecekitem.UyelikBitisTarihi = item.UyelikBitisTarihi;
            degisecekitem.UyelikBaslangicTarihi = item.UyelikBaslangicTarihi;

            return degisecekitem;
        }
    }
}
