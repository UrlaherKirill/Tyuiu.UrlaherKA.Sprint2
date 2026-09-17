using Tyuiu.UrlaherKA.Sprint2.Task5.V13.Lib;
namespace Tyuiu.UrlaherKA.Sprint2.Task5.V13.Test
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
            string Wait_res = "1944,10,16";
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
            string Wait_res = "1944,11,1";
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
            string Wait_res = "1945,1,1";
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
