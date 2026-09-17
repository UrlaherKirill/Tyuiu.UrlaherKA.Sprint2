using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.UrlaherKA.Sprint2.Task4.V13.Lib
{
    public class DataService : ISprint2Task4V13
    {
        public double Calculate(double x, double y)
        {
            double z = 0;
            return Math.Round((Math.Sqrt(x) * 3 > y * 2 - 20) ? (z = ( x + 10 * y - (1 / x))) : (z = ((x * x + Math.Pow(Math.Cos(y),2) + 13) / (y * y - Math.Pow(Math.Sin(y),2) + 9))),3);
        }
    }
}
