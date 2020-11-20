/*
 * ITSE 1430
 * Donald Helaire
 * Lab4
 */

using System;
using System.Collections.Generic;

using CharacterCreator;

namespace MovieLibrary
{
    public static class ObjectValidator
    {
        public static IEnumerable<ValidationResult> TryValidateFullObject ( IValidatableObject value )
        {
            var validationResults = new List<ValidationResult>();
            object p = Validator.TryValidateObject(value, new ValidationContext(value), validationResults, true);

            return validationResults;
        }

        public static void ValidateFullObject ( IValidatableObject value )
        {
            Validator.ValidateObject(value, new ValidationContext(value), true);
        }
    }

    internal class ValidationContext
    {
        private IValidatableObject value;

        public ValidationContext ( IValidatableObject value )
        {
            this.value=value;
        }
    }

    internal class Validator
    {
        internal static object TryValidateObject ( IValidatableObject value, ValidationContext validationContext, List<ValidationResult> validationResults, bool v )
        {
            throw new NotImplementedException();
        }

        internal static void ValidateObject ( IValidatableObject value, ValidationContext validationContext, bool v )
        {
            throw new NotImplementedException();
        }
    }

    public class ValidationResult
    {
    }
}
