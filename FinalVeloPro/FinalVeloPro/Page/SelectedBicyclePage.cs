using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FinalVeloPro.Page
{
    public class SelectedBicyclePage : BasePage
    {
        private const string urlPage = "https://www.velopro.lt/dviraciai/26-xgsr-mtb-black-yellow-classic-3230-1";
        private IWebElement minusButton => Driver.FindElement(By.CssSelector("#product-right > div.product-cart > div:nth-child(1) > div.col-xs-6.quantity > div > span:nth-child(1)"));
        private IWebElement plusButton => Driver.FindElement(By.CssSelector("#product-right > div.product-cart > div:nth-child(1) > div.col-xs-6.quantity > div > span:nth-child(4)"));
        private IWebElement cartLogo => Driver.FindElement(By.CssSelector("#user-profile-cart-block > div > div.cart-desktop.col-md-6 > div.cart-header > a"));
        private IWebElement addToCartButton => Driver.FindElement(By.Id("button-cart"));
        private IWebElement quantityOfSelection => Driver.FindElement(By.Name("quantity"));
        private IWebElement priceOfTwo => Driver.FindElement(By.CssSelector("#price-update"));
        private IWebElement enterCart => Driver.FindElement(By.ClassName("minicart-buttons"));
        public SelectedBicyclePage(IWebDriver webdriver) : base(webdriver) { }


        public void NavigateToDefaultPage()
        {
            if (Driver.Url != urlPage)
            {
                Driver.Url = urlPage;
            }
        }

        public void MinusAndPlusButton()
        {
            plusButton.Click();
            plusButton.Click();
            minusButton.Click();
        }
        public void AddToCartButton()
        {
            addToCartButton.Click();
        }
        public void ValidateQuantity()
        {
            string expectedValue = "2";
            Assert.IsTrue(expectedValue.Contains(quantityOfSelection.Text));
        }
        public void ValidatePriceForTwo()
        {
            string expectedPriceOfTwo = "€419.99";
            GetWait().Until(ExpectedConditions.TextToBePresentInElement(priceOfTwo, expectedPriceOfTwo));
            Assert.AreEqual(expectedPriceOfTwo, priceOfTwo.Text);
        }
        public void EnterToCart()
        {
            cartLogo.Click();
            GetWait().Until(ExpectedConditions.ElementToBeClickable(enterCart));
            enterCart.Click();
        }
    }
}
