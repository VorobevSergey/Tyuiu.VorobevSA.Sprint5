using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.VorobevSA.Sprint5.Task1.V6.Lib
{
    public class DataService : ISprint5Task1V6
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask1.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }
            double y;
            string stry;
            for(int x=startValue; x <= stopValue; x++)
            {
                y =Math.Round( (Math.Cos(x) + ((4 * x) / 2) - Math.Sin(x) * 3 * x),2);
                stry = Convert.ToString(y);

                if (x != stopValue)
                {
                    File.AppendAllText(path, stry + Environment.NewLine);

                }
                else
                {
                    File.AppendAllText(path, stry);
                }
            }
            return path;
        }
    }
}
