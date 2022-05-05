using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Widgets
{
    internal class Accordian
    {
        public static void Accordians()
        {
            IWebDriver Driver = new ChromeDriver();
            IJavaScriptExecutor js = IJavaScriptExecutor(Driver);
            Thread.Sleep(2000);

            Driver.Navigate().GoToUrl("https://demoqa.com/accordian");
            Thread.Sleep(2000);

            Driver.Manage().Window.Maximize();
            Thread.Sleep(2000);


            Driver.FindElement(By.XPath("//div[@id='section1Heading']")).Click();
            Thread.Sleep(2000);

            js.ExecuteScript("window.scrollBy(0,500)");
            Thread.Sleep(5000);


            Driver.FindElement(By.XPath("//div[@id='section2Heading']")).Click();
            Thread.Sleep(2000);


            Driver.FindElement(By.XPath("//div[@id='section3Heading']")).Click();
            Thread.Sleep(5000);

            Driver.Close();
            Driver.Quit();
        }
    }
}
