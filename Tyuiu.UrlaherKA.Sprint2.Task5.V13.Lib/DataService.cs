using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.UrlaherKA.Sprint2.Task5.V13.Lib
{
    public class DataService : ISprint2Task5V13
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            String res;
            if (m > 12 | m <= 0 | n > 31 | n <= 0) return res = "Неправильно введён месяц или день";
            else
            {

            
                switch (m, n)
                {
                    case (1, 31):
                        m += 1;
                        n = 1;
                        break;
                    case (2, 29):
                        m += 1;
                        n = 1;
                        break;
                    case (3, 31):
                        m += 1;
                        n = 1;
                        break;
                    case (4, 30):
                        m += 1;
                        n = 1;
                        break;
                    case (5, 31):
                        m += 1;
                        n = 1;
                        break;
                    case (6, 30):
                        m += 1;
                        n = 1;
                        break;
                    case (7, 31):
                        m += 1;
                        n = 1;
                        break;
                    case (8, 31):
                        m += 1;
                        n = 1;
                        break;
                    case (9, 30):
                        m += 1;
                        n = 1;
                        break;
                    case (10, 31):
                        m += 1;
                        n = 1;
                        break;
                    case (11, 30):
                        m += 1;
                        n = 1;
                        break;
                    case (12, 31):
                        m = 1;
                        n = 1;
                        g += 1;
                        break;
                    default:
                        n += 1;
                        break;
                }
                if (n < 10 & m < 10) res = $"0{n}.0{m}.{g}";
                else if (n < 10) res = $"0{n}.{m}.{g}";
                else if (m < 10) res = $"{n}.0{m}.{g}";
                else res = $"{n}.{m}.{g}";
                return res;
            }
    
        }       
    }
}
