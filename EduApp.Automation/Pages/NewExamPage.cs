using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace EduApp.Automation.Pages
{
    public class NewExamPage : BasePage
    {

        [FindsBy(How = How.LinkText, Using = "Create New")]
        private IWebElement LinkNewExamen;

        public NewExamPage(IWebDriver driver) 
            : base(driver)
        {
            InitPage(this);
        }

        public string IsAt()
        {
            return Title();
        }

        public void GoTo()
        {
            LinkNewExamen.Click();
        }
        
    }
}
