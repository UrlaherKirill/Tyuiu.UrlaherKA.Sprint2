using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.UrlaherKA.Sprint2.Task6.V11.Lib
{
    public class DataService : ISprint2Task6V11
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            String res;
            if (m > 12 | m <= 0 | n > 31 | n <= 0) return res = "Неправильно введён месяц или день";
            else
            {
                switch (m, n)
                {
                    case (1, 31): return res = $"{g},{m+1},{n = 1}";
                    case (2, 29): return res = $"{g},{m + 1},{n =1}";
                    case (3, 31): return res = $"{g},{m + 1},{n =1}";
                    case (4, 30): return res = $"{g},{m + 1},{n =1}";
                    case (5, 31): return res = $"{g},{m + 1},{n =1}";
                    case (6, 30): return res = $"{g},{m + 1},{n =1}";
                    case (7, 31): return res = $"{g},{m + 1},{n =1}";
                    case (8, 31): return res = $"{g},{m + 1},{n =1}";
                    case (9, 30): return res = $"{g},{m + 1},{n =1}";
                    case (10, 31): return res = $"{g},{m + 1},{n =1}";
                    case (11, 30): return res = $"{g},{m + 1},{n =1}";
                    case (12, 31): return res = $"{g+=1},{m =1},{n =1}"; 
                    default: return res = $"{g},{m},{n += 1}";
                }
            }
        }
    }
}
