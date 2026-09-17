using Tyuiu.UrlaherKA.Sprint2.Task2.V17.Lib;
namespace Tyuiu.UrlaherKA.Sprint2.Task2.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void CheckBlackSquare()
        {
            int x = 9;
            int y = 6;
            bool res = ds.CheckDotInShadedArea(x, y);
            Assert.IsTrue(res);
        }
    }
}
