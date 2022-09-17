using System;
using System.ComponentModel.DataAnnotations;

namespace Journal 
{
    public class FutureDate : validationAttribute 
    {
        protected override validationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return ValidationResult.Success;
            }
        }
        DateTime date = (DateTime)value;

        if (date <= DateTime.Now)
        {
            return new ValidationResult("must be in the future")
        }
        return ValidationResult.Success;
    }
}