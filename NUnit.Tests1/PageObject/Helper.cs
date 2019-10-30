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
          
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("span.gb_xa"))).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("a#gb_71"))).Click();
           

        }
    }
}
