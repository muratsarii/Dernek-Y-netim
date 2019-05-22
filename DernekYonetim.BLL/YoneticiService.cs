using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DernekYonetim.BLL.DTOs;
using DernekYonetim.DAL.Entities;
using DernekYonetim.DAL.Repositories;

namespace DernekYonetim.BLL
{
    public class YoneticiService
    {
        private YoneticiRepo yoneticiRepo;
        private UnvanRepo unvanRepo;
        private KisiRepo kisiRepo;

        public YoneticiService()
        {
            yoneticiRepo = new YoneticiRepo();
            unvanRepo = new UnvanRepo();
            kisiRepo = new KisiRepo();
        }

        public int AktifYoneticiSayisi ()
        {
            return yoneticiRepo.GetAll().Where(yon => yon.BitisTarihi == null).Count();
        }
        public List<YoneticiDTO> YoneticiListesi()
        {
            var yoneticiEntites = yoneticiRepo.GetAll();
            var kisiEntities = kisiRepo.GetAll();
            List<YoneticiDTO> yoneticiDtos = new List<YoneticiDTO>();
            foreach (var item in yoneticiEntites)
            {
                var yonetici = kisiEntities.SingleOrDefault(x => x.Id == item.Id);
                //var yonetici1 = kisiEntities.Where(x => x.Id == item.Id);
                yoneticiDtos.Add(new YoneticiDTO()
                {
                    UnvanId = item.UnvanId,
                    BaslangicTarihi = item.BaslangicTarihi,
                    BitisTarihi = item.BitisTarihi,
                    KisiId = yonetici.Id,
                    //KisiId = item.KisiId,
                    Ad = yonetici.Ad,
                    Soyad = yonetici.Soyad,
                    Email = yonetici.Email,
                    Telefon = yonetici.Telefon
                });
            }
            return yoneticiDtos;
        }
        public void YoneticiGuncelle(YoneticiDTO item)
        {
            var kisi = new Kisi()
            {
                Id = item.KisiId,
                Ad = item.Ad,
                Soyad = item.Soyad,
                Email = item.Email,
                Telefon = item.Telefon
            };
            var yonetici = new Yonetici()
            {
                Id = item.KisiId,
                UnvanId = item.UnvanId,
                BaslangicTarihi = item.BaslangicTarihi,
                BitisTarihi = item.BitisTarihi
            };
            kisiRepo.Update(kisi);
            yoneticiRepo.Update(yonetici);
        }
        public YoneticiDTO IdyeGoreYoneticiGetir(int YoneticiId)
        {
            var yonetici = yoneticiRepo.GetById(YoneticiId);
            var kisi = kisiRepo.GetById(yonetici.KisiId);
            var yoneticiDto = new YoneticiDTO()
            {
                KisiId = yonetici.Id,
                //KisiId = item.KisiId,
                UnvanId = yonetici.UnvanId,
                BaslangicTarihi = yonetici.BaslangicTarihi,
                BitisTarihi = yonetici.BitisTarihi,
                Ad = kisi.Ad,
                Soyad = kisi.Soyad,
                Email = kisi.Email,
                Telefon = kisi.Telefon
            };
            return yoneticiDto;
        }
    }
}
