using BoDi;
using EduApp.Automation.Utility;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace EduApp.UITest.Hooks
{
    [Binding]
    public class BeforeAfterScenario
    {
        private readonly IObjectContainer _objectContainer;

        public BeforeAfterScenario(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            var webDriver = Driver.Initialize(Constants.Browsers.GoogleChrome, Constants.Environments.QA);
            _objectContainer.RegisterInstanceAs<IWebDriver>(webDriver);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            //TODO: implement logic that has to run after executing each scenario
        }
    }
}
