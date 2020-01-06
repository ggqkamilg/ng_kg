using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace nunit.Helpers
{
    public class WaitHelpers
    {
        IWebDriver driver;

        public WaitHelpers(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void WaitForElement(IWebElement by)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementToBeClickable(by));
        }
        public void WaitForElementAndClick(IWebElement by)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementToBeClickable(by));
            by.Click();
        }
        
        public void WaitForElementAndCheckMsg(IWebElement by, string Message)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementToBeClickable(by));
            Assert.IsTrue(by.Text.Contains(Message));
        }
    }
}
