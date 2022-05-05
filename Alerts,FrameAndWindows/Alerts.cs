using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Alerts_FrameAndWindows
{
    internal class Alerts
    {
        public static void Alert()
        {
            IWebDriver Driver = new ChromeDriver();
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            Thread.Sleep(2000);

            Driver.Navigate().GoToUrl("https://demoqa.com/alerts");
            Thread.Sleep(2000);

            Driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//button[@id='alertButton']")).Click();
            Driver.SwitchTo().Alert().Accept();
            Thread.Sleep(2000);


            Driver.FindElement(By.XPath("//button[@id='timerAlertButton']")).Click();
            Thread.Sleep(5000);
            Driver.SwitchTo().Alert().Accept();
            Thread.Sleep(2000);


            Driver.FindElement(By.XPath("//button[@id='confirmButton']")).Click();
            Driver.SwitchTo().Alert().Accept();
            Thread.Sleep(2000);

            js.ExecuteScript("window.scrollBy(0,500)");
            Thread.Sleep(5000);


            Driver.FindElement(By.XPath("//button[@id='promtButton']")).Click();
            Thread.Sleep(2000);
            Driver.SwitchTo().Alert().SendKeys("pappu");
            Thread.Sleep(2000);
            Driver.SwitchTo().Alert().Accept();

            Thread.Sleep(5000);
            Driver.Close();
            Driver.Quit();

        }
    }
}
