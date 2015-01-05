using EduApp.Automation.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace EduApp.UITest.Steps
{
    [Binding]
    public class HomeSteps
    {
        private readonly HomePage _home;

        public HomeSteps(IWebDriver driver)
        {
               _home = new HomePage(driver); 
        }
        
        [Then(@"the system redirects to the home page")]
        public void ThenTheSystemRedirectsToTheHomePage()
        {
            var pageTitle = _home.IsAt();
            const string homeTitle = "Home Page";

            Assert.AreEqual(homeTitle, pageTitle);
        }

    }
}
