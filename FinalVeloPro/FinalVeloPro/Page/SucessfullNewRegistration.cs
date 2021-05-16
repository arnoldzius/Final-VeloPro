using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalVeloPro.Page
{
    public class SucessfullNewRegistration : BasePage
    {
        private const string urlPage = "https://www.velopro.lt/index.php?route=account/success";
        private IWebElement newAccountSuccesMessage => Driver.FindElement(By.ClassName("page-title"));
        private IWebElement sendEmailToAdmin => Driver.FindElement(By.ClassName("footer-list-item-8"));
        public SucessfullNewRegistration(IWebDriver webdriver) : base(webdriver) { }


        public void NavigateToDefaultPage()
        {
            if (Driver.Url != urlPage)
            {
                Driver.Url = urlPage;
            }
        }
        public void ValidateStatusOfRegistation()
        {
            string expectedText = "JŪSŲ PASKYRA SUKURTA!";
            Assert.AreEqual(expectedText, newAccountSuccesMessage.Text, "Values of text are different!");
        }
        public void GoWriteEmailForAdmin()
        {
            sendEmailToAdmin.Click();
        }
    }
}
