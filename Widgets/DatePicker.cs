using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Widgets
{
    internal class DatePicker
    {
        public static void Date_Picker()
        {
            IWebDriver Driver = new ChromeDriver();
            IJavaScriptExecutor js = IJavaScriptExecutor(Driver);
            Thread.Sleep(2000);

            Driver.Navigate().GoToUrl("https://demoqa.com/date-picker");
            Driver.Manage().Window.Maximize();
            Actions action = new Actions(Driver);
            IWebElement CalInputBox = Driver.FindElement(By.XPath("//input[@id='datePickerMonthYearInput']"));

            CalInputBox.Click();

            Thread.Sleep(2000);

            js.ExecuteScript("window.scrollBy(0,500)");
            Thread.Sleep(2000);

            action.MoveToElement(Driver.FindElement(By.XPath("//input[@id='datePickerMonthYearInput']")))
             .KeyDown(Keys.Control)
             .SendKeys("a")
             .KeyUp(Keys.Control).Perform();


            CalInputBox.SendKeys("11 Dec 2022");

            Thread.Sleep(2000);

            // time picker



            Driver.Navigate().GoToUrl("https://demoqa.com/date-picker");
            Driver.Manage().Window.Maximize();
            Actions acti = new Actions(Driver);

            IWebElement CalInpu = Driver.FindElement(By.XPath("//input[@id='dateAndTimePickerInput']"));

            CalInpu.Click();

            Thread.Sleep(2000);

            js.ExecuteScript("window.scrollBy(0,300)");
            Thread.Sleep(2000);

            action.MoveToElement(Driver.FindElement(By.XPath("//input[@id='dateAndTimePickerInput']")))
             .KeyDown(Keys.Control)
             .SendKeys("a")
             .KeyUp(Keys.Control).Perform();


            CalInputBox.SendKeys("11 Dec 2022  11:30PM");

            Thread.Sleep(2000);
            Driver.Close();
            Driver.Quit();



        }
    }
}
