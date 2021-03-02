using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//this is building the seed data to be inputted into the database
//we are creating new book objects and giving them attributes
//it also checks for any pending migrations

namespace Assignment5.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated (IApplicationBuilder application)
        {
            BookstoreDbContext context = application.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<BookstoreDbContext>();

            if(context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if(!context.Books.Any())
            {
                context.Books.AddRange(

                    new Book
                    {
                        
                        Title = "Les Miserables",
                        Author = "Victor Hugo",
                        Publisher = "Signet",
                        ISBN = "978-0451419439",
                        Classification = "Fiction",
                        Category = "Classic",
                        Price = 9.95,
                        NumPages = 1488

                    },

                    new Book
                    {
                        
                        Title = "Team of Rivals",
                        Author = "Doris Kearns Goodwin",
                        Publisher = "Simon & Schuster",
                        ISBN = "978-0743270755",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 15.58,
                        NumPages = 944

                    },

                    new Book
                    {
                        
                        Title = "The Snowball",
                        Author = "Alice Schroeder",
                        Publisher = "Bantam",
                        ISBN = "978-0553384611",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 21.54,
                        NumPages = 832

                    },

                    new Book
                    {
                        
                        Title = "American Ulysses",
                        Author = "Ronald C. White",
                        Publisher = "Random House",
                        ISBN = "978-0812981254",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 11.61,
                        NumPages = 864

                    },

                    new Book
                    {
                        
                        Title = "Unbroken",
                        Author = "Laura Hillenbrand",
                        Publisher = "Random House",
                        ISBN = "978-0812974492",
                        Classification = "Non-Fiction",
                        Category = "Historical",
                        Price = 13.33,
                        NumPages = 528

                    },

                    new Book
                    {
                        
                        Title = "The Great Train Robbery",
                        Author = "Michael Crichton",
                        Publisher = "Vintage",
                        ISBN = "978-0804171281",
                        Classification = "Fiction",
                        Category = "Historical Fiction",
                        Price = 15.95,
                        NumPages = 288

                    },

                    new Book
                    {
                        
                        Title = "Deep Work",
                        Author = "Cal Newport",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455586691",
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        Price = 14.99,
                        NumPages = 304

                    },


                    new Book
                    {
                        
                        Title = "It's Your Ship",
                        Author = "Michael Abrashoff",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455523023",
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        Price = 21.66,
                        NumPages = 240

                    },

                    new Book
                    {
                        
                        Title = "The Virgin Way",
                        Author = "Richard Branson",
                        Publisher = "Portfolio",
                        ISBN = "978-1591847984",
                        Classification = "Non-Fiction",
                        Category = "Business",
                        Price = 29.16,
                        NumPages = 400

                    },

                    new Book
                    {
                        
                        Title = "Sycamore Row",
                        Author = "John Grisham",
                        Publisher = "Bantam",
                        ISBN = "978-0553393613",
                        Classification = "Fiction",
                        Category = "Thriller",
                        Price = 15.03,
                        NumPages = 642

                    },

                    new Book
                    {

                        Title = "Harry Potter and the Deathly Hallows",
                        Author = "J.K. Rowling",
                        Publisher = "Bloomsbury Publishing",
                        ISBN = "978-0545029377",
                        Classification = "Fiction",
                        Category = "Mystery",
                        Price = 13.86,
                        NumPages = 607

                    },

                    new Book
                    {

                        Title = "The Westing Game",
                        Author = "Ellen Raskin",
                        Publisher = "Puffin Books",
                        ISBN = "978-0142401200",
                        Classification = "Fiction",
                        Category = "Mystery",
                        Price = 7.99,
                        NumPages = 216

                    },

                    new Book
                    {

                        Title = "The Infinite Atonement",
                        Author = "Tad R. Callister",
                        Publisher = "Deseret Book Co",
                        ISBN = "978-1573456234",
                        Classification = "Non-Fiction",
                        Category = "Religious",
                        Price = 24.99,
                        NumPages = 356

                    }


                 );

                context.SaveChanges();
            }
        }
    }
}
