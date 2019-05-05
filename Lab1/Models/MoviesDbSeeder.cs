using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1.Models
{
    public class MoviesDbSeeder
    {
        public static void Initialize(MoviesDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any movies.
            if (context.Movies.Any())
            {
                return;   // DB has been seeded
            }

            context.Movies.AddRange(
                new Movie
                {
                    Title = "1984",
                    Runtime = 2,
                    Rating = 7.5,
                    Storyline = "Nice movie"
                },
                new Movie
                {
                    Title = "The Godfather",
                    Runtime = 3,
                    Rating = 9.5,
                    Storyline = "It's a long story..."
                }
            );
            context.SaveChanges();
        }
    }
}
