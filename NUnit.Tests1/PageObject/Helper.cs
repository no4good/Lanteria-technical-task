using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace NUnit.Tests1.PageObject
{
    class Helper
    {
        private IWebDriver driver;
        private WebDriverWait wait;
        public Helper(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }
     
        public void navigateToMail(IWebDriver driver)
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("a[href='https://www.google.com.ua/intl/ru/about/products?tab=wh']"))).Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("a[href='https://mail.google.com/mail/?tab=wm']"))).Click();
        }

        public void signOut(IWebDriver driver)
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("span.bAq")));
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("span.gb_za"))).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("a#gb_71"))).Click();
          
        }
        public void drafCreationCheck(IWebDriver driver)
        {

            wait.Until(ExpectedConditions.ElementExists(By.CssSelector("img.Ha")));
            wait.Until(ExpectedConditions.ElementExists(By.CssSelector("div.y6 span.bog span")));
            ReadOnlyCollection<IWebElement> drafts = driver.FindElements(By.CssSelector("div.ae4.UI div.y6 span.bog span"));
            Assert.AreEqual("lanteria.technica.ltask", drafts[0].Text, "The draft wasn’t created!");
        }

        public void drafUpdateCheck(IWebDriver driver)
        {

            wait.Until(ExpectedConditions.ElementExists(By.CssSelector("img.Ha")));
            ReadOnlyCollection<IWebElement> updateDraft = driver.FindElements(By.CssSelector("div.ae4.UI div.y6 span.bog span"));
            Assert.AreEqual("lanteria.technica.ltask.Update", updateDraft[0].Text, "The draft wasn’t updated!");
        }
    }
}
