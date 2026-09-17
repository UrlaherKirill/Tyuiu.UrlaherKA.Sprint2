using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.UrlaherKA.Sprint2.Task0.V19.Lib
{
    public class DataService : ISprint2Task0V9
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = { x+72 == y, x != y, x < y, x+73 > y, x <= y, x+72 >= y };
            return res;
        }
    }
}
