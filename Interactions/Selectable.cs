using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interactions
{
    internal class Selectable
    {
        public static void Selecttables()
        {

            IWebDriver Driver = new ChromeDriver();
            IJavaScriptExecutor js = IJavaScriptExecutor(Driver);

            Driver.Navigate().GoToUrl("https://demoqa.com/selectable");
            Driver.Manage().Window.Maximize();
            //Thread.Sleep(2000);
            Driver.FindElement(By.XPath("//li[contains(text(),'Cras justo odio')]")).Click();

            Driver.FindElement(By.XPath("//li[contains(text(),'Dapibus ac facilisis in')]")).Click();
            Driver.FindElement(By.XPath("//li[contains(text(),'Morbi leo risus')]")).Click();
            Driver.FindElement(By.XPath("//li[contains(text(),'Porta ac consectetur ac')]")).Click();




            // Grid

            Driver.FindElement(By.XPath("//a[@id='demo-tab-grid']")).Click();

            Driver.FindElement(By.XPath("//li[contains(text(),'One')]")).Click();

            Driver.FindElement(By.XPath("//li[contains(text(),'Two')]")).Click();

            Driver.FindElement(By.XPath("//li[contains(text(),'Three')]")).Click();

            Driver.FindElement(By.XPath("//li[contains(text(),'Four')]")).Click();

            Driver.FindElement(By.XPath("//li[contains(text(),'Five')]")).Click();

            Driver.FindElement(By.XPath("//li[contains(text(),'Six')]")).Click();




            Driver.FindElement(By.XPath("//li[contains(text(),'Seven')]")).Click();

            Driver.FindElement(By.XPath("//li[contains(text(),'Eight')]")).Click();

            Driver.FindElement(By.XPath("//li[contains(text(),'Nine')]")).Click();
            Thread.Sleep(2000);

            Driver.Close();
            Driver.Quit();

        }
    }
}
