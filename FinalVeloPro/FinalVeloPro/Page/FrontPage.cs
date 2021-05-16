using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalVeloPro.Page
{
    public class FrontPage : BasePage
    {
        private const string urlPage = "https://www.velopro.lt/";
        private IWebElement logInLogo => Driver.FindElement(By.CssSelector("#user-profile-cart-block > div > div.user-block.col-md-6"));
        private IWebElement cookies => Driver.FindElement(By.ClassName("cc-compliance"));
        private IWebElement saleButton => Driver.FindElement(By.CssSelector("#primary-navigation > ul > li:nth-child(2) > a"));
        private IWebElement gobackButton => Driver.FindElement(By.CssSelector("#product-page > a"));
        private IWebElement deliveryButton => Driver.FindElement(By.CssSelector("#primary-navigation > ul > li:nth-child(3) > a"));
        private IWebElement aboutUsButton => Driver.FindElement(By.CssSelector("#primary-navigation > ul > li:nth-child(4) > a"));

        public FrontPage(IWebDriver webdriver) : base(webdriver) { }

        public void NavigateToDefaultPage()
        {
            if (Driver.Url != urlPage)
            {
                Driver.Url = urlPage;
            }
        }

        public void TurnOffCookies()
        {
            GetWait().Until(ExpectedConditions.ElementToBeClickable(cookies));
            cookies.Click();
        }
        public void EnterLogInSection()
        {
            logInLogo.Click();
        }
        public void EnterSalesPage()
        {
            saleButton.Click();
            gobackButton.Click();
        }
        public void EnterDeliveryPage()
        {
            deliveryButton.Click();
        }
        public void EnterAboutUsPage()
        {
            aboutUsButton.Click();
        }
        
    }
}
