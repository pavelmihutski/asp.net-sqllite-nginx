using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using libraryApp.Data;
using System;
using System.Linq;

namespace libraryApp.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcBookContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcBookContext>>()))
            {
                // Look for any movies.
                if (context.Book.Any())
                {
                    return;   // DB has been seeded
                }

                context.Book.AddRange(
                    new Book
                    {
                        Title = " Anna Karenina",
                        Author = " Leo Tolstoy",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Classic",
                        Price = 7.99M
                    },

                    new Book
                    {
                        Title = " War and Peace",
                        Author = "Leo Tolstoy",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Classic",
                        Price = 8.99M
                    },

                    new Book
                    {
                        Title = "Madame Bovary",
                        Author = "Gustave Flaubert",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Classic",
                        Price = 9.99M
                    },

                    new Book
                    {
                        Title = "The Great Gatsby",
                        Author = "F. Scott Fitzgerald",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Classic",
                        Price = 3.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}