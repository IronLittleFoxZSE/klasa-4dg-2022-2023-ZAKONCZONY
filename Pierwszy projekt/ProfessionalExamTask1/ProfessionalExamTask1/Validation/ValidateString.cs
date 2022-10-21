using ProfessionalExamTask1.Validation.TypesOfValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProfessionalExamTask1.Validation
{
    public class ValidateString: IValidationTypes
    {
        private string value;
        public string Name { get; set; }
        private List<ITypesOfValidation> typesOfValidationList; 

        public ValidateString(string value, string name, List<ITypesOfValidation> typesOfValidationList)
        {
            this.value = value;
            this.Name = name;
            this.typesOfValidationList = typesOfValidationList;
        }

        public bool Validate(out string message)
        {
            message = "";
            foreach(ITypesOfValidation typesOfValidation in typesOfValidationList)
            {
                if (!typesOfValidation.Validate(value, out message))
                {
                    message = Name + " : " + message;
                    return false;
                }
            }
            return true;
        }
    }
}
