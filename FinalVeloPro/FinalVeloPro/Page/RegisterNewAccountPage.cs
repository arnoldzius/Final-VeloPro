using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalVeloPro.Page
{
    public class RegisterNewAccountPage : BasePage
    {
        private const string urlPage = "https://www.velopro.lt/register";
        private IWebElement typeTwoOfCustomer => Driver.FindElement(By.Id("customer-2"));
        private IWebElement typeThreeOfCustomer => Driver.FindElement(By.Id("customer-3"));
        private IWebElement firstname => Driver.FindElement(By.Id("firstname"));
        private IWebElement lastname => Driver.FindElement(By.Id("lastname"));
        private IWebElement email => Driver.FindElement(By.Id("email"));
        private IWebElement telephone => Driver.FindElement(By.Id("telephone"));
        private IWebElement deliveryAdress => Driver.FindElement(By.Id("address_1"));
        private IWebElement cityName => Driver.FindElement(By.Id("city"));
        private SelectElement regionDropDown => new SelectElement(Driver.FindElement(By.Id("zone_id")));
        private IWebElement password => Driver.FindElement(By.Id("password"));
        private IWebElement confirmPasword => Driver.FindElement(By.Id("confirm"));
        private IWebElement confirmRulesOfWebpage => Driver.FindElement(By.CssSelector("#profile-page > form > fieldset:nth-child(4) > div.row.buttons-full-width > div.col-sm-8.link-text.text-left > div > label"));
        private IWebElement confirmRegistrationButton => Driver.FindElement(By.CssSelector("#profile-page > form > fieldset:nth-child(4) > div.row.buttons-full-width > div.col-sm-4.text-right > input"));

        public RegisterNewAccountPage(IWebDriver webdriver) : base(webdriver) { }


        public void NavigateToDefaultPage()
        {
            if (Driver.Url != urlPage)
            {
                Driver.Url = urlPage;
            }
        }

        public void Enterinformation()
        {
            typeThreeOfCustomer.Click();
            typeTwoOfCustomer.Click();
            firstname.SendKeys("Testas0007");
            lastname.SendKeys("Testavicius0007");
            email.SendKeys("testavicius0007@testasvimas.com");
            telephone.SendKeys("+3706000000");
            deliveryAdress.SendKeys("Testavimo gatvė");
            cityName.SendKeys("Testuoklis");
            regionDropDown.SelectByValue("4269");
            password.SendKeys("nebeslaptazodis01");
            confirmPasword.SendKeys("nebeslaptazodis01");
            confirmRulesOfWebpage.Click();
        }

        public void ConfirmRegistration()
        {
               confirmRegistrationButton.Click();
        }
    }
}
