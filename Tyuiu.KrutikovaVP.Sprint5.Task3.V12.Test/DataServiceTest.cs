using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.KrutikovaVP.Sprint5.Task3.V12.Lib;

namespace Tyuiu.KrutikovaVP.Sprint5.Task3.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckExistsFile()
        {
            string path = @"C:\Users\Валерия\source\repos\Tyuiu.KrutikovaVP.Sprint5\Tyuiu.KrutikovaVP.Sprint5.Task2.V28\bin\Debug\OutPutFileTask2.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
