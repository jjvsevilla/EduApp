using System.Collections.Generic;
using Microsoft.AspNet.Identity.EntityFramework;

namespace EduAppWeb.Domain
{
    public class ApplicationUser : IdentityUser
    {
        public IList<Issue> Assignments { get; set; }
    }
}