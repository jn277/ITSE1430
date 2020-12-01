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

    public class MovieModel : IValidatableObject
    {
        public const int MaximumNameLength = 50;

        public readonly int MaximumDescriptionLength = 200;
        public int Age
        {
            get { return DateTime.Now.Year - ReleaseYear; }
        }
        public int Id { get; set; }
        public string Name
        {
            get {
                return _name ?? "";
                }
            set {
                _name = value;
                }
        }
        private string _name = "";
        public string Description
        {
            get { return _description ?? ""; }
            set { _description = value; }
        }
        private string _description = "";
        public string Rating
        {
            get { return _rating ?? ""; }
            set { _rating = value; }
        }
        private string _rating;
        public int RunLength { get; set; }
        public int ReleaseYear { get; set; } = 1900;
        public bool IsClassic { get; set; }
        public override string ToString ( )  
        {
            return Name;
        }

        public IEnumerable<ValidationResult> Validate ( ValidationContext validationContext )
        {
            if (String.IsNullOrEmpty(Name))
                yield return new ValidationResult("Name is required", new[] { nameof(Name) });

            if (RunLength < 0)
                yield return new ValidationResult("Run Length must be greater than or equal to 0", new[] { nameof(RunLength) });

            if (ReleaseYear < 1900)
                yield return new ValidationResult("Release Year must be at least 1900", new[] { nameof(ReleaseYear) });
        }
    }
}



