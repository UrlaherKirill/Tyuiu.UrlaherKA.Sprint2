
using Tyuiu.UrlaherKA.Sprint2.Task6.V11.Lib;
namespace Tyuiu.UrlaherKA.Sprint2.Task6.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void Default_Day()
        {
            int g, m, n;
            g = 1944;
            m = 10;
            n = 15;
            string res = ds.FindDateOfNextDay(g, m, n);
            string Wait_res = "16.10.1944";
            Assert.AreEqual(res, Wait_res);
        }
        [TestMethod]
        public void Next_Month()
        {
            int g, m, n;
            g = 1944;
            m = 10;
            n = 31;
            string res = ds.FindDateOfNextDay(g, m, n);
            string Wait_res = "01.11.1944";
            Assert.AreEqual(res, Wait_res);
        }
        [TestMethod]
        public void Next_year()
        {
            int g, m, n;
            g = 1944;
            m = 12;
            n = 31;
            string res = ds.FindDateOfNextDay(g, m, n);
            string Wait_res = "01.01.1945";
            Assert.AreEqual(res, Wait_res);

        }
        [TestMethod]
        public void Error_Day_Month()
        {
            int g, m, n;
            g = 1944;
            m = 13;
            n = 40;
            string res = ds.FindDateOfNextDay(g, m, n);
            string Wait_res = "Неправильно введён месяц или день";
            Assert.AreEqual(res, Wait_res);
        }
    }
}
