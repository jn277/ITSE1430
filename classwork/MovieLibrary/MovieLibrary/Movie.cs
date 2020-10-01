/*
 * ITSE 1430
 * Donald Helaire
 * Classwork
 */

using System;

namespace MovieLibrary
{
    //Type 
    //  Pascal cased
    //  Noun
    //  Singular unless they represent a collection of things
    // [access] class identifier { }

    // doctags

    /// <summary>Represents a movie.</summary>
    /// <remarks>
    /// A paragraph of information.
    /// Another set of information.
    /// </remarks>
    public class Movie
    {
        //Data - data to store

        //Fields - where the data is stored
        //string name;
        //Fields work identical to variables
        //Named as nouns, no abbreviations and no generic names
        public string Name = "";

        public string Description = "";
        public string Rating;
        public int RunLength;// = 0;
        public bool IsClassic; // = false;
        public int ReleaseYear = 1900;

        //Functionality - functions you want to expose

        /// <summary>Validates the movie instance.</summary>
        /// <returns>The error message, if any.</returns>
        public string Validate ( /*Movie this */ )
        {

            //Name is required
            if (String.IsNullOrEmpty(Name)) //this.Name
                return "Name is required";

            //Run length must be >= 0
            if (RunLength < 0)
                return "Run Length must be greater than or equal to 0";

            //Release Year must be >= 1900
            if (ReleaseYear < 1900)
                return "Release Year must be at least 1900";

            return null;
        }
    }

}

