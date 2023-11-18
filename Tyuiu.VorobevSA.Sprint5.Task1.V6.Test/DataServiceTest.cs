using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.VorobevSA.Sprint5.Task1.V6.Lib;

namespace Tyuiu.VorobevSA.Sprint5.Task1.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\vorob\source\repos\Tyuiu.VorobevSA.Sprint5\Tyuiu.VorobevSA.Sprint5.Task1.V6\bin\Debug\OutPutFileTask1.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
