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
                    case (1, 31): return res = $"0{n = 1}.0{m+1}.{g}";
                    case (2, 29): return res = $"0{n = 1}.0{m + 1}.{g}";
                    case (3, 31): return res = $"0{n = 1}.0{m + 1}.{g}";
                    case (4, 30): return res = $"0{n = 1}.0{m + 1}.{g}";
                    case (5, 31): return res = $"0{n = 1}.0{m + 1}.{g}";
                    case (6, 30): return res = $"0{n = 1}.0{m + 1}.{g}";
                    case (7, 31): return res = $"0{n = 1}.0{m + 1}.{g}";
                    case (8, 31): return res = $"0{n = 1}.0{m + 1}.{g}";
                    case (9, 30): return res = $"0{n = 1}.0{m + 1}.{g}";
                    case (10, 31): return res = $"0{n = 1}.{m + 1}.{g}";
                    case (11, 30): return res = $"0{n = 1}.{m + 1}.{g}";
                    case (12, 31): return res = $"0{n =1}.0{m =1}.{g +=1}"; 
                    default:
                        if (n < 10 & m < 10) res = $"0{n+1}.0{m}.{g}";
                        else if (n < 10) res = $"0{n+1}.{m}.{g}";
                        else if (m < 10) res = $"{n+1}.0{m}.{g}";
                        else res = $"{n+1}.{m}.{g}";
                        return res;
                }
            }
        }
    }
}
