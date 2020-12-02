/*
 * ITSE 1430
 * Donald Helaire
 * Lab4
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MovieLibrary.WebHost.Models
{
    public class MovieModel // : IValidatableObject
    {
        //Metadata - data about data

        public int Id { get; set; }

        //Attributes are metadata 
        // [][]- multiple attributes
        // [XAttribute()], [XAttribute], [X]
        // Attribute may be limited to certain types or members

        // Required - value cannot be null
        //[RequiredAttribute()]
        //[RequiredAttribute]
        [Required(AllowEmptyStrings = false)]
        [StringLength(Movie.MaximumNameLength)]
        public string Name { get; set; }

        [StringLength(Movie.MaximumNameLength)]
        public string Description { get; set; }

        public string Rating { get; set; }

        //Range enforces a min, max value
        [Range(0, Int32.MaxValue, ErrorMessage = "Run length must be greater than or equal to 0.")]
        public int RunLength { get; set; }

        [Range(1900, 2100)]
        public int ReleaseYear { get; set; }
        public bool IsClassic { get; set; }
    }
}




