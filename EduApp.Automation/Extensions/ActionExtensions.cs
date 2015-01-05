using OpenQA.Selenium;

namespace EduApp.Automation.Extensions
{
    public static class ActionExtensions
    {
        public static void GoToUrl(this IWebDriver driver, string url)
        {
            driver.Navigate().GoToUrl(url);
        }
    }
}
