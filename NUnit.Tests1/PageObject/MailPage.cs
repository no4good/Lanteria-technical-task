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
    class MailPage
    {
        private IWebDriver driver;
        private WebDriverWait wait;
        public MailPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

     

        public void openDraftPage(IWebDriver driver)
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("div[data-tooltip='Черновики']"))).Click();
        }
        public void crateDraft(IWebDriver driver)
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("div.z0"))).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("textarea[name='to']"))).SendKeys("lanteria.technica.ltask@gmail.com");
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("input.aoT"))).SendKeys("lanteria.technica.ltask");
             wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("img.Ha"))).Click();
          
        }

        public void updateDraft(IWebDriver driver)
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("div.ae4.UI div.xS"))).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("input.aoT"))).SendKeys(".Update");
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("img.Ha"))).Click();

        }
        public void deleteDraft(IWebDriver driver)
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("div.ae4.UI div.oZ-jc"))).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("div.Bn"))).Click();
            
        }


    }
}
