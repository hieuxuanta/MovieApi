using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAPI.Models
{
    public class Director
    {
        [Key]
        public string DirID { get; set; }
        public string DirName { get; set; }
    }
}
