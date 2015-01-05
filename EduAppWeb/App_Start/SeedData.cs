using System;
using System.Linq;
using EduAppWeb.Data;
using EduAppWeb.Domain;
using EduAppWeb.Infrastructure.Tasks;
using Microsoft.Ajax.Utilities;

namespace EduAppWeb.App_Start
{
    public class SeedData : IRunAtStartup
    {
        private readonly ApplicationDbContext _context;

        public SeedData(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Execute()
        {
            //if (!_context.Users.Any())
            //{
            //    _context.Users.Add(new ApplicationUser
            //    {
            //        UserName = "TestUser"
            //    });
            //    _context.SaveChanges();
            //}
            //if (!_context.Examenes.Any())
            //{
            //    var user = _context.Users.First();
            //    _context.Examenes.Add(new Exam(user, ExamType.Final, "Ingles basico", "Ingenieria de sistemas"));
            //    _context.Examenes.Add(new Exam(user, ExamType.Parcial, "Ingles intermedio", "Ingenieria de sistemas"));
            //    _context.Examenes.Add(new Exam(user, ExamType.Practica, "Ingles avanzado 1", "Ingenieria de sistemas"));
            //    _context.Examenes.Add(new Exam(user, ExamType.Practica, "Ingles avanzado 2", "Ingenieria de sistemas"));
            //    _context.SaveChanges();
            //}
        }
    }
}