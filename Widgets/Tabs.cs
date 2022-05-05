using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Widgets
{
    internal class Tabs
    {
        public static void Tabs()
        {
            IWebDriver Driver = new ChromeDriver();
            IJavaScriptExecutor js = IJavaScriptExecutor(Driver);
            Thread.Sleep(2000);

            Driver.Navigate().GoToUrl("https://demoqa.com/tabs");
            Driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//a[@id='demo-tab-what']")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//a[@id='demo-tab-origin']")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//a[@id='demo-tab-use']")).Click();
            Thread.Sleep(2000);

            Driver.Close();
            Driver.Quit();

        }
    }
}
