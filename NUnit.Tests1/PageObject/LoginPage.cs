using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace NUnit.Tests1.PageObject
{
    class LoginPage
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        [FindsBy(How = How.CssSelector, Using = "#gb_70")]
        private IWebElement buttonSignIn;

        [FindsBy(How = How.CssSelector, Using = "#identifierId")]
        private IWebElement emailTextField;

        [FindsBy(How = How.CssSelector, Using = "#identifierNext")]
        private IWebElement buttonIdentifierNext;

        public void navigateToGooglePage()
        {
            driver.Navigate().GoToUrl("https://www.google.com/");
        }

        public void navigateToSignInPage()
        {
            buttonSignIn.Click();
            emailTextField.SendKeys("lanteria.technica.ltask@gmail.com");
            buttonIdentifierNext.Click();
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("input[type='password']"))).SendKeys("rokdestbob322");
            wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("#passwordNext"))).Click();
        }

    }
}
