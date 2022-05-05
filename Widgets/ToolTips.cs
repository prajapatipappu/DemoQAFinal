using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Widgets
{
    internal class ToolTips
    {
        public static void Tool_Tips()
        {
            IWebDriver Driver = new ChromeDriver();
            IJavaScriptExecutor js = IJavaScriptExecutor(Driver);
            Thread.Sleep(2000);

            Driver.Navigate().GoToUrl("https://demoqa.com/tool-tips");
            Driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            js.ExecuteScript("window.scrollBy(0,500)");
            Thread.Sleep(5000);

            Driver.FindElement(By.XPath("//button[@id='toolTipButton']")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//input[@id='toolTipTextField']")).Click();
            Thread.Sleep(2000);

            Driver.Close();
            Driver.Quit();


        }
    }
}
