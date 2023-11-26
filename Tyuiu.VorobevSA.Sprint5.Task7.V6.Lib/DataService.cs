using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.VorobevSA.Sprint5.Task7.V6.Lib
{
    public class DataService : ISprint5Task7V6
    {
        public string LoadDataAndSave(string path)
        {
            string outputpath = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask7V6.txt";
            string[] content = File.ReadAllText(path).Split(' ');
            string a = "";
            for (int i = 0; i < content.Length; i++)
            {
                if (!(int.TryParse(content[i], out int number) && content[i].Length == 1))
                {
                    a += content[i] + " ";
                }
            }
            a = a.Substring(0, a.Length - 2);
            File.WriteAllText(outputpath, a);

            return outputpath;
        }
    }
}
