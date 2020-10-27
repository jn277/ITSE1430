﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MovieLibrary
{
   public class ObjectValidator
    {
        public IEnumerable<ValidationResult> TryValidateFullObject ( IValidatableObject value )
        {
            var validationResults = new List<ValidationResult>();
            Validator.TryValidateObject(value, new ValidationContext(value), validationResults, true);

            return validationResults;
        }
    }
}
