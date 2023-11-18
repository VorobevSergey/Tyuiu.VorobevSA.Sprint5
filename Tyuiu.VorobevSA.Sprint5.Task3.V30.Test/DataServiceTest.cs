using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.VorobevSA.Sprint5.Task3.V30.Lib;

namespace Tyuiu.VorobevSA.Sprint5.Task3.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            string path = @"C:\Users\vorob\source\repos\Tyuiu.VorobevSA.Sprint5\Tyuiu.VorobevSA.Sprint5.Task3.V30\bin\Debug\OutPutFileTask3.bin";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
