using EduApp.Automation.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace EduApp.UITest.Steps
{
    [Binding]
    public class ExamSteps
    {
        private readonly ExamPage _exam;

        public ExamSteps(IWebDriver driver)
        {
            _exam = new ExamPage(driver);
        }

        [When(@"the user clicks the Exam link")]
        public void WhenTheUserClicksTheExamLink()
        {
            _exam.GoTo();
        }


        [Then(@"the system redirects to the exam page")]
        public void ThenTheSystemRedirectsToTheExamPage()
        {
            var pageTitle = _exam.IsAt();
            const string examTitle = "Examen Page";

            Assert.AreEqual(examTitle, pageTitle);
        }

    }
}
