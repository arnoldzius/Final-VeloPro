using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalVeloPro.Page
{
    public class WriteEmailForAdmin : BasePage
    {
        private const string urlPage = "https://www.velopro.lt/contact";
        private IWebElement messegaField => Driver.FindElement(By.Id("enquiry"));
        private IWebElement sendButton => Driver.FindElement(By.Name("send"));
        private IWebElement captchaTextError => Driver.FindElement(By.ClassName("text-danger"));
        public WriteEmailForAdmin(IWebDriver webdriver) : base(webdriver) { }
        
        public void NavigateToDefaultPage()
        {
            if (Driver.Url != urlPage)
            {
                Driver.Url = urlPage;
            }
        }

        public void SendEmail()
        {
              sendButton.Click();
        }
        public void ValidateStatus()
        {
            string expectedText = "";
            Assert.IsTrue(expectedText.Contains(captchaTextError.Text));
        }
    }
}
