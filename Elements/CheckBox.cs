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
    internal class CheckBox
    {
        public static void Check_Box()
        {
            IWebDriver Driver = new ChromeDriver();
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            Thread.Sleep(2000);
            Driver.Navigate().GoToUrl("https://demoqa.com/checkbox");
            Driver.Manage().Window.Maximize();

            Thread.Sleep(2000);
            Driver.FindElements(By.XPath("//button[@class='rct-collapse rct-collapse-btn']"))[0].Click();
            Thread.Sleep(2000);
            Driver.FindElements(By.XPath("//button[@class='rct-collapse rct-collapse-btn']"))[1].Click();
            Thread.Sleep(2000);
            Driver.FindElements(By.XPath("//button[@class='rct-collapse rct-collapse-btn']"))[2].Click();
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollBy(0,200)");
            Thread.Sleep(2000);
            Driver.FindElements(By.XPath("//button[@class='rct-collapse rct-collapse-btn']"))[5].Click();
            Thread.Sleep(2000);
            Driver.FindElements(By.XPath("//button[@class='rct-collapse rct-collapse-btn']"))[3].Click();
            Thread.Sleep(2000);
            Driver.FindElements(By.XPath("//button[@class='rct-collapse rct-collapse-btn']"))[4].Click();
            Thread.Sleep(2000);
            Driver.FindElements(By.XPath("//span[@class='rct-checkbox']"))[2].Click();
            Thread.Sleep(2000);
            Driver.FindElements(By.XPath("//span[@class='rct-checkbox']"))[3].Click();
            Thread.Sleep(2000);
            Driver.FindElements(By.XPath("//span[@class='rct-checkbox']"))[6].Click();
            Thread.Sleep(2000);
            Driver.FindElements(By.XPath("//span[@class='rct-checkbox']"))[7].Click();
            Thread.Sleep(2000);
            Driver.FindElements(By.XPath("//span[@class='rct-checkbox']"))[8].Click();
            Thread.Sleep(2000);
            Driver.FindElements(By.XPath("//span[@class='rct-checkbox']"))[10].Click();
            Driver.FindElements(By.XPath("//span[@class='rct-checkbox']"))[11].Click();
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollBy(0,200)");
            Thread.Sleep(2000);
            Driver.FindElements(By.XPath("//span[@class='rct-checkbox']"))[12].Click();
            Thread.Sleep(2000);
            Driver.FindElements(By.XPath("//span[@class='rct-checkbox']"))[13].Click();
            Thread.Sleep(2000);
            Thread.Sleep(2000);
            Driver.FindElements(By.XPath("//span[@class='rct-checkbox']"))[15].Click();
            Thread.Sleep(2000);
            Driver.FindElements(By.XPath("//span[@class='rct-checkbox']"))[16].Click();
            Thread.Sleep(2000);
            Driver.FindElements(By.XPath("//button[@class='rct-collapse rct-collapse-btn']"))[4].Click();
            Thread.Sleep(2000);
            Driver.FindElements(By.XPath("//button[@class='rct-collapse rct-collapse-btn']"))[3].Click();
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollBy(0,-200)");
            Thread.Sleep(2000);
            Driver.FindElements(By.XPath("//button[@class='rct-collapse rct-collapse-btn']"))[5].Click();
            Thread.Sleep(2000);
            Driver.FindElements(By.XPath("//button[@class='rct-collapse rct-collapse-btn']"))[2].Click();
            Thread.Sleep(2000);
            Driver.FindElements(By.XPath("//button[@class='rct-collapse rct-collapse-btn']"))[1].Click();
            Thread.Sleep(2000);
            Driver.FindElements(By.XPath("//button[@class='rct-collapse rct-collapse-btn']"))[0].Click();
            Thread.Sleep(2000);
            Driver.Close();

            Driver.Quit();
        }
    }
}
