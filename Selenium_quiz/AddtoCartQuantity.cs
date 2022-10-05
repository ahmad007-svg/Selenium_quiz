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
    public class AddtoCartQuantity :GeneralClass
    {
        By signUpBtn = By.XPath("//a[normalize-space()='Signup / Login']");
        By email1 = By.XPath("//input[@data-qa='login-email']");
        By password1 = By.XPath("//input[@data-qa='login-password']");
        By logbtn = By.XPath("//button[text()='Login']");

        By add1 = By.XPath("(//i[@class='fa fa-plus-square'])[1]");
        By add2 = By.XPath("//button[@class='btn btn-default cart']");
        By view = By.XPath("//u[text()='View Cart']");
        By quant = By.CssSelector("body > section > div > div > div.col-sm-9.padding-right > div.product-details > div.col-sm-7 > div > span > label");
        By checkout = By.XPath("//a[text()='Proceed To Checkout']");

        GeneralClass obj7 = new GeneralClass();

        public void crty(string maile, string pwd)
        {


            IWebElement click = driver.FindElement(signUpBtn);

            click.Click();

            findElement(email1).SendKeys(maile);
            findElement(password1).SendKeys(pwd);
            findElement(logbtn).Click();
            wait();
            scroll();
            findElement(add1).Click();
            wait();

            findElement(add2).Click();

            wait();

            IWebElement clk = driver.FindElement(view);

            clk.Click();

            findElement(quant).Click();

            Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            screenshot.SaveAsFile(@".\\Screenshot4.png", ScreenshotImageFormat.Png);


            WaitforElement(checkout);

            findElement(checkout).Click();
           



        }

    }

}

