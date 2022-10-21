using System;
using System.Collections.Generic;
using System.Text;

namespace ProfessionalExamTask1.Validation
{
    class ValidateAge
    {
        private string age;

        public ValidateAge(string age)
        {
            this.age = age;
        }

        public bool Validate(out string message)
        {
            message = "";
            if (!ValidateAgeEmpty(age, out message))
                return false;
            if (!ValidateAgeIsNumber(age, out message))
                return false;
            if (!ValidateAgeIsRealAge(age, out message))
                return false;
            return true;
        }

        public bool ValidateAgeEmpty(string strAge, out string message)
        {
            message = "";
            if (string.IsNullOrWhiteSpace(strAge))
            {
                message = "Nie podano wieku";
                return false;
            }
            return true;
        }

        public bool ValidateAgeIsNumber(string strAge, out string message)
        {
            message = "";
            if (!int.TryParse(strAge, out int age))
            {
                message = "Podany wiek nie jest liczbą";
                return false;
            }
            return true;
        }

        public bool ValidateAgeIsRealAge(string strAge, out string message)
        {
            message = "";
            if (!int.TryParse(strAge, out int age) && (age < 0 || age > 200))
            {
                message = "Podany wiek jest spoza zakresu (0 ; 200)";
                return false;
            }
            return true;
        }
    }
}
