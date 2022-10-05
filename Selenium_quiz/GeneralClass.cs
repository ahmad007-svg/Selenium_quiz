using System;
using System.Collections.Generic;
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
    public class GeneralClass
    {
        public static ChromeDriver driver;


        public void seleniumint(string browser, string url)
        {

            if (browser == "Chrome")
            {

                driver = new ChromeDriver();


            }
            else if (browser == "Firefox")
            {

                // driver = new FirefoxDriver();

            }
            else if (browser == "Edge")
            {

                //  driver = new EdgeDriver();

            }
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
        }

        public IWebElement findElement(By locator)
        {
            return driver.FindElement(locator);
        }
        public void type(By locator, String text)
        {
            IWebElement element = findElement(locator);
            //element.Clear();

            element.SendKeys(text);



        }


        public void CheckButton(By path)
        {
            if (!driver.FindElement(path).Selected)
            {
                driver.FindElement(path).Click();
            }
        }


        public void Clickable(By findElement)
        {
            IWebElement element = driver.FindElement(findElement);
            element.Click();

        }

        public void Dropdown(By by, string value)
        {
            IWebElement drpdown = driver.FindElement(by);

            SelectElement Dropdon = new SelectElement(drpdown);

            Dropdon.SelectByValue(value);

        }


        // Dropdown for Search

        public static void wait()
        {

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        public static void CloseDriver()

        {

            driver.Close();

        }
        public void Write(By by, string value)

        {

            driver.FindElement(by).SendKeys(value);

        }
        public void Click(By by)

        {

            driver.FindElement(by).Click();

        }
        public static void scroll()
        {
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollBy(0,500);");
        }
        private bool IsPageReady(IWebDriver driver)
        {
            return ((IJavaScriptExecutor)driver).ExecuteScript("return document.readyState").Equals("complete");
        }

        private bool IsElementVisible(By by)
        {
            if (driver.FindElement(by).Displayed || driver.FindElement(by).Enabled)
            {
                return true;
            }
            else
            { return false; }
        }

        private bool IsClickable(By by)
        {
            try
            {
                return true;
            }
            catch
            {
                return false;
            }
        }

        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
        public IWebElement WaitforElement(By by, int timeToReadyElement = 0)
        {
            IWebElement element = null;
            try
            {
                if (timeToReadyElement != 0 && timeToReadyElement.ToString() != null)
                {
                    PlaybackWait(timeToReadyElement * 1000);
                }
                element = driver.FindElement(by);
            }
            catch
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
                wait.Until(driver => IsPageReady(driver) == true && IsElementVisible(by) == true && IsClickable(by) == true);
                element = driver.FindElement(by);
            }
            return element;
        }


        public static void PlaybackWait(int miliSeconds)
        {
            Thread.Sleep(miliSeconds);
        }
        public static void Assertt(By by)
        {
            IWebElement element = driver.FindElement(by);
            bool status = element.Displayed;
            Assert.AreEqual(status, true);
        }
    }
}