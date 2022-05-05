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
    internal class Links
    {
        public static void Link()
        {
            IWebDriver Driver = new ChromeDriver();
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            Thread.Sleep(2000);
            Driver.Navigate().GoToUrl("https://demoqa.com/links");
            Driver.Manage().Window.Maximize();

            Driver.FindElement(By.Id("simpleLink")).Click();
            string h = Driver.WindowHandles[1];

            string o = Driver.WindowHandles[0];
            Driver.SwitchTo().Window(h);
            Driver.Manage().Window.Maximize();
            Thread.Sleep(3000);
            Driver.Close();
            Thread.Sleep(3000);
            Driver.SwitchTo().Window(o);
            Thread.Sleep(2000);

            Driver.FindElement(By.Id("created")).Click();
            Thread.Sleep(2000);

            js.ExecuteScript("window.scrollBy(0,200)");
            Thread.Sleep(2000);

            Driver.FindElement(By.Id("no-content")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.Id("moved")).Click();
            Thread.Sleep(2000);

            js.ExecuteScript("window.scrollBy(0,200)");
            Thread.Sleep(2000);

            Driver.FindElement(By.Id("bad-request")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.Id("forbidden")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.Id("invalid-url")).Click();
            Thread.Sleep(2000);
            Driver.Close();
            Driver.Quit();
        }
    }
}
