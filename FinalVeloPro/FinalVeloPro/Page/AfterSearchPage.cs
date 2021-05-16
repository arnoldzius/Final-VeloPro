using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalVeloPro.Page
{
    public class AfterSearchPage : BasePage
    {
        private const string urlPage = "https://www.velopro.lt/index.php?route=product/search&filter_name=262741";
        private IWebElement veloProLogo => Driver.FindElement(By.CssSelector("#header > div > div:nth-child(1) > div.col-md-3.col-md-offset-0.col-sm-5.col-xs-5.col-sm-offset-3.col-xs-offset-3.logo > a"));
        private IReadOnlyList<IWebElement> logOffList => Driver.FindElements(By.ClassName("profile-ul"));
        private IWebElement logOffConfirmation => Driver.FindElement(By.ClassName("page-title"));
        private IWebElement goBackButton => Driver.FindElement(By.CssSelector("#information-page > div.row.buttons-full-width > div > a"));
        public AfterSearchPage(IWebDriver webdriver) : base(webdriver) { }


        public void NavigateToDefaultPage()
        {
            if (Driver.Url != urlPage)
            {
                Driver.Url = urlPage;
            }
        }
        public void LogoTest()
        {
            veloProLogo.Click();
        }
        public void LogOff()
        {
            logOffList.Last().Click();
        }
        public void LogOffValidation()
        {
            string expectedText = "ATSIJUNGĖTE NUO SAVO PASKYROS";
            Assert.AreEqual(expectedText, logOffConfirmation.Text);
        }
        public void GoToMainPage()
        {
            goBackButton.Click();
        }
    }
}
