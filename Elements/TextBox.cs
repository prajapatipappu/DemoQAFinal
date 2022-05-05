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
    internal class TextBox
    {
        public static void Text_Box()
        {
            IWebDriver Driver = new ChromeDriver();
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            Thread.Sleep(2000);

            Driver.Navigate().GoToUrl("https://demoqa.com/text-box");
            Driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//input[@id='userName']")).SendKeys("Pappu Kumar");
            Thread.Sleep(2000);
            Driver.FindElement(By.Id("userEmail")).SendKeys("pappukumarbcet2019@gmail.com");
            Thread.Sleep(2000);
            Driver.FindElement(By.Id("currentAddress")).SendKeys("sarai, vaishali, Bihar");
            Thread.Sleep(2000);
            Driver.FindElement(By.Id("permanentAddress")).SendKeys("Same As Current Address");

            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollBy(0,500)");
            Thread.Sleep(2000);

            Driver.FindElement(By.Id("submit")).Click();
            Task.Delay(2000).Wait();

            Console.WriteLine("test case ended");


            Driver.Close();
            Driver.Quit();




        }
    }
}
