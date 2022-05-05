using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Alerts_FrameAndWindows
{
    internal class Browser_Windows
    {
        public static void Browser_Window()
        {
            IWebDriver Driver = new ChromeDriver();
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            Thread.Sleep(2000);
            Driver.Navigate().GoToUrl("https://demoqa.com/browser-windows");
            Driver.Manage().Window.Maximize();
            new_tab(Driver);
            new_window(Driver);
            new_window_messsage(Driver);

        }
        private static void new_tab(IWebDriver Driver)
        {
            Driver.FindElement(By.Id("tabButton")).Click();
            string c = Driver.WindowHandles[1];
            string p = Driver.WindowHandles[0];
            Driver.SwitchTo().Window(c);
            Thread.Sleep(2000);
            Driver.Close();
            Thread.Sleep(2000);
            Driver.SwitchTo().Window(p);
            Thread.Sleep(2000);
        }
        private static void new_window(IWebDriver Driver)
        {
            Driver.FindElement(By.Id("windowButton")).Click();
            string h = Driver.WindowHandles[1];

            string o = Driver.WindowHandles[0];
            Driver.SwitchTo().Window(h);
            Driver.Manage().Window.Maximize();
            Thread.Sleep(3000);
            Driver.Close();
            Thread.Sleep(3000);
            Driver.SwitchTo().Window(o);
            Thread.Sleep(2000);

        }
        private static void new_window_messsage(IWebDriver Driver)
        {
            Driver.FindElement(By.Id("messageWindowButton")).Click();
            string y = Driver.WindowHandles[1];
            string z = Driver.WindowHandles[0];
            Driver.SwitchTo().Window(y);
            //Driver.Manage().Window.Maximize();
            Thread.Sleep(3000);
            Driver.Close();
            Thread.Sleep(3000);
            Driver.SwitchTo().Window(z);
            Driver.Close();
            Driver.Quit();
        }
    }
}
}
