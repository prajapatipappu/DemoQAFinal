using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Widgets
{
    internal class ProgressBar
    {
        public static void Progress_Bar()
        {
            IWebDriver Driver = new ChromeDriver();
            IJavaScriptExecutor js = IJavaScriptExecutor(Driver);
            Thread.Sleep(2000);

            Driver.Navigate().GoToUrl("https://demoqa.com/progress-bar");
            Driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//button[@id='startStopButton']")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//button[@id='resetButton']")).Click();
            Thread.Sleep(2000);

            Driver.Close();
            Driver.Quit();

        }
    }
}
