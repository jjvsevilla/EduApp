using OpenQA.Selenium;

namespace EduApp.Automation.Pages
{
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver driver)
            : base(driver)
        {
            InitPage(this);
        }

        public string IsAt()
        {
            return Title();
        }
    }
}
