using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZaharovVV.Sprint1.Task1.V6.Lib;

namespace Tyuiu.ZaharovVV.Sprint1.Task1.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void SumValidChecker()
        {
            Assert.AreEqual(10, DataService.Sum(5, 5));
        }

        [TestMethod]
        public void MultiplieValidChecker()
        {
            Assert.AreEqual(10, DataService.Multipie(2, 5));
        }
    }
}