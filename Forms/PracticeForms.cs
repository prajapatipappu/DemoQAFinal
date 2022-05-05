using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Forms
{
    internal class PracticeForms
    {
        public static void Practice_Form()
        {

            IWebDriver Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl("https://demoqa.com/automation-practice-form");

            Driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            practice(Driver);

        }
        public static void practice(IWebDriver Driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;

            Driver.FindElement(By.Id("firstName")).SendKeys("Pappu");
            Thread.Sleep(2000);
            Driver.FindElement(By.Id("lastName")).SendKeys("Kumar");
            Thread.Sleep(2000);
            Driver.FindElement(By.Id("userEmail")).SendKeys("pappukumarbcet2019@gmail.com");
            Thread.Sleep(2000);
            Driver.FindElements(By.XPath("//div[contains(@class,'custom-control')]"))[0].Click();
            Thread.Sleep(2000);
            Driver.FindElement(By.Id("userNumber")).SendKeys("8507708583");
            Thread.Sleep(2000);
            Actions action = new Actions(Driver);
            IWebElement CalInputBox = Driver.FindElement(By.XPath("//input[@id='dateOfBirthInput']"));
            js.ExecuteScript("window.scrollBy(0,500)");
            Thread.Sleep(3000);

            CalInputBox.Click();
            Thread.Sleep(2000);

            action.MoveToElement(Driver.FindElement(By.XPath("//input[@id='dateOfBirthInput']")))
            .KeyDown(Keys.Control)
            .SendKeys("a")
            .KeyUp(Keys.Control)
            .Perform();

            CalInputBox.SendKeys("11 Jan 2000");

            Thread.Sleep(3000);



            //Driver.FindElement(By.Id("subjectsContainer")).SendKeys("Computer");

            //Driver.FindElement(By.XPath("//label[@for='hobbies-checkbox-2']")).Click();
            //Thread.Sleep(2000);
            //js.ExecuteScript("window.scrollBy(0,500)");
            //Thread.Sleep(2000);

            Driver.FindElement(By.Id("uploadPicture")).SendKeys(@"D:\incrideble india pic\IMG_20181215_192745.jpg");

            Driver.Close();
            Driver.Quit();
        }
    }
}
