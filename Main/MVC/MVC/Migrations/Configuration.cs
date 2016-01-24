namespace MVC.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MVC.Models.GameDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MVC.Models.GameDBContext context)
        {
            context.Games.AddOrUpdate(i => i.Title,
               new Game
               {
                   Title = "Bloodborne",
                   ReleaseDate = DateTime.Parse("21-02-2015"),
                   Genre = "ActionRPG",
                   Platform = "PS4",
                   Done = 99,
                   Price = 259
               },
               new Game
               {
                   Title = "Dragons Dogma",
                   ReleaseDate = DateTime.Parse("21-02-2009"),
                   Genre = "ActionRPG",
                   Platform = "PS4",
                   Done = 15,
                   Price = 199
               },
               new Game
               {
                   Title = "Project Cars",
                   ReleaseDate = DateTime.Parse("11-09-2015"),
                   Genre = "Racing",
                   Platform = "PS4",
                   Done = 60,
                   Price = 249
               }
            );
        }
    }
}
