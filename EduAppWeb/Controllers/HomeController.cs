using System.Web.Mvc;
using EduAppWeb.Data;

namespace EduAppWeb.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ApplicationDbContext _context;

        //public HomeController(ApplicationDbContext context)
        //{
        //    _context = context;
        //}

        public ActionResult Index()
        {
            return View();
        }

    }

}