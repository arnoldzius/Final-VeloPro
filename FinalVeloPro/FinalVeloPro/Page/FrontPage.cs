using OpenQA.Selenium;
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


        public void NavigateToDefaultPage()
        {
            if (Driver.Url != urlPage)
            {
                Driver.Url = urlPage;
            }
        }

        public FrontPage(IWebDriver webdriver) : base(webdriver) { }
        
        public void EnterLogInSection()
        {
            logInLogo.Click();
        }







    }
}
