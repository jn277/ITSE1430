﻿/*
 * ITSE 1430
 * Donald Helaire
 * Lab4
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MovieLibrary
{
    public static class ObjectValidator
    {
        public static IEnumerable<ValidationResult> TryValidateFullObject ( IValidatableObject value )
        {
            var validationResults = new List<ValidationResult>();
            Validator.TryValidateObject(value, new ValidationContext(value), validationResults, true);

            return validationResults;
        }

        public static void ValidateFullObject ( IValidatableObject value )
        {
            Validator.ValidateObject(value, new ValidationContext(value), true);
        }
    }
}
