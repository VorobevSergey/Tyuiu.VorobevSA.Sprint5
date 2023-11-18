﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.VorobevSA.Sprint5.Task0.V29.Lib
{
    public class DataService : ISprint5Task0V29
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask0.txt";
            double z =Math.Round( (6.1 * Math.Pow(x, 3) + 0.23 * Math.Pow(x, 2) + 1.04 * x),3);
            File.WriteAllText(path, Convert.ToString(z));
            return path;
        }
    }
}
