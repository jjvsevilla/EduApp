using System;
using EduAppWeb.Models;

namespace EduAppWeb.Domain
{
    public class LogAction
    {
        public LogAction(ApplicationUser performedBy, string action, string controller, string description)
        {
            PerformedBy = performedBy;
            Action = action;
            Controller = controller;
            Description = description;
            PerformedAt = DateTime.Now;
        }

        public int LogActionID { get; set; }
        public DateTime PerformedAt { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
        public ApplicationUser PerformedBy { get; set; }
        public string Description { get; set; }
    }
}