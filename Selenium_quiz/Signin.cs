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
    public class Signin :GeneralClass

    {
        By usermail=By.Name("email");
        By passwd=By.Name("password");
        By loginbtn = By.XPath("//button[text()='Login']");


        GeneralClass obj2 = new GeneralClass();

        public void SignIn(string maile,string pwd)
        {
            findElement(usermail).SendKeys(maile);
            findElement(passwd).SendKeys(pwd);
            findElement(loginbtn).Click();
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


            string expt_rett = tex;
            Assert.AreEqual(expt_rett, "Ahmad Raza");


        }

    }
}
