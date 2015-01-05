using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EduAppWeb.Data
{
    public class DbInitializer
    {
        public static void Initialize()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<ApplicationDbContext>());
            new ApplicationDbContext().Examenes.FirstOrDefault();
        }
    }
}