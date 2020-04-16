using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAPI.Models
{
    public class Movie
    {
        [Key]
        public string MovID { get; set; }
        public string MovTitle { get; set; }
        //[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd.MM.yyyy}")]
        public string ReleaseYear { get; set; }

        public ICollection<Director> Directors { get; set; }
        public ICollection<Genre> Genres { get; set; }
    }
}
