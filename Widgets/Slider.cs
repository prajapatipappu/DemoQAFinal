using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Widgets
{
    internal class Slider
    {
        public static void Sliders()
        {
            IWebDriver Driver = new ChromeDriver();
            IJavaScriptExecutor js = IJavaScriptExecuto(Driver);
            Thread.Sleep(2000);

            Driver.Navigate().GoToUrl("https://demoqa.com/slider");
            Driver.Manage().Window.Maximize();
            Thread.Sleep(2000);


            Driver.FindElement(By.XPath("//input[@class='range-slider range-slider--primary']")).Click();
            int xOffset = 90;
            int yOffset = 0;

            Actions action = new Actions(Driver);
            action.MoveByOffset(xOffset, yOffset).Build().Perform();

            Thread.Sleep(5000);
            Driver.Close();
            Driver.Quit();

        }
    }
}
