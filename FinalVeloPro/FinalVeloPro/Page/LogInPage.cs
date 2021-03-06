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
    public class LogInPage : BasePage
    {
        private const string urlPage = "https://www.velopro.lt/login";
        private IWebElement emailField => Driver.FindElement(By.Name("email"));
        private IWebElement passwordField => Driver.FindElement(By.Name("password"));   
        private IWebElement connectButton => Driver.FindElement(By.CssSelector("#login-content > div.col-md-12.block-content > form > div.row.buttons > div.col-md-6.col-md-push-6.col-sm-12.col-sm-push-0.text-right > input"));
        private IWebElement updateInfo => Driver.FindElement(By.CssSelector("#profile-page > form > div.row.buttons-full-width > div > input"));
        private IWebElement updatedInfoConfirmation => Driver.FindElement(By.CssSelector("#profile-page > div.alert.alert-success"));
        private IWebElement registerNewAccButton => Driver.FindElement(By.CssSelector("#new-user > div.col-md-12.block-content.black > div > div > a"));
        public LogInPage(IWebDriver webdriver) : base(webdriver) { }


        public void NavigateToDefaultPage()
        {
            if (Driver.Url != urlPage)
            {
                Driver.Url = urlPage;
            }
        }
        public void Connect()
        {
            string mail = "vincas88@yahoo.com";
            string password = "slaptazodis88";
            string expectedText = "Paskyros informacija sėkmingai atnaujinta!\r\n×";

            emailField.SendKeys(mail);
            passwordField.SendKeys(password);
            connectButton.Click();
            updateInfo.Click();
            Assert.AreEqual(expectedText, updatedInfoConfirmation.Text);
        }
        public void NewAccRegisterButton()
        {
            registerNewAccButton.Click();
        }
    }
}