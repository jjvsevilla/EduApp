using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace EduApp.Automation.Pages
{
    public class ExamPage : NavigationPage
    {

        [FindsBy(How = How.LinkText, Using = "Create New")]
        private IWebElement NewExamenLink;

        public ExamPage(IWebDriver driver) 
            : base(driver)
        {
            InitPage(this);
        }

        public string IsAt()
        {
            return Title();
        }

        public void GoToNewExamenPage()
        {
            NewExamenLink.Click();   
        }
    }
}
