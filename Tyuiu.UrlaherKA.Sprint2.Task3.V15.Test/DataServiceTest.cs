using Tyuiu.UrlaherKA.Sprint2.Task3.V15.Lib;
namespace Tyuiu.UrlaherKA.Sprint2.Task3.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void ExampleTest1()
        {
            double x = 2;
            double res = ds.Calculate(x);
            double Wait_res = 11;
            Assert.AreEqual(Wait_res, res);
        }

        [TestMethod]
        public void ExampleTest2()
        {
            double x = 0;
            double res = ds.Calculate(x);
            double Wait_res = 0.75;
            Assert.AreEqual(Wait_res, res);
        }

        [TestMethod]
        public void ExampleTest3()
        {
            double x = 1;
            double res = ds.Calculate(x);
            double Wait_res = 256;
            Assert.AreEqual(Wait_res, res);
        }

        [TestMethod]
        public void ExampleTest4()
        {
            double x = -20;
            double res = ds.Calculate(x);
            double Wait_res = -219.95;
            Assert.AreEqual(Wait_res, res);
        }
    }
}
