using NUnit.Framework;
using OpenQA.Selenium;
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
        private IWebElement priceOfBicycle => Driver.FindElement(By.Id("price-update"));
        private IWebElement cartLogo => Driver.FindElement(By.CssSelector("#user-profile-cart-block > div > div.cart-desktop.col-md-6 > div.cart-header > a"));
        private IWebElement addToCartButton => Driver.FindElement(By.Id("button-cart"));
        //private IWebElement cartPrice => Driver.FindElement(By.CssSelector("#header-minicart-1 > div > table > tbody > tr:nth-child(3) > td.col-md-4.col-sm-5.cart-price.cart-total-text.text-right.vcenter.last"));

        private IWebElement enterCart => Driver.FindElement(By.ClassName("minicart-buttons"));
        
        
        




        public void NavigateToDefaultPage()
        {
            if (Driver.Url != urlPage)
            {
                Driver.Url = urlPage;
            }
        }

        public SelectedBicyclePage(IWebDriver webdriver) : base(webdriver) { }

        public void MinusAndPlusButton()
        {
            plusButton.Click();
            plusButton.Click();
            minusButton.Click();
            
    
        }
        public void CartButtons()
        {
            addToCartButton.Click();
            cartLogo.Click();
            
            enterCart.Click();



        }

           

        




    }
}
