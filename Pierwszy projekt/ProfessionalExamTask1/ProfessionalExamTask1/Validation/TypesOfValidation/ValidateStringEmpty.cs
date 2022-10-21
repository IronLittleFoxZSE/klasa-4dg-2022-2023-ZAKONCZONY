using System;
using System.Collections.Generic;
using System.Text;

namespace ProfessionalExamTask1.Validation.TypesOfValidation
{
    public class ValidateStringEmpty: ITypesOfValidation
    {
        public bool Validate(string value, out string message)
        {
            message = "";
            if (string.IsNullOrWhiteSpace(value))
            {
                message = "Ciąg znaków jest pusty";
                return false;
            }
            return true;
        }
    }
}
