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
    public class logout :GeneralClass
    {

        By signUpBtn = By.XPath("//a[normalize-space()='Signup / Login']");

        By usermail = By.Name("email");
        By passwdd = By.Name("password");
        By loginbtn = By.XPath("//button[text()='Login']");

        By LogoutButton = By.XPath("//i[@class='fa fa-lock']");






        GeneralClass obj4 = new GeneralClass();
        public void logg(string usermaill, string passwd)


        {


            //string text;
            //try
            //{
            //    text = driver.FindElement(By.XPath("//*[@id='utilities-main']/div[1]/div[2]/div/p[1]/a")).GetAttribute("text");
            //}
            //catch
            //{
            //    try
            //    {
            //        text = driver.FindElement(By.XPath("//*[@id='utilities-main']/div[1]/div[2]/div/p[1]/a")).GetAttribute("value");
            //    }
            //    catch
            //    {
            //        text = driver.FindElement(By.XPath("//*[@id='utilities-main']/div[1]/div[2]/div/p[1]/a")).GetAttribute("innerHTML");
            //    }
            //}


            //string expt_ret = text;
            //Assert.AreEqual(expt_ret, "Login to your account");

            IWebElement clic = driver.FindElement(signUpBtn);

            clic.Click();
            findElement(usermail).SendKeys(usermaill);
            findElement(passwdd).SendKeys(passwd);
            findElement(loginbtn).Click();
            wait();
            findElement(LogoutButton).Click();
            wait();
            //string textt;
            //try
            //{
            //    textt = driver.FindElement(By.XPath("//*[@id='utilities-main']/div[1]/div[2]/div/p[1]/a")).GetAttribute("text");
            //}
            //catch
            //{
            //    try
            //    {
            //        textt = driver.FindElement(By.XPath("//*[@id='utilities-main']/div[1]/div[2]/div/p[1]/a")).GetAttribute("value");
            //    }
            //    catch
            //    {
            //        textt = driver.FindElement(By.XPath("//*[@id='utilities-main']/div[1]/div[2]/div/p[1]/a")).GetAttribute("innerHTML");
            //    }
            //}


            //string expt_rett = text;
            //Assert.AreEqual(expt_rett, "OR");

            IWebElement clickk = driver.FindElement(signUpBtn);
            clickk.Click();
        }


    }
}
