using Tyuiu.UrlaherKA.Sprint2.Task1.V14.Lib;
namespace Tyuiu.UrlaherKA.Sprint2.Task1.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void CheckOperandOperation()
        {
            int a, b, c, d;
            a = 185;
            b = 216;
            c = 174;
            d = 917;
            bool[] res_wait = { false, true, true, true, true, false };
            bool[] res_Operation = ds.GetLogicOperations(a, b, c, d);
            CollectionAssert.AreEqual(res_wait,res_Operation);
        }
    }
}
