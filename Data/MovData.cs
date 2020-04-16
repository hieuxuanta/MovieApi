using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MovieAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAPI.Data
{
    public class MovData
    {
        public static void Initialize(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<MovieContext>();
                context.Database.EnsureCreated();
                //context.Database.Migrate();

                if (context.Directors != null && context.Directors.Any())
                    return;

                var directors = GetDirectors().ToArray();
                context.Directors.AddRange(directors);
                context.SaveChanges();

                var genres = GetGenres().ToArray();
                context.Genres.AddRange(genres);
                context.SaveChanges();

                var movies = GetMovies(context).ToArray();
                context.Movies.AddRange(movies);
                context.SaveChanges();
            }
        }
        public static List<Director> GetDirectors()
        {
            List<Director> directors = new List<Director>() { 
                new Director {DirID = "D01",DirName = "Robert B. Weide"},
                new Director {DirID = "D02",DirName = "Mike Shinoda"},
                new Director {DirID = "D04",DirName = "EliGE"},
                new Director {DirID = "D05",DirName = "Le nguyen trung dan"}
            };
            return directors;
        }
        public static List<Genre> GetGenres()
        {
            List<Genre> genres = new List<Genre>() { 
                new Genre {GenreID = "HOR001",GenreType = "Horror"},
                new Genre {GenreID = "ROM002",GenreType = "Romance"},
                new Genre {GenreID = "ANM004",GenreType = "Anime"},
                new Genre {GenreID = "SCI005",GenreType = "Science"},
                new Genre {GenreID = "SPR006",GenreType = "Spirit"}
            };
            return genres;
        }
        public static List<Movie> GetMovies(MovieContext db)
        {
            List<Movie> movies = new List<Movie>() {
                new Movie
                {
                    MovID = "M001",
                    MovTitle = "The Wolf of Wall Street",
                    ReleaseYear = "2013",
                    Directors = new List<Director>(db.Directors.Take(1)),
                    Genres = new List<Genre>(db.Genres.Take(2))
                },
                new Movie
                {
                    MovID = "M002",
                    MovTitle = "Paranomal Activity",
                    ReleaseYear = "2006",
                    Directors = new List<Director>(db.Directors.Skip(1).Take(1)),
                    Genres = new List<Genre>(db.Genres.Skip(3).Take(2))
                },
                new Movie
                {
                    MovID = "M003",
                    MovTitle = "We Escape:The Experiment",
                    ReleaseYear = "2020",
                    Directors = new List<Director>(db.Directors.Skip(2).Take(1)),
                    Genres = new List<Genre>(db.Genres.Skip(2).Take(2))
                },
            };
            return movies;
        }
    }
}
