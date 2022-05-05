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
    internal class RadioButton
    {
        public static void Radio_Button()
        {
            IWebDriver Driver = new ChromeDriver();
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            Thread.Sleep(2000);

            Driver.Navigate().GoToUrl("https://demoqa.com/radio-button");
            Driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            Driver.FindElements(By.XPath("//label[contains(@class,'custom-control')]"))[0].Click();//---yes
            Thread.Sleep(2000);
            Driver.FindElements(By.XPath("//label[contains(@class,'custom-control')]"))[1].Click();//---impressive
            Thread.Sleep(2000);
            Driver.FindElements(By.XPath("//label[contains(@class,'custom-control')]"))[2].Click();//--no
            IWebElement button = Driver.FindElement(By.XPath("//label[@for='noRadio']"));
            js.ExecuteScript("arguments[0].click()", button);
            Thread.Sleep(2000);
            Driver.Close();

            Driver.Quit();


        }
    }
}
