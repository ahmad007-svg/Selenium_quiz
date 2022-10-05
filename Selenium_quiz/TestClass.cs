using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using System.Threading;

namespace Selenium_quiz
{
    [TestClass]
    public class TestClass
    {
        [TestMethod]
        public void RegisterUser()
        {
            SignupPage obj = new SignupPage();

            string url = "http://automationexercise.com";
            obj.seleniumint("Chrome", url);


            obj.Signup("Ahmad Raza", "ahmad096@gmail.com", "Ahmad123", "Ahmad", "Raza", "RoyalPark", "Lahore Gulberg", "Lahore Gulberg", "Punjab", "Lahore", "54600", "0387897907");



        }
        [TestMethod]
        public void Sign()
        {
            Signin obj = new Signin();

            string url = "http://automationexercise.com";
            obj.seleniumint("Chrome", url);


            obj.SignIn("ahmad1@gmail.com", "Ahmad123");
            ;
        }

        [TestMethod]
        public void log()
        {
            logout obj = new logout();

            string url = "http://automationexercise.com";
            obj.seleniumint("Chrome", url);


            obj.logg("ahmad1@gmail.com", "Ahmad123");

        }

        [TestMethod]
        public void crt()
        {
            AddCart obj6 = new AddCart();

            string url = "http://automationexercise.com";
            obj6.seleniumint("Chrome", url);

            obj6.crty("ahmad1@gmail.com", "Ahmad123");




        }
        [TestMethod]
        public void inovice()

        {
            Invoicee obj = new Invoicee();
            


            string url = "http://automationexercise.com";
            obj.seleniumint("Chrome", url);

            Invoicee obj3 = new Invoicee();
            obj3.Down("ahmad", "ahmad10@gmail.com", "Ahmad123", "usman", "raza", "contoursoftware", "Contour software", "Gulberg 3 lahore", "Pakistan", "punjab", "Lahore", "54000", "03005784142", "ok", "ahmad", "03005784142", "123", "2023");

        }
        [TestMethod]
        public void ExistUser()
        {
            SignupPage obj = new SignupPage();

            string url = "http://automationexercise.com";
            obj.seleniumint("Chrome", url);
            obj.Signup("Ahmad Raza", "ahmad12@gmail.com", "Ahmad123", "Ahmad", "Raza", "RoyalPark", "Lahore Gulberg", "Lahore Gulberg", "Punjab", "Lahore", "54600", "0387897907");
            SignupPage obj4 = new SignupPage();

        }
        [TestMethod]
        public void Scrol()
        {
            ScrollFun obj = new ScrollFun();
            string url = "https://www.automationexercise.com/login";
            obj.seleniumint("Chrome", url);

            ScrollFun obj3 = new ScrollFun();

        }
        [TestMethod]

        public void cartquantity()
        {
            AddCart obj6 = new AddCart();

            string url = "http://automationexercise.com";
            obj6.seleniumint("Chrome", url);

            obj6.crty("ahmad1@gmail.com", "Ahmad123");


        }


    }
}