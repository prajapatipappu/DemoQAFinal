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
    internal class BrokenLinksImages
    {
        public static void Broken_Link_Image()
        {
            IWebDriver Driver = new ChromeDriver();
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            Thread.Sleep(2000);


            Driver.Navigate().GoToUrl("https://demoqa.com/broken");
            Driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            //Driver.FindElement(By.XPath("//a[contains(text(),'Click Here for Valid Link')]")).Click();
            //Driver.FindElement(By.XPath("//a[@href='http://demoqa.com']")).Click();
            Thread.Sleep(2000);

            js.ExecuteScript("window scrrolBy(0,200)");
            Thread.Sleep(2000);

            string h = Driver.WindowHandles[1];

            string o = Driver.WindowHandles[0];
            Driver.SwitchTo().Window(h);
            Driver.Manage().Window.Maximize();
            Thread.Sleep(3000);
            Driver.Close();
            Thread.Sleep(3000);
            Driver.SwitchTo().Window(o);
            Thread.Sleep(2000);
            js.ExecuteScript("window scrrolBy(0,200)");
            Driver.FindElement(By.XPath("//a[contains(text(),'Click Here for Broken Link')]")).Click();

            string r = Driver.WindowHandles[1];

            string s = Driver.WindowHandles[0];
            Driver.SwitchTo().Window(r);
            Driver.Manage().Window.Maximize();
            Thread.Sleep(3000);
            Driver.Close();
            Thread.Sleep(3000);
            Driver.SwitchTo().Window(s);
            Thread.Sleep(2000);


            Driver.Close();
            Driver.Quit();
        }
    }
}
