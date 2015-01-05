using System.Collections.Generic;
using System.Web.Mvc;
using EduAppWeb.Data;
using EduAppWeb.Domain;
using EduAppWeb.Infrastructure;

namespace EduAppWeb.Filters
{
    public class LogAttribute : ActionFilterAttribute
    {
        private IDictionary<string, object> _parameters;
        public ApplicationDbContext Context { get; set; }
        public ICurrentUser CurrentUser { get; set; }
        public string Description { get; set; }

        public LogAttribute(string description)
        {
            Description = description;
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            _parameters = filterContext.ActionParameters;
            base.OnActionExecuting(filterContext);
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            //var userId = filterContext.HttpContext.User.Identity.GetUserId();
            ////var context = new ApplicationDbContext();
            //var user = Context.Users.Find(userId);
            var description = Description;
            foreach (var kvp in _parameters)
            {
                description = description.Replace("{" + kvp.Key + "}", kvp.Value.ToString());
            }

            Context.Logs.Add(new LogAction(CurrentUser.User,
                filterContext.ActionDescriptor.ActionName,
                filterContext.ActionDescriptor.ControllerDescriptor.ControllerName,
                description));

            Context.SaveChanges();
        }

    } 
}