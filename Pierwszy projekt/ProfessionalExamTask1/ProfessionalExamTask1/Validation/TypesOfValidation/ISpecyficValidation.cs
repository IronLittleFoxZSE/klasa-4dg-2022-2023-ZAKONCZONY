using System;
using System.Collections.Generic;
using System.Text;

namespace ProfessionalExamTask1.Validation.TypesOfValidation
{
    public interface ISpecyficValidation<T>
    {
        bool Validate(T value, out string message);
    }
}
