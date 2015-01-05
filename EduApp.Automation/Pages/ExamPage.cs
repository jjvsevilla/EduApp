using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace EduApp.Automation.Pages
{
    public class ExamPage : BasePage
    {
        [FindsBy(How=How.LinkText, Using="Examen")]
        private IWebElement LinkExamen;

        public ExamPage(IWebDriver driver) 
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
            LinkExamen.Click();
        }

    }
}
