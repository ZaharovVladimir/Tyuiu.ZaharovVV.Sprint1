using Tyuiu.ZaharovVV.Sprint1.Task2.V6.Lib;

namespace Tyuiu.ZaharovVV.Sprint1.Task2.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 124;
            var res = ds.ConvertMToKm(x);
            Assert.AreEqual(res, 0, 124);
        }
    }
}