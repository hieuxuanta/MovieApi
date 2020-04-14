using MovieAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAPI.Data
{
    public class MovData
    {
        public static List<Director> GetDirectors()
        {
            List<Director> directors = new List<Director>() { 
                new Director {DirID = "D01",DirName = "Robert B. Weide"},
                new Director {DirID = "D02",DirName = "Mike Shinoda"},
                new Director {DirID = "D04",DirName = "EliGE"}
            };
            return directors;
        }
        public static List<Genre> GetGenres()
        {
            List<Genre> genres = new List<Genre>() { 
                new Genre {GenreID = "HOR001",GenreType = "Horror"},
                new Genre {GenreID = "ROM035",GenreType = "Romantic"},
                new Genre {GenreID = "ANM012",GenreType = "Anime"}
            };
            return genres;
        }
        public static List<Movie> GetMovies()
    }
}
