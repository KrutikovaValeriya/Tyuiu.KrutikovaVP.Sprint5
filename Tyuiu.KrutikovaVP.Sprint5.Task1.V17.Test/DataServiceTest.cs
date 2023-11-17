using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.KrutikovaVP.Sprint5.Task1.V17.Lib;

namespace Tyuiu.KrutikovaVP.Sprint5.Task1.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckExistsFile()
        {
            string path = @"C:\Users\Валерия\source\repos\Tyuiu.KrutikovaVP.Sprint5\Tyuiu.KrutikovaVP.Sprint5.Task1.V17\bin\Debug\OutPutFileTask1.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
