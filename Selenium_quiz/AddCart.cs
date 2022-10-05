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
    public class AddCart:GeneralClass
    {

        By signUpBtn = By.XPath("//a[normalize-space()='Signup / Login']");
        By email1 = By.XPath("//input[@data-qa='login-email']");
        By password1 = By.XPath("//input[@data-qa='login-password']");
        By logbtn = By.XPath("//button[text()='Login']");

        By add1 = By.XPath("(//i[@class='fa fa-plus-square'])[1]");
        By add2 = By.XPath("//button[@class='btn btn-default cart']");
        By view = By.XPath("//u[text()='View Cart']");
        By checkout = By.XPath("//a[text()='Proceed To Checkout']");

        GeneralClass obj5 = new GeneralClass();

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

            findElement(checkout).Click();



        }
    }

}