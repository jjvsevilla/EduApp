using System.IO;
using EduApp.Automation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;

namespace EduApp.Automation.Utility
{
    public static class Utilities
    {
        public static IWebDriver LoadDriver(Constants.Browsers browser)
        {
            IWebDriver driver = null;
            switch (browser)
            {
                case Constants.Browsers.GoogleChrome:
                    driver = LoadGoogleChromeDriver();
                    break;
                case  Constants.Browsers.InternetExplorer:
                    driver = LoadInternetExplorerDriver();
                    break;
            }
            return driver;
        }

        private static IWebDriver LoadGoogleChromeDriver()
        {
            var options = new ChromeOptions();
            options.AddArgument("test-type");
            options.AddArgument("start-maximized");
            options.AddArgument("--disable-extensions");
            var driver = new ChromeDriver(GetDriverPath(), options);
            return driver;
        }

        private static IWebDriver LoadInternetExplorerDriver()
        {
            var options = new InternetExplorerOptions
            {
                EnableNativeEvents = true,
                IgnoreZoomLevel = true,
                EnsureCleanSession = true,
            };
            var driver = new InternetExplorerDriver(GetDriverPath(), options);
            driver.WindowMaximize();
            return driver;
        }

        private static string GetDriverPath()
        {
            var projectPath = Directory.GetCurrentDirectory()
                .Replace(Constants.DebugFolder, Constants.ReleaseFolder)
                .Replace(Constants.SpecFlowProject, Constants.FrameworkProject);
            var driverPath = Path.Combine(projectPath, Constants.DriverFolder);
            return driverPath;
        }

        public static string GetProjectUrl(Constants.Environments environment)
        {
            switch (environment)
            {
                case Constants.Environments.DEV:
                case Constants.Environments.QA:
                case Constants.Environments.PROD:
                    return Constants.DevUrl;
                default:
                    return Constants.DevUrl;
            }
        }

    }
}
