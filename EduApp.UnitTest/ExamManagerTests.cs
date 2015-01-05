using EduAppWeb.Manager;
using NUnit.Framework;

namespace EduApp.UnitTest
{
    [TestFixture]
    public class ExamManagerTests
    {
        //[Test]
        [TestCase("ingles", "ingenieria de sistemas", true)]
        [TestCase("mate", "", false)]
        [TestCase("mate 2", "ingenieria de sistemas", true)]
        public void ShouldValidateExamInputs(string curso, string carrera, bool expectedResult)
        {
            var sut = new ExamManager();
            var actualResult = sut.ValidityOf(curso, carrera);
            //Assert.That(isValid, Is.True);
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }
    }
}
