namespace EduAppWeb.Manager
{
    public class ExamManager
    {
        public bool ValidityOf(string curso, string carrera)
        {
            var isIncorrectLength = string.IsNullOrEmpty(curso) || string.IsNullOrEmpty(carrera);
            return !isIncorrectLength;
        }
    }
}