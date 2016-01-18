namespace BCHHC.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    using BCHHC.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<BCHHC.Models.BCHHCDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "BCHHC.Models.BCHHCDb";
        }

        protected override void Seed(BCHHC.Models.BCHHCDb context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.Patients.AddOrUpdate(l => l.Lastname,
                new Patient { Lastname = "Morsillo", Firstname = "Lindsay" },
                new Patient { Lastname = "Zappa", Firstname = "Frank" }

           );
        }
    }
}
