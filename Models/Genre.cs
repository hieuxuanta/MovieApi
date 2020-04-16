using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAPI.Models
{
    public class Genre
    {
        [Key]
        public string GenreID { get; set; }
        public string GenreType { get; set; }
    }
}
