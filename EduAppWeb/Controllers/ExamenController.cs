using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper.QueryableExtensions;
using EduAppWeb.Data;
using EduAppWeb.Domain;
using EduAppWeb.Filters;
using EduAppWeb.Infrastructure;
using EduAppWeb.Infrastructure.Alerts;
using EduAppWeb.Models.Examen;
using Microsoft.AspNet.Identity;

namespace EduAppWeb.Controllers
{
    public class ExamenController : AppController
    {
        private readonly ApplicationDbContext _context;
        private readonly ICurrentUser _currentUser;

        public ExamenController(ApplicationDbContext context, ICurrentUser currentUser)
        {
            _context = context;
            _currentUser = currentUser;
        }

        private SelectListItem[] GetAvailableExamTypes()
        {
            return Enum.GetValues(typeof (ExamType))
                .Cast<ExamType>()
                .Select(t => new SelectListItem {Text = t.ToString(), Value = t.ToString()})
                .ToArray();
        }

        public ActionResult Index()
        {
            var examenes = _context.Examenes
                .Project().To<ExamSummaryViewModel>();
            return View(examenes.ToArray());
        }

        public ActionResult New()
        {
            var form = new NewExamForm
            {
                AvailableExamTypes = GetAvailableExamTypes()
            };
            return View(form);
        }

        [HttpPost, ValidateAntiForgeryToken, Log("Examen creado!")]
        public ActionResult New(NewExamForm form)
        {
            if (!ModelState.IsValid)
            {
                form.AvailableExamTypes = GetAvailableExamTypes();
                return View(form);
            }

            _context.Examenes.Add(new Exam(_currentUser.User, form.ExamType, form.Curso, form.Carrera));
            _context.SaveChanges();

            return RedirectToAction<ExamenController>(a => a.Index())
                .WithSuccess("Examen creado!");
        }

        [Log("Examen visualizado {id}")]
        public ActionResult Details(int id)
        {
            var model = _context.Examenes
                .Project().To<ExamDetailViewModel>()
                .SingleOrDefault(i => i.ExamId == id);

            if(model == null)
                return RedirectToAction<ExamenController>(a => a.Index())
                    .WithError("Examen no encontrado. Talvez fue eliminado?");

            return View(model);
        }

        [Log("Empezo la edicion del examen {id}")]
        public ActionResult Edit(int id)
        {
            var form = _context.Examenes
                .Project().To<EditExamForm>()
                .SingleOrDefault(i => i.ExamId == id);

            if (form == null)
            {
                return RedirectToAction<ExamenController>(a => a.Index())
                    .WithError("Examen no encontrado. Talvez fue eliminado?");
            }
            
            form.AvailableExamTypes = GetAvailableExamTypes();

            return View(form);
        }
        
        [HttpPost, Log("Grabando cambios")]
        public ActionResult Edit(EditExamForm form)
        {
            if (!ModelState.IsValid)
            {
                form.AvailableExamTypes = GetAvailableExamTypes();
                return View(form);
            }

            var examen = _context.Examenes.SingleOrDefault(i => i.ExamId == form.ExamId);

            if (examen == null)
            {
                return RedirectToAction<ExamenController>(a => a.Index())
                    .WithError("Examen no encontrado. Talvez fue eliminado?");
            }

            examen.Curso = form.Curso;
            examen.Carrera = form.Carrera;
            examen.ExamType = form.ExamType;

            _context.SaveChanges();


            return RedirectToAction<ExamenController>(a => a.Index())
                .WithSuccess("Examen actualizado!");
        }

        //[HttpPost, ValidateAntiForgeryToken, Log("Examen eliminado {id}")]
        [Log("Examen eliminado {id}")]
        public ActionResult Delete(int id)
        {
            var examen = _context.Examenes.Find(id);
            if (examen == null)
                return RedirectToAction<ExamenController>(a => a.Index())
                    .WithError("Examen no encontrado. Talvez fue eliminado?");

            _context.Examenes.Remove(examen);

            _context.SaveChanges();

            return RedirectToAction<ExamenController>(a => a.Index())
                .WithSuccess("Examen eliminado!");
        }

    }
}