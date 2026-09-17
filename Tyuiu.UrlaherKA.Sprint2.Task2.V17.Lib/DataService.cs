using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.UrlaherKA.Sprint2.Task2.V17.Lib
{
    public class DataService : ISprint2Task2V17
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            if ((x <= 2 & y <= 15) |
                (x <= 15 & y <= 2) |
                ((x >= 13 & y <= 15) & (x != 13 & y != 4)) |
                ((x <= 15 & y >= 12) & (x != 7 & y != 12) & (x != 10 & y != 12)) |
                (x <= 5 & (y <= 10 & y >= 8)) |
                ((x == 8 | x == 9) & y <= 8) |
                (x >= 11 & (y >= 6 & y <= 9)) |
                ((x >= 6 & x <= 8) & y <= 4)) return false;
            else return true;

        }
    }
}
