using System;

namespace EduAppWeb.Domain
{
    public class Exam
    {
        public int ExamId { get; set; }
        public ApplicationUser Creator { get; set; }
        public string Curso { get; set; }
        public string Carrera { get; set; }
        public DateTime CreatedAt { get; set; }
        public ExamType ExamType { get; set; }

         //For EF...
        protected Exam()
        {

        }

        public Exam(ApplicationUser creator, ExamType type, string curso, string carrera)
        {
            Creator = creator;
            Curso = curso;
            Carrera = carrera;
            CreatedAt = DateTime.Now;
            ExamType = type;
        }
    }
}