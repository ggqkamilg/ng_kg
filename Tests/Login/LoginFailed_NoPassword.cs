using nunit.Helpers;
using nunit.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace nunit.Tests
{
    class LoginFailed_NoPassword
    {
        public static IWebDriver driver { get; set; }

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Test]
        [Category("Login")]
        public void LogInFailedNoPassword()
        {
            var page = new LoginPage(driver);
            page.driver.Navigate().GoToUrl(page.loginlink);
            var loginhelper = new WaitHelpers(driver);
            
            loginhelper.WaitForElementAndClick(page.CloseCookiesMessage);
            loginhelper.WaitForElementAndClick(page.LoginField);
            page.login_onlylogin(page.userlogin);
            loginhelper.WaitForElementAndCheckMsg(page.WrongPasswordMsg, "Wprowadź hasło.");
            Console.WriteLine("Test succesfull.");
        }

        [TearDown]
        public void close()
        {
            if (driver != null)
            {
                driver.Close();
                driver.Quit();
            }
        }

    }
}
