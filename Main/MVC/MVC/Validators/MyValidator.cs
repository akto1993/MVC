using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace MVC.Validators
{
    public class MyValidator : ValidationAttribute
    {
        private int maxLength = 300;
        private int minLength = 5;
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                string String = value.ToString();
                if (String.Count() > maxLength || String.Count() < minLength)
                {
                    return new ValidationResult("Length must be at last " + minLength + ". Maximum length is " + maxLength + ".");
                }
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("It can;t be empty");
            }
        }
    }
}