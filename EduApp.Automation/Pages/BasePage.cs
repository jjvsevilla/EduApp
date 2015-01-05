using System;
using EduApp.Automation.Utility;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace EduApp.Automation.Pages
{
    public abstract class BasePage
    {
        protected readonly IWebDriver Driver;

        protected BasePage(IWebDriver driver)
        {
            Driver = driver;
            WaitForPageToLoad();
        }

        protected void InitPage(object page)
        {
            PageFactory.InitElements(Driver, page);   
        }

        protected string Title()
        {
            return Driver.Title;
        }

        protected void WaitForPageToLoad()
        {
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(Constants.ApplicationTimeOut));
            wait.Until<bool>(d =>
            {
                try
                {
                    return d.ExecuteJavaScript<bool>(@"return document.readyState == 'complete'");
                }
                catch (InvalidOperationException ex)
                {

                    return false;
                }
            });
        }

    }
}
