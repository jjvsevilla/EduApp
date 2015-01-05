using System;
using EduAppWeb.Domain;
using EduAppWeb.Infrastructure.Mapping;

namespace EduAppWeb.Models.Examen
{
    public class ExamDetailViewModel : IMapFrom<Domain.Exam>
    {
        public int ExamId { get; set; }
        public string Curso { get; set; }
        public string Carrera { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatorUserName { get; set; }
        public ExamType ExamType { get; set; }
    }
}