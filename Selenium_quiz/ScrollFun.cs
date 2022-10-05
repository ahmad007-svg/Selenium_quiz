using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using System.Threading;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Selenium_quiz
{
    public class ScrollFun :GeneralClass
    {

        GeneralClass obj7= new GeneralClass();


        public void Scrolll()
        {
            string tex;
            try
            {
                tex = driver.FindElement(By.XPath("//*[@id='utilities-main']/div[1]/div[2]/div/p[1]/a")).GetAttribute("text");
            }
            catch
            {
                try
                {
                    tex = driver.FindElement(By.XPath("//*[@id='utilities-main']/div[1]/div[2]/div/p[1]/a")).GetAttribute("value");
                }
                catch
                {
                    tex = driver.FindElement(By.XPath("//*[@id='utilities-main']/div[1]/div[2]/div/p[1]/a")).GetAttribute("innerHTML");
                }
            }


            Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            screenshot.SaveAsFile(@".\\Screenshot4.png", ScreenshotImageFormat.Png);

        }


    }
}
