using System;
using System.Collections.Generic;
using System.Text;

namespace ProfessionalExamTask1.Validation
{
    public interface IValidationTypes
    {
        string Name { get; set; }
        bool Validate(out string message);
    }
}
