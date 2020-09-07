using System;
using System.Collections.Generic;
using System.Linq;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static void SeedData(DataContext context)
        {
            if (!context.Plans.Any())
            {
                var plans = new List<Plan>
                {
                    new Plan
                    {
                        Title = "Past Plan 1",
                        Date = DateTime.Now.AddMonths(-2),
                        Description = "Plan 2 months ago",
                        Category = "drinks",
                        City = "London",
                        Venue = "Pub",
                    },
                    new Plan
                    {
                        Title = "Past Plan 2",
                        Date = DateTime.Now.AddMonths(-1),
                        Description = "Plan 1 month ago",
                        Category = "culture",
                        City = "Paris",
                        Venue = "Louvre",
                    },
                    new Plan
                    {
                        Title = "Future Plan 1",
                        Date = DateTime.Now.AddMonths(1),
                        Description = "Plan 1 month in future",
                        Category = "culture",
                        City = "London",
                        Venue = "Natural History Museum",
                    },
                    new Plan
                    {
                        Title = "Future Plan 2",
                        Date = DateTime.Now.AddMonths(2),
                        Description = "Plan 2 months in future",
                        Category = "music",
                        City = "London",
                        Venue = "O2 Arena",
                    },
                    new Plan
                    {
                        Title = "Future Plan 3",
                        Date = DateTime.Now.AddMonths(3),
                        Description = "Plan 3 months in future",
                        Category = "drinks",
                        City = "London",
                        Venue = "Another pub",
                    },
                    new Plan
                    {
                        Title = "Future Plan 4",
                        Date = DateTime.Now.AddMonths(4),
                        Description = "Plan 4 months in future",
                        Category = "drinks",
                        City = "London",
                        Venue = "Yet another pub",
                    },
                    new Plan
                    {
                        Title = "Future Plan 5",
                        Date = DateTime.Now.AddMonths(5),
                        Description = "Plan 5 months in future",
                        Category = "drinks",
                        City = "London",
                        Venue = "Just another pub",
                    },
                    new Plan
                    {
                        Title = "Future Plan 6",
                        Date = DateTime.Now.AddMonths(6),
                        Description = "Plan 6 months in future",
                        Category = "music",
                        City = "London",
                        Venue = "Roundhouse Camden",
                    },
                    new Plan
                    {
                        Title = "Future Plan 7",
                        Date = DateTime.Now.AddMonths(7),
                        Description = "Plan 2 months ago",
                        Category = "travel",
                        City = "London",
                        Venue = "Somewhere on the Thames",
                    },
                    new Plan
                    {
                        Title = "Future Plan 8",
                        Date = DateTime.Now.AddMonths(8),
                        Description = "Plan 8 months in future",
                        Category = "film",
                        City = "London",
                        Venue = "Cinema",
                    }
                };

                context.Plans.AddRange(plans);
                context.SaveChanges();

            }
        }
    }
}