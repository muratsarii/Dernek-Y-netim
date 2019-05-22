using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DernekYonetim.DAL.Tests
{
    [TestClass]
    public class AdoProviderShould
    {
        [TestMethod]
        public void GetThreeHareketTipiWithScalar()
        {
            var cmdText = "SELECT COUNT(*) FROM HareketTip";
            AdoProvider provider = new AdoProvider("Server = PC-551; Database=DernekYonetimDb;Integreted Security = True;");
            var result = provider.ExecuteScalar(cmdText);

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void GetIntWithScalar()
        {
            var cmdText = "SELECT COUNT(*) FROM HareketTip";
            AdoProvider provider = new AdoProvider("Server = PC-551; Database=DernekYonetimDb;Integreted Security = True;");
            var result = provider.ExecuteScalar<int>(cmdText);

            Assert.AreEqual(typeof(int),result.GetType());
        }           // generic metodumuza gidiyor direk
    }
}
