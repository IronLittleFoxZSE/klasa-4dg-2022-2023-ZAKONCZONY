using System;
using System.Collections.Generic;
using System.Text;

namespace ProfessionalExamTask1.Validation.TypesOfValidation
{
    public interface ITypesOfValidation
    {
        bool Validate(string value, out string message);
    }
}
