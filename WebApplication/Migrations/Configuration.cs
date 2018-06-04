namespace WebApplication.Migrations
{
    using System;
	using System.Collections.Generic;
	using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
	using WebApplication.Models;

	internal sealed class Configuration : DbMigrationsConfiguration<WebApplication.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "WebApplication.Models.ApplicationDbContext";
        }

        protected override void Seed(WebApplication.Models.ApplicationDbContext context)
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

			var companies = new List<Company>
			{
				new Company { Name = "Facware" },
				new Company { Name = "Coca Cola" },
				new Company { Name = "Bimbo" }
			};
			companies.ForEach(x => context.Companies.AddOrUpdate(y => y.Name, x));
			context.SaveChanges();
        }
    }
}
