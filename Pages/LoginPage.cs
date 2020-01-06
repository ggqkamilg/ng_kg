using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace nunit.PageObjects
{
    class LoginPage
    {
        public IWebDriver driver { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='cmp-closebutton_closeButton cmp-closebutton_hasBorder ']")]
        public IWebElement CloseCookiesMessage { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@name='login']")]
        public IWebElement LoginField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@name='password']")]
        public IWebElement PasswordField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='loginButton']")]
        public IWebElement LoginButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='messageContent']/strong/span")]
        public IWebElement WrongPasswordMsg { get; set; }

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public string loginlink = "https://konto.onet.pl";
        public string userlogin = "kamilgut@poczta.onet.pl";

        public void login_onlylogin(string login)
        {
            LoginField.SendKeys(login);
            LoginButton.Click();
        }
        

    }
}
