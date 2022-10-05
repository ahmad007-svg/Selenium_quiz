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
    public class SignupPage : GeneralClass

    {



        By signUpBtn = By.XPath("//a[normalize-space()='Signup / Login']");
        By nam = By.XPath("//input[@placeholder='Name']");
        By mail = By.XPath("//input[@data-qa='signup-email']");
        By clickSignUpBtn = By.XPath("//button[normalize-space()='Signup']");


        By mrr = By.XPath("//input[@id='id_gender1']");
        By name1 = By.Id("name");
        By name2 = By.Id("last_name");
        By pass = By.Id("password");
        By dat = By.Id("days");
        By mnth = By.Id("months");
        By yer = By.Id("years");
        By chkb1 = By.XPath("//label[text()='Sign up for our newsletter!']");
        By chkb2 = By.XPath("//label[text()='Receive special offers from our partners!']");
        By fname = By.Id("first_name");
        By lname = By.Id("last_name");
        By comp = By.Id("company");
        By addr = By.Id("address1");
        By addr2 = By.Id("address2");
        By cntry = By.Id("country");
        By stat = By.Id("state");
        By citi = By.Id("city");
        By zipp = By.Id("zipcode");
        By mob = By.Id("mobile_number");
        By btn = By.XPath("//button[text()='Create Account']");
        By ctn = By.XPath("//a[text()='Continue']");
        By log = By.XPath(" //a[text()='Logout']");

        GeneralClass obj1 = new GeneralClass();
        public void Signup(string name, string maill, string passs, string fnamee, string lnamee, string compy, string addrr, string addrr2, string statee, string citii, string zippp, string mobb)
        {

            IWebElement click = driver.FindElement(signUpBtn);

            click.Click();

            findElement(nam).SendKeys(name);
        ;
            findElement(mail).SendKeys(maill);
            findElement(clickSignUpBtn).Click();

            //wait();
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
            //Assert.AreEqual(expt_ret, "Enter Account Information");

            findElement(mrr).Click();
            findElement(pass).SendKeys(passs);
            Dropdown(dat, "2");
            Dropdown(mnth, "1");
            Dropdown(yer, "2010");
            findElement(chkb1).Click();
            findElement(chkb2).Click();
            findElement(fname).SendKeys(fnamee);
            findElement(lname).SendKeys(lnamee);
            findElement(comp).SendKeys(compy);
            findElement(addr).SendKeys(addrr);
            findElement(addr2).SendKeys(addrr2);
            Dropdown(cntry, "India");
            findElement(stat).SendKeys(statee);
            findElement(citi).SendKeys(citii);
            findElement(zipp).SendKeys(zippp);
            findElement(mob).SendKeys(mobb);

            Screenshot image_username = ((ITakesScreenshot)driver).GetScreenshot();
            image_username.SaveAsFile("C:\\Users\razaaahm\\Desktop\assignments\\Selenium_quiz\\Selenium_quiz\bin\\Debug\\filenam0.png", ScreenshotImageFormat.Png);
            findElement(btn).Click();
            //wait();
            //string texte;
            //try
            //{
            //    texte = driver.FindElement(By.XPath("//*[@id='utilities-main']/div[1]/div[2]/div/p[1]/a")).GetAttribute("text");
            //}
            //catch
            //{
            //    try
            //    {
            //        texte = driver.FindElement(By.XPath("//*[@id='utilities-main']/div[1]/div[2]/div/p[1]/a")).GetAttribute("value");
            //    }
            //    catch
            //    {
            //        texte = driver.FindElement(By.XPath("//*[@id='utilities-main']/div[1]/div[2]/div/p[1]/a")).GetAttribute("innerHTML");
            //    }
            //}


            //string expt_rett = texte;
            //Assert.AreEqual(expt_rett, "Account Created!");

            findElement(ctn).Click();

            IWebElement clickk = driver.FindElement(log);

            clickk.Click();









        }






    }




}
