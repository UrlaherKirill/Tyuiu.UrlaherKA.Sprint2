using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.UrlaherKA.Sprint2.Task1.V14.Lib
{
    public class DataService : ISprint2Task1V14
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = { 
                (a == b) | (c > d),
                (a < b) & (d > c),
                (a != b) || (a == b),
                (a != d) && (c < b),
                !(a == b),
                (a != c) ^ (a < d)
            };
            return res;
        }
    }
}
