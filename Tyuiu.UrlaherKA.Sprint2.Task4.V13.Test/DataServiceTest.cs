using Tyuiu.UrlaherKA.Sprint2.Task4.V13.Lib;
namespace Tyuiu.UrlaherKA.Sprint2.Task4.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void CheckExample1()
        {
            double x = 1;
            double y = 1;
            double res = ds.Calculate(x, y);
            double res_Wait = 10;
            Assert.AreEqual(res, res_Wait);
        }
        [TestMethod]
        public void CheckExample2()
        {
            double x = 1;
            double y = 22;
            double res = ds.Calculate(x, y);
            double res_Wait = 0.030;
            Assert.AreEqual(res, res_Wait);
        }
    }
}
