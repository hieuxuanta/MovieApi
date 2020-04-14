﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAPI.Models
{
    public class Movie
    {
        public int MovID { get; set; }
        public string MovTitle { get; set; }
        public DateTime ReleaseDate { get; set; }

        public ICollection<Director> Directors { get; set; }
        public ICollection<Genre> Genres { get; set; }
    }
}