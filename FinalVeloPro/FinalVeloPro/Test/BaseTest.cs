using FinalVeloPro.Page;
using FinalVeloPro.Tools;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalVeloPro.Test
{
    public class BaseTest
    {
        protected static IWebDriver driver;
        public static LogInPage logInPage;
        public static DviraciaiPage dviraciaiPage;
        public static AddToCartPage addToCartPage;
        public static FrontPage frontPage;
        public static SelectedBicyclePage selectedBicyclePage;
        public static CartPage cartPage;
        public static AfterSearchPage afterSearchPage;
        public static RegisterNewAccountPage registerNewAccountPage;
        public static SucessfullNewRegistration sucessfullNewRegistration;
        public static WriteEmailForAdmin writeEmailForAdmin;

        [OneTimeSetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            
            logInPage = new LogInPage(driver);
            dviraciaiPage = new DviraciaiPage(driver);
            addToCartPage = new AddToCartPage(driver);
            frontPage = new FrontPage(driver);
            selectedBicyclePage = new SelectedBicyclePage(driver);
            cartPage = new CartPage(driver);
            afterSearchPage = new AfterSearchPage(driver);
            registerNewAccountPage = new RegisterNewAccountPage(driver);
            sucessfullNewRegistration = new SucessfullNewRegistration(driver);
            writeEmailForAdmin = new WriteEmailForAdmin(driver);
        }
        [OneTimeTearDown]
        public static void TearDown()
        {
            driver.Quit();
        }
        [TearDown]
        public static void TakeScreeshot()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
                MyScreenshot.MakeScreeshot(driver);
        }
    }
}
