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
            new Category() { ID = 1, Name = "Attractions" },
            new Category() { ID = 2, Name = "Beaches" },
            new Category() { ID = 3, Name = "Museum" },
            new Category() { ID = 4, Name = "Hotel" }
                    );

            context.Rates.AddOrUpdate(x => x.ID,
            new Rate() { ID = 1, Rating = 1 },
            new Rate() { ID = 2, Rating = 2 },
            new Rate() { ID = 3, Rating = 3 },
            new Rate() { ID = 4, Rating = 4 },
            new Rate() { ID = 5, Rating = 5 }
                    );

            context.Reviews.AddOrUpdate(x => x.ID,
                 new Review()
                 {
                     ID = 20,
                     Title = "The Drop Hotel",
                     Published = DateTime.Parse(DateTime.Today.ToString()),
                     CategoryID = 4,
                     Content = "Proin eget tortor risus. Curabitur aliquet quam id dui posuere blandit. Quisque velit nisi, pretium ut lacinia in, elementum id enim. Cras ultricies ligula sed magna dictum porta.",
                     RateID = 4,
                     ImagePath = "https://s-ec.bstatic.com/images/hotel/max1024x768/444/44462049.jpg"

                 },

                new Review()
                {
                    ID = 21,
                    Title = "Sandbox Easton",
                    Published = DateTime.Parse(DateTime.Today.ToString()),
                    CategoryID = 2,
                    Content = "Proin eget tortor risus. Curabitur aliquet quam id dui posuere blandit. Quisque velit nisi, pretium ut lacinia in, elementum id enim. Cras ultricies ligula sed magna dictum porta.",
                    RateID = 3,
                    ImagePath = "https://media-cdn.tripadvisor.com/media/photo-o/09/82/90/09/siesta-beach.jpg"

                },
                new Review()
                {
                    ID = 22,
                    Title = "The Pearfield",
                    Published = DateTime.Parse(DateTime.Today.ToString()),
                    CategoryID = 3,
                    Content = "Proin eget tortor risus. Curabitur aliquet quam id dui posuere blandit. Quisque velit nisi, pretium ut lacinia in, elementum id enim. Cras ultricies ligula sed magna dictum porta.",
                    RateID = 5,
                    ImagePath = "https://t-ec.bstatic.com/images/hotel/max1024x768/176/17609411.jpg"

                },
                new Review()
                {
                    ID = 23,
                    Title = "Steps to Heaven",
                    Published = DateTime.Parse(DateTime.Today.ToString()),
                    CategoryID = 1,
                    Content = "Proin eget tortor risus. Curabitur aliquet quam id dui posuere blandit. Quisque velit nisi, pretium ut lacinia in, elementum id enim. Cras ultricies ligula sed magna dictum porta.Curabitur aliquet quam id dui posuere blandit.",
                    RateID = 1,
                    ImagePath = "https://media-cdn.tripadvisor.com/media/photo-o/0e/99/92/d4/front-of-the-basilica.jpg"
                },
                new Review()
                {
                    ID = 24,
                    Title = "Upstar Arts Collective",
                    Published = DateTime.Parse(DateTime.Today.ToString()),
                    CategoryID = 3,
                    Content = "Proin eget tortor risus. Curabitur aliquet quam id dui posuere blandit. Quisque velit nisi, pretium ut lacinia in, elementum id enim. Cras ultricies ligula sed magna dictum porta.",
                    RateID = 4,
                    ImagePath = "https://media-cdn.tripadvisor.com/media/photo-o/05/6b/c7/ee/musee-du-louvre.jpg"
                },
                new Review()
                {
                    ID = 25,
                    Title = "Central Sack",
                    Published = DateTime.Parse(DateTime.Today.ToString()),
                    CategoryID = 4,
                    Content = "Proin eget tortor risus. Curabitur aliquet quam id dui posuere blandit. Quisque velit nisi, pretium ut lacinia in, elementum id enim. Cras ultricies ligula sed magna dictum porta.Curabitur aliquet quam id dui posuere blandit.",
                    RateID = 2,
                    ImagePath = "https://t-ec.bstatic.com/images/hotel/max1024x768/410/41074377.jpg"
                },
                new Review()
                {
                    ID = 26,
                    Title = "Asakusa Din",
                    Published = DateTime.Parse(DateTime.Today.ToString()),
                    CategoryID = 1,
                    Content = "Proin eget tortor risus. Curabitur aliquet quam id dui posuere blandit. Quisque velit nisi, pretium ut lacinia in, elementum id enim. Cras ultricies ligula sed magna dictum porta.Curabitur aliquet quam id dui posuere blandit.",
                    RateID = 4,
                    ImagePath = "https://s-ec.bstatic.com/images/hotel/max1024x768/376/37644077.jpg"
                },
                new Review()
                {
                    ID = 27,
                    Title = "Tokyo Robot Cabaret",
                    Published = DateTime.Parse(DateTime.Today.ToString()),
                    CategoryID = 1,
                    Content = "Proin eget tortor risus. Curabitur aliquet quam id dui posuere blandit. Quisque velit nisi, pretium ut lacinia in, elementum id enim. Cras ultricies ligula sed magna dictum porta.Curabitur aliquet quam id dui posuere blandit.",
                    RateID = 5,
                    ImagePath = "https://c1.staticflickr.com/8/7369/12974085683_525428d239_b.jpg"
                },
                                new Review()
                {
                    ID = 28,
                    Title = "Mama Meats",
                    Published = DateTime.Parse(DateTime.Today.ToString()),
                    CategoryID = 1,
                    Content = "Proin eget tortor risus. Curabitur aliquet quam id dui posuere blandit. Quisque velit nisi, pretium ut lacinia in, elementum id enim. Cras ultricies ligula sed magna dictum porta.Curabitur aliquet quam id dui posuere blandit.",
                    RateID = 3,
                    ImagePath = "https://pix6.agoda.net/hotelImages/197/1979625/1979625_17020218140050738359.jpg?s=1024x768"
                                }
                );

        }
    }
}
