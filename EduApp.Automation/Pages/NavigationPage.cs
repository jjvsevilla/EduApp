using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace EduApp.Automation.Pages
{
    public class NavigationPage : BasePage
    {

        [FindsBy(How = How.LinkText, Using = "Home")]
        private IWebElement HomeLink;

        [FindsBy(How = How.LinkText, Using = "Examen")]
        private IWebElement ExamenLink;

        [FindsBy(How = How.LinkText, Using = "Log off")]
        private IWebElement LogOff;

        public NavigationPage(IWebDriver driver) 
            : base(driver)
        {
            InitPage(this);
        }

        public void GoToHomePage()
        {
            HomeLink.Click();
        }

        public void GoToExamenPage()
        {
            ExamenLink.Click();
        }

        public void Logout()
        {
            LogOff.Click();
        }
    }
}
