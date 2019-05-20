using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVC2.Models
{
    public class WedContext : DbContext
    {
        public DbSet<Couple> Couples { get; set; }
        public DbSet<Variant> Variants { get; set; }
    }
   /* public class CoupleDbInitializer : DropCreateDatabaseAlways<WedContext>
    {
        protected override void Seed(WedContext Db)
        {
            Db.Couples.Add(new Couple { Boy = "Mark", Bride = "Nina", Surname = "Mejuev", RegistrationDay = DateTime.Now });
            Db.Couples.Add(new Couple { Boy = "Tolik", Bride = "Megan", Surname = "Basskov", RegistrationDay = DateTime.Now });
            Db.Couples.Add(new Couple { Boy = "Vasya", Bride = "Masha", Surname = "Geshko", RegistrationDay = DateTime.Now });
            base.Seed(Db);
        }
    }*/
}