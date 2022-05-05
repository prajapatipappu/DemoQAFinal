using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Elements
{
    internal class UploadAndDownload
    {
        public static void Upload_and_Downloads()
        {
            IWebDriver Driver = new ChromeDriver();
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            Thread.Sleep(2000);
            Driver.Navigate().GoToUrl("https://demoqa.com/upload-download");
            Driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            Driver.FindElement(By.Id("uploadFile")).SendKeys(@"D:\incrideble india pic\IMG_20181215_192745.jpg");
            Thread.Sleep(2000);

            Driver.FindElement(By.Id("downloadButton")).Click();
            Thread.Sleep(5000);
            Driver.Close();
            Driver.Quit();

        }
    }
}
