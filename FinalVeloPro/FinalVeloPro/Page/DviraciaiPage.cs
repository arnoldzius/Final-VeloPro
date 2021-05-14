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

        private IWebElement selectBicycles => Driver.FindElement(By.CssSelector("#primary-navigation > ul > li.dropdown > a"));
        

        public void NavigateToDefaultPage()
        {
            if (Driver.Url != urlPage)
            {
                Driver.Url = urlPage;
            }
        }

        public DviraciaiPage(IWebDriver webdriver) : base(webdriver) { }
       

        public void SelectBicyclesBar()
        {
            selectBicycles.Click();
        }

  

    }
}