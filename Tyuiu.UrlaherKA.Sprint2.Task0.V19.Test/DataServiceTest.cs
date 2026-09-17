using Tyuiu.UrlaherKA.Sprint2.Task0.V19.Lib;
namespace Tyuiu.UrlaherKA.Sprint2.Task0.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void CheckBoolList()
        {
            int x = 105;
            int y = 177;
            bool[] Wait_res = { true, true, true, true, true, true };
            bool[] res = ds.GetCompareOperations(x,y);
            CollectionAssert.AreEqual(Wait_res, res);
        }
    }
}
