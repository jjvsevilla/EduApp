using System;
using System.Linq.Expressions;
using System.Web.Mvc;
using Microsoft.Web.Mvc;

namespace EduAppWeb.Infrastructure
{
    public abstract class AppController : Controller
    {
        protected ActionResult RedirectToAction<TController>(Expression<Action<TController>> action)
        where TController : Controller
        {
            return ControllerExtensions.RedirectToAction(this, action);
        }
    }
}