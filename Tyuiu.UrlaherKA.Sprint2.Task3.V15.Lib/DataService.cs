using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.UrlaherKA.Sprint2.Task3.V15.Lib
{
    public class DataService : ISprint2Task3V15
    {
        public double Calculate(double x)
        {
            if (x > 1) return Math.Round(x + Math.Pow((x + 1) / (x - 1), x),3);

            else if (x == 0) return Math.Round((x * x - Math.Cos(x * x) + 10) / (x * x - Math.Sin(x * x) + 12),3);

            else if (x < -19) return Math.Round(x + 10 * x - (1 / x),3);

            else return Math.Round(Math.Pow(1+ (1/(x*x)),8),3);
        }
    }
}
