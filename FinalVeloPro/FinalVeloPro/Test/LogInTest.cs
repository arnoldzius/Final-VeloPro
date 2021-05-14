using FinalVeloPro.Page;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalVeloPro.Test
{
    public class LogInTest : BaseTest
    {
        
        
        [Test]
        public static void Test1Connection()
        {
            string mail = "vincas88@yahoo.com";
            string password = "slaptazodis88";
            //string logOfText = "Atsijungti";

            frontPage.NavigateToDefaultPage();
            frontPage.EnterLogInSection();
            logInPage.NavigateToDefaultPage();
            logInPage.Connect(mail, password);
            
            //logInPage.LogOff(logOfText);
  
        }

     

        
        [Test]
        public static void Test2SelectFavoriteBicycle()
        {
            dviraciaiPage.SelectBicyclesBar();
            addToCartPage.NavigateToDefaultPage();
            addToCartPage.ClickOnSelectedBicycleButton();

        }
        [Test]
        public static void Test3ButtonTest()
        {
            string text = "minicart-buttons";
            selectedBicyclePage.NavigateToDefaultPage();
            selectedBicyclePage.MinusAndPlusButton();
            selectedBicyclePage.CartButtons();
            selectedBicyclePage.GotoCartselectByText(text);
            
        }
       
      
    }
}
