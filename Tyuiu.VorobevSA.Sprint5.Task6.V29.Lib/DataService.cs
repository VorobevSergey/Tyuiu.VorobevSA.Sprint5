using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.VorobevSA.Sprint5.Task6.V29.Lib
{
    public class DataService : ISprint5Task6V29
    {
        public int LoadFromDataFile(string path)
        {
            string content = File.ReadAllText(path);
            int y = 0;
            foreach (char c in content)
            {
                if (c == Char.ToLower(c))
                {
                    y++;
                }
            }
            return y;
        }
    }
}
