using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.KrutikovaVP.Sprint5.Task0.V25;

namespace Tyuiu.KrutikovaVP.Sprint5.Task0.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckExistsFile()
        {
            string path = @"C:\Users\Валерия\source\repos\Tyuiu.KrutikovaVP.Sprint5\Tyuiu.KrutikovaVP.Sprint5.Task0.V25\bin\Debug\OutPutFileTask0.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
