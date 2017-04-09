namespace TravelOn.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TravelOn.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<TravelOn.Models.TravelOnContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TravelOn.Models.TravelOnContext context)
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

            context.Categories.AddOrUpdate(x => x.ID,
       new Category() { ID = 20, Name = "Attractions" },
       new Category() { ID = 21, Name = "Beaches" },
       new Category() { ID = 22, Name = "Museum" },
       new Category() { ID = 23, Name = "Hotel" }
       );

            context.Rates.AddOrUpdate(x => x.ID,
new Rate() { ID = 20, Rating = 1 },
new Rate() { ID = 21, Rating = 2 },
new Rate() { ID = 22, Rating = 3 },
new Rate() { ID = 23, Rating = 4 },
new Rate() { ID = 24, Rating = 5 }
);

            context.Reviews.AddOrUpdate(x => x.ID,
                new Review()
                {
                    ID = 20,
                    Title = "Sandbox Easton",
                    Published = DateTime.Parse(DateTime.Today.ToString()),
                    CategoryID = 21,
                    Content = "Proin eget tortor risus. Curabitur aliquet quam id dui posuere blandit. Quisque velit nisi, pretium ut lacinia in, elementum id enim. Cras ultricies ligula sed magna dictum porta.",
                    RateID = 23,
                    ImagePath = "https://media-cdn.tripadvisor.com/media/photo-o/09/82/90/09/siesta-beach.jpg"

                },
                new Review()
                {
                    ID = 21,
                    Title = "The Pearfield",
                    Published = DateTime.Parse(DateTime.Today.ToString()),
                    CategoryID = 23,
                    Content = "Proin eget tortor risus. Curabitur aliquet quam id dui posuere blandit. Quisque velit nisi, pretium ut lacinia in, elementum id enim. Cras ultricies ligula sed magna dictum porta.",
                    RateID = 22,
                    ImagePath = "https://t-ec.bstatic.com/images/hotel/max1024x768/176/17609411.jpg"

                },
                new Review()
                {
                    ID = 22,
                    Title = "Steps to Heaven",
                    Published = DateTime.Parse(DateTime.Today.ToString()),
                    CategoryID = 20,
                    Content = "Proin eget tortor risus. Curabitur aliquet quam id dui posuere blandit. Quisque velit nisi, pretium ut lacinia in, elementum id enim. Cras ultricies ligula sed magna dictum porta.Curabitur aliquet quam id dui posuere blandit.",
                    RateID = 21,
                    ImagePath = "https://media-cdn.tripadvisor.com/media/photo-o/0e/99/92/d4/front-of-the-basilica.jpg"
                },
                new Review()
                {
                    ID = 23,
                    Title = "Upstar Arts Collective",
                    Published = DateTime.Parse(DateTime.Today.ToString()),
                    CategoryID = 22,
                    Content = "Proin eget tortor risus. Curabitur aliquet quam id dui posuere blandit. Quisque velit nisi, pretium ut lacinia in, elementum id enim. Cras ultricies ligula sed magna dictum porta.",
                    RateID = 24,
                    ImagePath = "https://media-cdn.tripadvisor.com/media/photo-o/05/6b/c7/ee/musee-du-louvre.jpg"
                },
                new Review()
                {
                    ID = 23,
                    Title = "Central Sack",
                    Published = DateTime.Parse(DateTime.Today.ToString()),
                    CategoryID = 23,
                    Content = "Proin eget tortor risus. Curabitur aliquet quam id dui posuere blandit. Quisque velit nisi, pretium ut lacinia in, elementum id enim. Cras ultricies ligula sed magna dictum porta.Curabitur aliquet quam id dui posuere blandit.",
                    RateID = 22,
                    ImagePath = "https://t-ec.bstatic.com/images/hotel/max1024x768/410/41074377.jpg"
                },
                new Review()
                {
                    ID = 25,
                    Title = "Asakusa Din",
                    Published = DateTime.Parse(DateTime.Today.ToString()),
                    CategoryID = 20,
                    Content = "Proin eget tortor risus. Curabitur aliquet quam id dui posuere blandit. Quisque velit nisi, pretium ut lacinia in, elementum id enim. Cras ultricies ligula sed magna dictum porta.Curabitur aliquet quam id dui posuere blandit.",
                    RateID = 24,
                    ImagePath = "https://s-ec.bstatic.com/images/hotel/max1024x768/376/37644077.jpg"
                },
                new Review()
                {
                    ID = 26,
                    Title = "Tokyo Robot Cabaret",
                    Published = DateTime.Parse(DateTime.Today.ToString()),
                    CategoryID = 20,
                    Content = "Proin eget tortor risus. Curabitur aliquet quam id dui posuere blandit. Quisque velit nisi, pretium ut lacinia in, elementum id enim. Cras ultricies ligula sed magna dictum porta.Curabitur aliquet quam id dui posuere blandit.",
                    RateID = 24,
                    ImagePath = "https://c1.staticflickr.com/8/7369/12974085683_525428d239_b.jpg"
                }
                );

        }
    }
}
