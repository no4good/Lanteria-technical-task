using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using NUnit.Tests1.PageObject;
using System.Collections.ObjectModel;

namespace NUnit.Tests1
{

    [TestFixture]
    public class TestClass
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

        }

        [Test]
        public void SearchTextFromAboutPage()
        {

            
            LoginPage login = new LoginPage(driver);
            login.navigateToGooglePage();
            login.navigateToSignInPage();
            Helper helper = new Helper(driver);
            helper.navigateToMail(driver);
            MailPage mail = new MailPage(driver);
            mail.openDraftPage(driver);
            mail.crateDraft(driver);

            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("div.y6 span.bog span")));
            IWebElement nameDraft = driver.FindElement(By.CssSelector("div.y6 span.bog span"));
            Assert.AreEqual("lanteria.technica.ltask", nameDraft.Text, "The draft wasn’t created!");

            mail.updateDraft(driver);
            wait.Until(ExpectedConditions.ElementExists(By.CssSelector("img.Ha")));
            IWebElement updateDraft = driver.FindElement(By.CssSelector("div.y6 span.bog span"));
            Assert.AreEqual("lanteria.technica.ltask.Update", updateDraft.Text, "The draft wasn’t updated!");
            mail.deleteDraft(driver);
            helper.signOut(driver);
          

        }

        [TearDown]
        public void TearDown()
        {
           driver.Quit();
        }

    }
}
