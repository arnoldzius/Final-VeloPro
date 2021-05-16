using FinalVeloPro.Page;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalVeloPro.Test
{
    public class LogInTest : BaseTest
    {
        [Test]
        public static void T01Connection()
        {
            frontPage.NavigateToDefaultPage();
            frontPage.TurnOffCookies();
            frontPage.EnterSalesPage();
            frontPage.EnterDeliveryPage();
            frontPage.EnterAboutUsPage();
            frontPage.EnterLogInSection();
            logInPage.NavigateToDefaultPage();
            logInPage.Connect();
            dviraciaiPage.ValidateUserLogoName();
            dviraciaiPage.SelectBicycleTypeFromList();
        }
        [Test]
        public static void T02SelectFavoriteBicycle()
        {
            addToCartPage.NavigateToDefaultPage();
            addToCartPage.ClickOnSelectedBicycleButton();
        }

        [Test]
        public static void T03GoToCart()
        {
            selectedBicyclePage.NavigateToDefaultPage();
            selectedBicyclePage.MinusAndPlusButton();
            selectedBicyclePage.ValidateQuantity();
            selectedBicyclePage.AddToCartButton();
            selectedBicyclePage.ValidatePriceForTwo();
            selectedBicyclePage.EnterToCart();
            cartPage.DiscountFieldValidation();
            cartPage.BuyAction();
            cartPage.NavigateToDefaultPage();
            cartPage.CompleteSearch();
        }

        [Test]
        public static void T04Disconnect()
        {
            afterSearchPage.NavigateToDefaultPage();
            afterSearchPage.LogoTest();
            frontPage.EnterLogInSection();
            afterSearchPage.LogOff();
            afterSearchPage.LogOffValidation();
            afterSearchPage.GoToMainPage();
        }

        [Test]
        public static void T05RegisterAndValidateNewAccount()
        {
            logInPage.NavigateToDefaultPage();
            logInPage.NewAccRegisterButton();
            registerNewAccountPage.Enterinformation();
            registerNewAccountPage.ConfirmRegistration();
            sucessfullNewRegistration.ValidateStatusOfRegistation();
            sucessfullNewRegistration.GoWriteEmailForAdmin();
        }

       [Test]
       public static void T06SendEmailForAdmin()
       {
            writeEmailForAdmin.NavigateToDefaultPage();
            writeEmailForAdmin.EnterMessage();
            writeEmailForAdmin.SendEmail();
            writeEmailForAdmin.ValidateStatus();
       }
    }
}
