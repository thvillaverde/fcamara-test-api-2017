namespace FCamara.Infra.Migrations
{
    using Domain.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FCamara.Infra.Context.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(FCamara.Infra.Context.DataContext context)
        {
            //  This method will be called after migrating to the latest version.
            context.Users.AddOrUpdate(x => x.Id,
                new User("admin", "fcamara", "fcamara"));

            context.Products.AddOrUpdate(x => x.Id,
                new Product("Computador", 3500),
                new Product("Celular", 800),
                new Product("Televisão", 1500));
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
        }
    }
}
