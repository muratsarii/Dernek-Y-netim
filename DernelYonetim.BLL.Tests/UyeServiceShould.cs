using System;
using System.Collections.Generic;
using DernekYonetim.BLL;
using DernekYonetim.DAL.Entities;
using DernekYonetim.DAL.Repositories;
using DernelYonetim.BLL.Tests.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace DernelYonetim.BLL.Tests
{
    [TestClass]
    public class UyeServiceShould
    {
        [TestMethod]
        public void GetAktifUyeSayisi_3_WithStub()
        {
            var uyeRepoStub = new UyeRepoStub();
            UyeService uyeService = new UyeService(uyeRepoStub);
            var actual = uyeService.BuaykiUyeSayisi();
            var expected = 3;
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void GetBuAykiUyeSayisi_2_WithStub()
        {
            var uyeRepoStub = new UyeRepoStub();
            UyeService uyeService = new UyeService(uyeRepoStub);
            var actual = uyeService.BuaykiUyeSayisi();
            var expected = 2;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetAktifUyeSayısı_3_WithFake()
        {
            var uyeRepoFake = new UyeRepoFake();
            UyeService uyeService = new UyeService(uyeRepoFake);

            var actual = uyeService.AktifUyeSayisi();
            var expected = 3;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetBuAykiUyeSayısı_1_WithFake()
        {
            var uyeRepoFake = new UyeRepoFake();
            UyeService uyeService = new UyeService(uyeRepoFake);

            var actual = uyeService.AktifUyeSayisi();
            var expected = 1;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetAktifUyeSayısı_3_WithMock()
        {

            List<Uye> uyelerList = new List<Uye>();
            Uye uye1 = new Uye()
            {
                Id = 1,
                AktifMi = true,
                UyelikBaslangicTarihi = new DateTime(1991, 1, 1),
                UyelikBitisTarihi = null,
                KisiId = 1,
            };
            Uye uye2 = new Uye()
            {
                Id = 2,
                AktifMi = true,
                UyelikBaslangicTarihi = new DateTime(1993, 2, 12),
                UyelikBitisTarihi = null,
                KisiId = 2,
            };
            Uye uye3 = new Uye()
            {
                Id = 3,
                AktifMi = true,
                UyelikBaslangicTarihi = DateTime.Now,
                UyelikBitisTarihi = null,
                KisiId = 3,
            };
            uyelerList.Add(uye1);
            uyelerList.Add(uye2);
            uyelerList.Add(uye3);

            Mock<IRepo<Uye>> uyeRepoMock = new Mock<IRepo<Uye>>();
            uyeRepoMock.Setup(x => x.GetAll()).Returns(uyelerList);

            UyeService uyeService = new UyeService(uyeRepoMock.Object);
            var actual = uyeService.AktifUyeSayisi();
            var expected = 3;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CallGetAllinRepo()
        {
            Mock<IRepo<Uye>> uyerepoMock = new Mock<IRepo<Uye>>();
            UyeService uyeService = new UyeService(uyerepoMock.Object);
            uyerepoMock.Setup(x => x.GetAll()).Returns(new List<Uye>());
        }
    }
}
