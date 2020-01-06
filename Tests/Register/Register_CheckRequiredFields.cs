using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using nunit.Helpers;
using nunit.PageObjects;
using System;
using System.Diagnostics;

namespace nunit.Tests
{
    class Register_CheckRequiredFields
    {
        public IWebDriver driver { get; set; }

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Test]
        [Category("Register")]

        public void CheckRequiredFieldsMessages()
        {
            var page = new RegisterPage(driver);
            page.driver.Navigate().GoToUrl(page.registerlink);
            var registerhelper = new WaitHelpers(driver);

            registerhelper.WaitForElementAndClick(page.CloseCookiesMessage);
            registerhelper.WaitForElementAndClick(page.CreateAccount);
            registerhelper.WaitForElementAndCheckMsg(page.NameSurnameMsg, "Podaj swoje imię i nazwisko.");
            registerhelper.WaitForElementAndCheckMsg(page.LoginMsg, "Wybierz dostępny adres email.");
            registerhelper.WaitForElementAndCheckMsg(page.GenderMsg, "Zaznacz swoją płeć.");
            registerhelper.WaitForElementAndCheckMsg(page.PasswordMsg, "Użyj co najmniej 6 znaków");
            registerhelper.WaitForElementAndCheckMsg(page.DateOfBirthMsg, "Podaj datę urodzenia.");
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
