using Tyuiu.UrlaherKA.Sprint2.Task7.V9.Lib;
namespace Tyuiu.UrlaherKA.Sprint2.Task7.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void TestBlackArea()
        {
            double x = 1;
            double y = 0.4;
            bool res = ds.CheckDotInShadedArea(x, y);
            Assert.IsTrue(res);
        }
    }
}
