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
        public void CreateDraft()
        {

            
            LoginPage login = new LoginPage(driver);
            login.navigateToGooglePage();
            login.navigateToSignInPage();
            Helper helper = new Helper(driver);
            helper.navigateToMail(driver);
            MailPage mail = new MailPage(driver);
            mail.openDraftPage(driver);
            mail.crateDraft(driver);
            helper.drafCreationCheck(driver);
            mail.updateDraft(driver);
            helper.drafUpdateCheck(driver);
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
