using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Journal.Models;

namespace Journal 
{
    public class FutureDate : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            // Because our Date field is optional, can't convert null to date.
            if (value == null)
            {
                return ValidationResult.Success;
            }

            DateTime date = (DateTime)value;

            if (date <= DateTime.Now)
            {
                return new ValidationResult("must be in the future.");
            }
            return ValidationResult.Success;
        }
    }   

    public class UniqueEmail : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            JournalContext db = (JournalContext)validationContext
                .GetService(typeof(JournalContext));

            User user = db.Users.FirstOrDefault(u => u.Email == (string)value);

            if (user != null)
            {
                return new ValidationResult("Email already taken");
            }

            return ValidationResult.Success;
        }
    }
}