using System;
using EduApp.Automation.Utility;
using OpenQA.Selenium;

namespace EduApp.Automation.Extensions
{
    public static class DriverExtensions
    {
        public static void WindowMaximize(this IWebDriver driver)
        {
            driver.Manage().Window.Maximize();
        }

        public static void TurnOnWait(this IWebDriver driver)
        {
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(Constants.ApplicationTimeOut));
        }
    }
}
