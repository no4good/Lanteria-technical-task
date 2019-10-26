using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;


namespace NUnit.Tests1
{

    [TestFixture]
    public class TestClass
    {
        
        [Test]
        public void Create_Draft()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.google.com/";
            var wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(10000));

            String themeDraft = "lanteria.technica.ltask";
            String updateThemeDraft = "lanteria.technica.ltask.Update";

            IWebElement buttonSignIn = driver.FindElement(By.CssSelector("#gb_70"));
            buttonSignIn.Click();

            IWebElement emailTextField = driver.FindElement(By.CssSelector("#identifierId"));
            emailTextField.SendKeys("lanteria.technica.ltask@gmail.com");

            IWebElement buttonIdentifierNext = driver.FindElement(By.CssSelector("#identifierNext"));
            buttonIdentifierNext.Click();

            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("input[type='password']"))).SendKeys("rokdestbob322");
            wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("#passwordNext"))).Click();

            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("a[href='https://www.google.com.ua/intl/ru/about/products?tab=wh']"))).Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("a[href='https://mail.google.com/mail/?tab=wm']"))).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("div[data-tooltip='Черновики']"))).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("div.z0"))).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("textarea[name='to']"))).SendKeys("lanteria.technica.ltask@gmail.com");
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("input.aoT"))).SendKeys(themeDraft);
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("img.Ha"))).Click();

            IWebElement nameDraft = driver.FindElement(By.XPath("/html/body/div[7]/div[3]/div/div[2]/div[1]/div[2]/div/div/div/div/div[2]/div/div[1]/div/div[2]/div[3]/div[1]/div/table/tbody/tr[1]/td[6]/div/div/div/span/span"));

            Assert.AreEqual(themeDraft, nameDraft.Text, "The draft wasn’t created!");

            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[7]/div[3]/div/div[2]/div[1]/div[2]/div/div/div/div/div[2]/div/div[1]/div/div[2]/div[3]/div[1]/div/table/tbody/tr[1]/td[6]/div/div/div/span/span"))).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("input.aoT"))).SendKeys(".Update");
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("img.Ha"))).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[7]/div[3]/div/div[2]/div[1]/div[2]/div/div/div/div/div[2]/div/div[1]/div/div[2]/div[3]/div[1]/div/table/tbody/tr/td[2]"))).Click();
            IWebElement updateDraft = driver.FindElement(By.XPath("/html/body/div[7]/div[3]/div/div[2]/div[1]/div[2]/div/div/div/div/div[2]/div/div[1]/div/div[2]/div[3]/div[1]/div/table/tbody/tr[1]/td[6]/div/div/div/span/span"));

            Assert.AreEqual(updateThemeDraft, updateDraft.Text, "The draft wasn’t updated!");

            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("div.Bn"))).Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("span.gb_xa"))).Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("a#gb_71"))).Click();


            driver.Quit();
        }
    }
}
