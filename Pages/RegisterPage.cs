using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace nunit.PageObjects
{
    class RegisterPage
    {
        public IWebDriver driver { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='cmp-closebutton_closeButton cmp-closebutton_hasBorder ']")]
        public IWebElement CloseCookiesMessage { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='registerLink']")]
        public IWebElement RegisterButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@id='registerEmailFormSubmitButton']")]
        public IWebElement CreateAccount{ get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='formHeader']/h1")]
        public IWebElement RegisterMsg{ get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='content' and contains(text(),'Podaj swoje imię i nazwisko.')]")]
        public IWebElement NameSurnameMsg{ get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='content']/strong")]
        public IWebElement LoginMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='content' and contains(text(),'Podaj datę urodzenia.')]")]
        public IWebElement DateOfBirthMsg{ get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='content' and contains(text(),'Zaznacz swoją płeć.')]")]
        public IWebElement GenderMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='content' and contains(text(),'Użyj co najmniej 6 znaków')]")]
        public IWebElement PasswordMsg { get; set; }
        
        public RegisterPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public string registerlink = "https://konto.onet.pl/register-email.html?state=data.html&app_id=konto.onet.pl.front";
    }
}
