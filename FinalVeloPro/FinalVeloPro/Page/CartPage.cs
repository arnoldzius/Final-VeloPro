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
    public class CartPage : BasePage
    {
        private const string urlPage = "https://www.velopro.lt/index.php?route=checkout/cart";
        private IWebElement buyButton => Driver.FindElement(By.Id("init-checkout"));
        private IWebElement searchField => Driver.FindElement(By.Name("filter_name"));
        private IWebElement searchButton => Driver.FindElement(By.ClassName("button-search"));
        private IWebElement discountCheckBox => Driver.FindElement(By.ClassName("radio"));
        private IWebElement discountCodeField => Driver.FindElement(By.Name("coupon"));
        private IWebElement discountConfirmButton => Driver.FindElement(By.CssSelector("#coupon > form > div > div.col-md-3.col-sm-3"));
        private IWebElement discountMessage => Driver.FindElement(By.CssSelector("#checkout-page > div.alert.alert-danger"));
        private IWebElement removeButton => Driver.FindElement(By.ClassName("minicart-button-remove"));
        private IWebElement emptyBasketMessage => Driver.FindElement(By.CssSelector("#error-page > div.information-content-description.col-md-10.col-md-offset-1.text-center"));
        public CartPage(IWebDriver webdriver) : base(webdriver) { }
        
        
        public void NavigateToDefaultPage()
        {
            if (Driver.Url != urlPage)
            {
                Driver.Url = urlPage;
            }
        }
        public void BuyAction()
        {
            buyButton.Click();
        }
        public void CompleteSearch()
        {
            string text = "262741";
            searchField.SendKeys(text);
            searchButton.Click();
        }
        public void DiscountFieldValidation()
        {
            string expectedMessage = "Nuolaidos kodas nebegalioja arba pasiekė savo panaudojimo ribą!\r\n×";
            discountCheckBox.Click();
            discountCodeField.SendKeys("DiscountCode");
            discountConfirmButton.Click();
            Assert.AreEqual(expectedMessage, discountMessage.Text);
        }
        public void DeleteItemFromBasket()
        {
            string expectedText = "Prekių krepšelis tuščias!\r\nGRĮŽTI";
            removeButton.Click();
            IAlert alertDismiss = Driver.SwitchTo().Alert();
            alertDismiss.Dismiss();
            removeButton.Click();
            IAlert alertAccept = Driver.SwitchTo().Alert();
            alertAccept.Accept();
            Assert.AreEqual(expectedText, emptyBasketMessage.Text);
        }
    }
}
