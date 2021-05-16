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
    public class DviraciaiPage : BasePage
    {
        private const string urlPage = "https://www.velopro.lt/account";
        private IWebElement userNameButton => Driver.FindElement(By.CssSelector("#user-profile-cart-block > div > div.user-block.col-md-6 > a"));
        private IReadOnlyList<IWebElement> dviraciuTipai => Driver.FindElements(By.ClassName("dropdown"));
        public DviraciaiPage(IWebDriver webdriver) : base(webdriver) { }
       

        public void NavigateToDefaultPage()
        {
            if (Driver.Url != urlPage)
            {
                Driver.Url = urlPage;
            }
        }
        public void SelectBicycleTypeFromList()
        {
            dviraciuTipai.First().Click();
        }
       public void ValidateUserLogoName()
       {
            string text = "Vincas";
            Assert.IsTrue(text.Contains(userNameButton.Text));
       }
    }
}