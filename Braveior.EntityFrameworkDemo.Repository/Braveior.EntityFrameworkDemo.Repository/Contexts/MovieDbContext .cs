using Braveior.EntityFrameworkDemo.Repository.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Braveior.EntityFrameworkDemo.Repository.Contexts
{
    public class MovieDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Data Source=.\\sqlexpress;User ID=sa;Password=password$$;Initial Catalog=moviedb");
        }

        public DbSet<Production> Productions { get; set; }
        public DbSet<Movie> Movies { get; set; }

        public DbSet<Series> Series { get; set; }
        public DbSet<Actor> Actors { get; set; }

        public DbSet<Character> Characters { get; set; }

        public DbSet<Rating> Ratings { get; set; }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            var movies = new Movie[] {
                new Movie { Id = 1, Name = "Fast & Furious", DurationInMinutes = 107, Release = new DateTime(2009, 4, 10) },
                new Movie { Id = 2, Name = "Wonder Woman ",  DurationInMinutes  = 141, Release = new DateTime(2017, 6, 1) },
                new Movie { Id = 3, Name = "Jumanji:Welcome To The Jungle",  DurationInMinutes = 119, Release = new DateTime(2017, 12, 20) },
                new Movie { Id = 4, Name = "Iron Man", DurationInMinutes = 126, Release = new DateTime(2008, 5, 2) },
                new Movie { Id = 5, Name = "X-Men-Dark Phoenix",  DurationInMinutes = 113, Release = new DateTime(2019, 6, 5 )}
            };
            var series = new Series[] {
                new Series { Id = 6 , Name = "WWF SmackDown", NumberOfEpisodes = 1127, Release = new DateTime(1999, 4, 27) },
                new Series { Id = 7 , Name = "Game Of Thrones", NumberOfEpisodes = 73, Release = new DateTime(2011, 4, 18) },
                new Series { Id = 8 , Name = "Survive", NumberOfEpisodes = 12 , Release = new DateTime(2020, 4, 6) },
                new Series { Id = 9, Name = "The Walking Dead", NumberOfEpisodes = 177 , Release = new DateTime(2010, 11, 5) },
                new Series { Id = 10 , Name = "Friends", NumberOfEpisodes = 235, Release = new DateTime(1995,4, 28) },

            };
            var productions = movies
                          .Cast<Production>()
                          .Union(series)
                          .ToList();


            var actors = new Actor[] {
                new Actor { Id = 1, Name = "Vin Diesel" },
                new Actor { Id = 2, Name = "Paul Walker" },
                new Actor { Id = 3, Name = "Gal Gadot" },
                new Actor { Id = 4, Name = "Chris Pine" },
                new Actor { Id = 5, Name = "Dwayne Johnson" },
                new Actor { Id = 6, Name = "Nick Jonas" },
                new Actor { Id = 7, Name = "Glen Jacobs" },
                new Actor { Id = 8, Name = "Robert Downey Jr" },
                new Actor { Id = 9, Name = "Gwyneth Paltrow" },
                new Actor { Id = 10, Name = "Sophie Turner" },
                new Actor { Id = 11, Name = "James McAvoy" },
                new Actor { Id = 12, Name = "Peter Dinklage" },
                new Actor { Id = 13, Name = "Corey Hawkins" },
                new Actor { Id = 14, Name = "Norman Reedus" },
                new Actor { Id = 15, Name = "Jennifer Aniston"},
                new Actor { Id = 16, Name = "Courteney Cox" },
                new Actor { Id = 17, Name = "Lisa Kudrow" }
            };


            var characters = new Character[] {
                new Character { Id = 1, Name = "Dominic Toretto", ProductionId = 1, ActorId = 1 },
                new Character { Id = 2, Name = "Brian o'Conner", ProductionId = 1, ActorId = 2 },
                new Character { Id = 3, Name = "Gisele", ProductionId = 1, ActorId = 3 },
                new Character { Id = 4, Name = "Diana Prince", ProductionId = 2, ActorId = 3 },
                new Character { Id = 5, Name = "Steve Trevor", ProductionId = 2, ActorId = 4 },
                new Character { Id = 6, Name = "Spencer", ProductionId = 3, ActorId = 5 },
                new Character { Id = 7, Name = "Alex", ProductionId = 3, ActorId = 6 },
                new Character { Id = 8, Name = "Tony Stark", ProductionId = 4, ActorId = 8 },
                new Character { Id = 9, Name = "Pepper Potts", ProductionId = 4, ActorId = 9 },
                new Character { Id = 10, Name = "Jean Grey/Phoenix", ProductionId = 5, ActorId = 10 },
                new Character { Id = 11, Name = "Professor Charles Xavier", ProductionId = 5, ActorId = 11 },
                new Character { Id = 12, Name = "The Rock", ProductionId = 6, ActorId = 5},
                new Character { Id = 13, Name = "Kane", ProductionId = 6, ActorId = 7 },
                new Character { Id = 14, Name = "Sansa Stark", ProductionId = 7, ActorId = 10 },
                new Character { Id = 15, Name = "Tyrion Lannister", ProductionId = 7, ActorId = 12 },
                new Character { Id = 16, Name = "Jane", ProductionId = 8, ActorId = 10 },
                new Character { Id = 17, Name = "Paul", ProductionId = 8, ActorId = 13 },
                new Character { Id = 18, Name = "Heath", ProductionId = 9, ActorId = 13 },
                new Character { Id = 19, Name = "Daryl Dixon", ProductionId = 9, ActorId = 14 },
                new Character { Id = 20, Name = "Rachel Green", ProductionId = 10, ActorId = 15 },
                new Character { Id = 21, Name = "Monica Geller", ProductionId = 10, ActorId = 16 },
                new Character { Id = 22, Name = "Phoebe Buffay", ProductionId = 10, ActorId = 17},
            };

            var users = new User[]
           {
                new User {Id=1, Name="John" , Email="john@outlook.com" , Password="password"},
                new User {Id=2, Name="Mark" , Email="mark@outlook.com" , Password="password" }
           };


            modelBuilder.Entity<User>().HasData(users);
            modelBuilder.Entity<Movie>().HasData(movies);
            modelBuilder.Entity<Series>().HasData(series);
            modelBuilder.Entity<Actor>().HasData(actors);
            modelBuilder.Entity<Character>().HasData(characters);


            // let's generate lots of ratings
            var random = new Random();
            var size = 100;
            var sources = new[] {
                "Internet",
                "Newspaper",
                "Magazine",
                "App"
            };
            List<Rating> ratings = new List<Rating>();
            for (int i = 0; i < productions.Count; ++i)
            {
                for (int j = i * size + 1; j <= size * (i + 1); ++j)
                {
                    ratings.Add(new Rating
                    {
                        Id = j,
                        ProductionId = productions[i].Id,
                        Stars = random.Next(1, 6),
                        Source = sources[random.Next(0, 4)]
                    });
                }
            }

            modelBuilder.Entity<Rating>().HasData(ratings);

            base.OnModelCreating(modelBuilder);
        }



    }
}
