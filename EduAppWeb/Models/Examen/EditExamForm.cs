using System.Web.Mvc;
using EduAppWeb.Domain;
using EduAppWeb.Infrastructure.Mapping;

namespace EduAppWeb.Models.Examen
{
    public class EditExamForm : IMapFrom<Domain.Exam>
    {
        public int ExamId { get; set; }
        public string Curso { get; set; }
        public string Carrera { get; set; }
        public string CreatorUserName { get; set; }
        public ExamType ExamType { get; set; }
        public SelectListItem[] AvailableExamTypes { get; set; }
    }
}