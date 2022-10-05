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
    public class Invoicee :GeneralClass
    {
           
        By AddtoCart = By.XPath("(//a[@class='btn btn-default add-to-cart'])[1]");
        By Continue = By.XPath("//button[@data-dismiss='modal']");
        By Cart1 = By.XPath("(//i[@class='fa fa-shopping-cart']) [1]");
        By Proceed = By.XPath("//a[text()='Proceed To Checkout']");
        By RegLoginButton = By.XPath("//u[text()='Register / Login']");
        By NameInput = By.XPath("//input[@name='name']");
        By EmailInput = By.XPath("(//input[@name='email'])[2]");
        By SignUpBClICk = By.XPath("(//button[@class='btn btn-default'])[2]");
        By MrClICk = By.Id("id_gender1");
        By PassInput = By.Id("password");
        By Datee = By.Id("days");
        By SelectDate = By.XPath("(//option[@value='2'])[1]");
        By Monthh = By.Id("months");
        By MonthInput = By.XPath("(//option[@value='2'])[2]");
        By Years = By.Id("years");
        By YearInput = By.XPath("//option[text()='2006']");
        By NewsLetter = By.Id("newsletter");
        By NewsLetter2 = By.Id("optin");
        By FirstName = By.Id("first_name");
        By LastName = By.Id("last_name");
        By CompanyInput = By.Id("company");
        By Addres1 = By.Id("address1");
        By Addres2 = By.Id("address2");
        By Country = By.Id("country");
        By CountryInput = By.XPath("//option[@value='Canada']");
        By StateInput = By.Id("state");
        By CityInput = By.Id("city");
        By ZipCode = By.Id("zipcode");
        By MobileNO = By.Id("mobile_number");
        By SubmitButton = By.XPath("(//button[@class='btn btn-default'])[1]");
        By ContinueClick = By.XPath("//a[@class='btn btn-primary']");
        By Coment = By.XPath("//textarea[@class='form-control']");
        By PlaceorderClick = By.XPath("//a[@class='btn btn-default check_out']");
        By NameOnCard = By.XPath("//input[@class='form-control']");
        By CardNO = By.XPath("//input[@class='form-control card-number']");
        By CVC = By.XPath("//input[@class='form-control card-cvc']");
        By EXP = By.XPath("//input[@class='form-control card-expiry-month']");
        By YEAR11 = By.XPath("//input[@class='form-control card-expiry-year']");
        By PayAndConfirm = By.XPath("//button[@class='form-control btn btn-primary submit-button']");
        By DownloadInvoice = By.XPath("//a[@class='btn btn-default check_out']");
        By DownloadCont = By.XPath("//a[@class='btn btn-primary']");


        //GeneralClass obj3 = new GeneralClass();
        public void Down(string name, string email, string pass, string fname, string lname, string comp, string add1, string add2, string statee, string cityy, string zipcode, string mobileno, string coment, string cname1, string cardnoo, string cvc, string exp, string yearr)
        {

            Click(AddtoCart);
            Thread.Sleep(3000);
            Click(Continue);
            Click(Cart1);
            Click(Proceed);
            Click(RegLoginButton);
            Write(NameInput, name);
            Write(EmailInput, email);
            Click(SignUpBClICk);
            Click(MrClICk);
            Write(PassInput, pass);
            Click(Datee);
            Click(SelectDate);
            Click(Monthh);
            Click(MonthInput);
            Click(Years);
            Click(YearInput);
            Click(NewsLetter);
            Click(NewsLetter2);
            Write(FirstName, fname);
            Write(LastName, lname);
            Write(CompanyInput, comp);
            Write(Addres1, add1);
            Write(Addres2, add2);
            Click(Country);
            Click(CountryInput);
            Write(StateInput, statee);
            Write(CityInput, cityy);
            Write(ZipCode, zipcode);
            Write(MobileNO, mobileno);
            Click(SubmitButton);
            Click(ContinueClick);
            Click(Cart1);
            Click(Proceed);
            Write(Coment, coment);
            Click(PlaceorderClick);
            Write(NameOnCard, cname1);
            Write(CardNO, cardnoo);
            Write(CVC, cvc);
            Write(EXP, exp);
            Write(YEAR11, yearr);
            Click(PayAndConfirm);
            Click(DownloadInvoice);
            Click(DownloadCont);

        }
    }
}


    
