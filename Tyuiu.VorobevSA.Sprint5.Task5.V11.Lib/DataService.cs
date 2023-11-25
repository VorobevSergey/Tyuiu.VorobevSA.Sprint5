using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.VorobevSA.Sprint5.Task5.V11.Lib
{
    public class DataService : ISprint5Task5V11
    {
        public double LoadFromDataFile(string path)
        {
            using (StreamReader reader=new StreamReader(path))
            {
                string[] strNumbs = File.ReadAllLines(path);
                int mostX = 0;
                double count = 0;
                double summ = 0;
                foreach (string number in strNumbs)
                    if (!number.Contains(',') && int.Parse(number) %2 != 0 && int.Parse(number) > mostX)
                    {
                        mostX = int.Parse(number);
                    }
                double res = 0;
                for (int i = 1; i <= mostX; i++)
                {
                    if (i % 5 == 0)
                    {
                        count++;
                        summ *= i;
                        res = Math.Round(count, 3);

                    }

                }
                return res;
            }
        }
    }
}
