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
    internal class WebTables
    {
        public static void web_Tables()
        {
            IWebDriver Driver = new ChromeDriver();
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            Thread.Sleep(2000);
            Driver.Navigate().GoToUrl("https://demoqa.com/webtables");
            Driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            Driver.FindElement(By.Id("addNewRecordButton")).Click();
            Driver.FindElement(By.Id("firstName")).SendKeys("Pappu");
            Driver.FindElement(By.Id("lastName")).SendKeys("kumar");
            Driver.FindElement(By.Id("userEmail")).SendKeys("pappukumarbcet2019@gmail.com");
            Driver.FindElement(By.Id("age")).SendKeys("21");
            Driver.FindElement(By.Id("salary")).SendKeys("5000");
            Driver.FindElement(By.Id("department")).SendKeys("IT");
            Thread.Sleep(2000);
            Driver.FindElement(By.Id("submit")).Click();

            Thread.Sleep(2000);
            Driver.Close();
            Driver.Quit();
        }
    }
}
