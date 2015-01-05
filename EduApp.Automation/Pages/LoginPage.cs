using EduApp.Automation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace EduApp.Automation.Pages
{
    public class LoginPage : BasePage
    {
        [FindsBy(How = How.Id, Using = "Email")] 
        private IWebElement Email;

        [FindsBy(How = How.Id, Using = "Password")] 
        private IWebElement Password;

        [FindsBy(How=How.CssSelector, Using = "input[type='submit']")]
        private IWebElement SubmitButton;
        
        public LoginPage(IWebDriver driver) 
            : base(driver)
        {
            InitPage(this);
        }

        public string IsAt()
        {
            return Title();
        }

        public void GoTo()
        {
            Driver.GoToUrl(Utility.Driver.BaseUrl);
        }

        public void WithEmail(string email)
        {
            Email.SendKeys(email);
        }

        public void WithPassword(string password)
        {
            Password.SendKeys(password);
        }

        public void Submit()
        {
            SubmitButton.Click();
        }
    }
}
