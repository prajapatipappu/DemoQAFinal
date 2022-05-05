using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Alerts_FrameAndWindows
{
    internal class ModalDialogs
    {
        public static void modal()
        {
            IWebDriver Driver = new ChromeDriver();
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            Thread.Sleep(2000);

            Driver.Navigate().GoToUrl("https://demoqa.com/modal-dialogs");
            Thread.Sleep(2000);

            Driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//button[@id='showSmallModal']")).Click();
            Thread.Sleep(2000);
            Driver.FindElement(By.XPath("//button[@class='close']")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//button[@id='showLargeModal']")).Click();
            Driver.FindElement(By.XPath("//button[@id='closeLargeModal']")).Click();
            // Driver.SwitchTo().Alert().Dismiss();

            Thread.Sleep(5000);
            Driver.Close();
            Driver.Quit();

        }
    }
}
