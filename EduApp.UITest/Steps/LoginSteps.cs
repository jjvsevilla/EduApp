using EduApp.Automation.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace EduApp.UITest.Steps
{
    [Binding]
    public class LoginSteps
    {
        private readonly LoginPage _login;

        public LoginSteps(IWebDriver driver)
        {
            _login = new LoginPage(driver);
        }

        [Given(@"that the user is at login page")]
        public void GivenThatTheUserIsAtLoginPage()
        {
            _login.GoTo();

            var pageTitle = _login.IsAt();
            const string loginTitle = "Log in";

            Assert.AreEqual(loginTitle, pageTitle);
        }

        [Given(@"the user inserts ""(.*)"" as email")]
        public void GivenTheUserInsertsAsEmail(string p0)
        {
            _login.WithEmail(p0);
        }

        [Given(@"the user inserts ""(.*)"" as password")]
        public void GivenTheUserInsertsAsPassword(string p0)
        {
            _login.WithPassword(p0);
        }

        [When(@"the user clicks the login button")]
        public void WhenTheUserClicksTheButton()
        {
            _login.Submit();
        }

        //lalal

    }
}
