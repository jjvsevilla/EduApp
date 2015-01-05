using System.Web.Mvc;
using EduAppWeb.Domain;
using EduAppWeb.Infrastructure.Mapping;

namespace EduAppWeb.Models.Examen
{
    public class NewExamForm : IMapFrom<Domain.Exam>
    {
        public string Curso { get; set; }
        public string Carrera { get; set; }
        public ExamType ExamType { get; set; }
        public SelectListItem[] AvailableExamTypes { get; set; }
    }
}