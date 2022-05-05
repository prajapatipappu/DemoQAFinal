using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Widgets
{
    internal class SelectMenu
    {
        public static void Select_Menu()
        {
            IWebDriver Driver = new ChromeDriver();
            IJavaScriptExecutor js = IJavaScriptExecutor(Driver);
            Thread.Sleep(2000);
            Driver.Navigate().GoToUrl("https://demoqa.com/menu");
            Driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            Driver.FindElement(By.XPath("//a[contains(text(),'Main Item 1')]")).Click();
            Thread.Sleep(2000);
            Driver.FindElement(By.XPath("//a[contains(text(),'Main Item 2')]")).Click();
            Thread.Sleep(5000);
            Driver.FindElements(By.XPath("//a[contains(text(),'Sub Item')]"))[0].Click();
            Thread.Sleep(5000);
            Driver.FindElements(By.XPath("//a[contains(text(),'Sub Item')]"))[1].Click();
            Thread.Sleep(5000);
            Driver.FindElement(By.XPath("//a[contains(text(),'SUB SUB LIST ')]")).Click();
            Thread.Sleep(5000);
            Driver.FindElement(By.XPath("//a[contains(text(),'Sub Sub Item 1')]")).Click();
            Thread.Sleep(2000);
            Driver.FindElement(By.XPath("//a[contains(text(),'Sub Sub Item 2')]")).Click();
            Thread.Sleep(2000);
            Driver.FindElement(By.XPath("//a[contains(text(),'Main Item 3')]")).Click();
            Thread.Sleep(2000);
            Driver.Close();
            Driver.Quit();
        }
    }
}
