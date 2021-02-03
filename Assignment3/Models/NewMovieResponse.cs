using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment3.Models
{
    public class NewMovieResponse
    {
        [Required(ErrorMessage = "Category Required")]
        public string Category { get; set; }
        [Required(ErrorMessage = "Title Required")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Year Required")]
        public int Year { get; set; }
        [Required(ErrorMessage = "Director Required")]
        public string Director { get; set; }
        [Required(ErrorMessage = "Rating Required")]
        public string Rating { get; set; }
        public bool? Edited { get; set; }
        public string LentTo { get; set; }
        [StringLength(25,ErrorMessage= "Can only be a maximum of 25 characters")]
        public string Notes { get; set; }
    }
}
