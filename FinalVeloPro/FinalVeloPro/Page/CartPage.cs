using OpenQA.Selenium;
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
        private IWebElement goToCart => Driver.FindElement(By.CssSelector("#header-minicart-1 > div > div.minicart-buttons > a"));









        public void NavigateToDefaultPage()
        {
            if (Driver.Url != urlPage)
            {
                Driver.Url = urlPage;
            }
        }




        public CartPage(IWebDriver webdriver) : base(webdriver) { }

       



    }
}
