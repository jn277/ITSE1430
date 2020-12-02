/*
 * ITSE 1430
 * Donald Helaire
 * Lab5
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CharacterRoster.Web.Models
{
    public class CharacterModel
    {
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false)]
        [StringLength(CharacterCreator.MaximumNameLength)]
        public string Name { get; set; }

        [StringLength(Movie.MaximumNameLength)]
        public string Description { get; set; }

        public string Rating { get; set; }
        [Range(0, Int32.MaxValue, ErrorMessage = "Run length must be greater than or equal to 0.")]
        public int RunLength { get; set; }

        [Range(1900, 2100)]
        public int ReleaseYear { get; set; }
        public bool IsClassic { get; set; }

    }
}