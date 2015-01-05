using System.Data.Entity;
using EduAppWeb.Domain;
using Microsoft.AspNet.Identity.EntityFramework;

namespace EduAppWeb.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        public DbSet<Issue> Issues { get; set; }
        public DbSet<LogAction> Logs { get; set; }
        public DbSet<Exam> Examenes { get; set; }
    }
}