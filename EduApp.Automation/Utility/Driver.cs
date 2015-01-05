using EduApp.Automation.Extensions;
using OpenQA.Selenium;

namespace EduApp.Automation.Utility
{
    public static class Driver
    {
        public static string BaseUrl { get; set; }

        public static IWebDriver Initialize(Constants.Browsers browser, Constants.Environments environment)
        {
            var driver = Utilities.LoadDriver(browser);
            BaseUrl = Utilities.GetProjectUrl(environment);
            driver.TurnOnWait();
            return driver;

        }
    }
}
