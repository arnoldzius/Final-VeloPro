using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalVeloPro.Page
{
    public class AddToCartPage : BasePage
    {
        private const string urlPage = "https://www.velopro.lt/dviraciai";

        private static IWebElement selectBicycle => Driver.FindElement(By.CssSelector("#product-page > div.product-grid.row > div:nth-child(1) > div > div.image.row > a > img"));
        


        public void NavigateToDefaultPage()
        {
            if (Driver.Url != urlPage)
            {
                Driver.Url = urlPage;
            }
        }

        public AddToCartPage(IWebDriver webdriver) : base(webdriver) { }
       

        public void ClickOnSelectedBicycleButton()
        {
            selectBicycle.Click();
            
        }



    }
}
