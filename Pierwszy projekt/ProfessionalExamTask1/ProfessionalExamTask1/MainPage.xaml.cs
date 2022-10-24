using ProfessionalExamTask1.Validation;
using ProfessionalExamTask1.Validation.TypesOfValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ProfessionalExamTask1
{
    public partial class MainPage : ContentPage
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set 
            { 
                _name = value;
                OnPropertyChanged();
            }
        }

        private string _strAge;
        public string StrAge
        {
            get { return _strAge; }
            set 
            { 
                _strAge = value;
                OnPropertyChanged();
            }
        }

        private string _helloMessage;
        public string HelloMessage
        {
            get { return _helloMessage; }
            set 
            { 
                _helloMessage = value;
                OnPropertyChanged();
            }
        }

        private string _legalAgeMessage;
        public string LegalAgeMessage
        {
            get { return _legalAgeMessage; }
            set 
            { 
                _legalAgeMessage = value;
                OnPropertyChanged();
            }
        }

        private bool _visibleErrorName;
        public bool VisibleErrorName
        {
            get { return _visibleErrorName; }
            set 
            { 
                _visibleErrorName = value;
                OnPropertyChanged();
            }
        }

        private string _messageErrorName;
        public string MessageErrorName
        {
            get { return _messageErrorName; }
            set
            {
                _messageErrorName = value;
                OnPropertyChanged();
                VisibleErrorName = !string.IsNullOrEmpty(_messageErrorName);
            }
        }

        private string _messageErrorAge;
        public string MessageErrorAge
        {
            get { return _messageErrorAge; }
            set 
            {
                _messageErrorAge = value;
                OnPropertyChanged();
                VisibleErrorAge = !string.IsNullOrEmpty(_messageErrorAge);
            }
        }

        private bool _visibleErrorAge;
        public bool VisibleErrorAge
        {
            get { return _visibleErrorAge; }
            set
            {
                _visibleErrorAge = value;
                OnPropertyChanged();
            }
        }

        private ICommand _commandCheckBinding;
        public ICommand CommandCheckBinding
        {
            get 
            { 
                if (_commandCheckBinding == null)
                {
                    _commandCheckBinding = new Command(() =>
                    {
                        Validate validate = new Validate();
                        validate.AddValidator(new Validator<string>(Name, "Imie",
                            new List<Validation.TypesOfValidation.ISpecyficValidation<string>>()
                            {
                                new ValidateStringEmpty()
                            }));
                        validate.AddValidator(new Validator<string>(StrAge, "Wiek",
                            new List<Validation.TypesOfValidation.ISpecyficValidation<string>>()
                            {
                                new ValidateStringEmpty(),
                                new ValidateStringIsNumber(),
                                new ValidateStringNumberIsInRange(1,150)
                            }));

                        if (!validate.Validation(out string message))
                        {
                            HelloMessage = message;
                            LegalAgeMessage = "";
                            return;
                        }

                        HelloMessage = "Witaj " + Name;
                        LegalAgeMessage = ConvertAgeStringToInt(StrAge) >= 18 ? "Pełnoletni" : "Niepełnoletni";
                    });
                }
                return _commandCheckBinding; 
            }
            set { _commandCheckBinding = value; }
        }

        private ICommand _commandCheckBindingAllErrors;
        public ICommand CommandCheckBindingAllErrors
        {
            get
            {
                if (_commandCheckBindingAllErrors == null)
                {
                    _commandCheckBindingAllErrors = new Command(() =>
                    {
                        MessageErrorName = "";
                        MessageErrorAge = "";

                        HelloMessage = "";
                        LegalAgeMessage = "";

                        Validate validate = new Validate();

                        validate.AddValidator(new Validator<string>(Name, "Imie",
                            new List<Validation.TypesOfValidation.ISpecyficValidation<string>>()
                            {
                                new ValidateStringEmpty()
                            }));

                        validate.AddValidator(new Validator<string>(StrAge, "Wiek",
                            new List<Validation.TypesOfValidation.ISpecyficValidation<string>>()
                            {
                                new ValidateStringEmpty(),
                                new ValidateStringIsNumber(),
                                new ValidateStringNumberIsInRange(1,150)
                            }));

                        if (!validate.Validation(out Dictionary<string,string> dictionaryMessages))
                        {
                            if (dictionaryMessages.ContainsKey("Imie"))
                                MessageErrorName = dictionaryMessages["Imie"];
                            if (dictionaryMessages.ContainsKey("Wiek"))
                                MessageErrorAge = dictionaryMessages["Wiek"];

                            return;
                        }

                        HelloMessage = "Witaj " + Name;
                        LegalAgeMessage = ConvertAgeStringToInt(StrAge) >= 18 ? "Pełnoletni" : "Niepełnoletni";
                    });
                }
                return _commandCheckBindingAllErrors;
            }
            set { _commandCheckBindingAllErrors = value; }
        }

        public MainPage()
        {
            InitializeComponent();
        }

        public int ConvertAgeStringToInt(string strAge)
        {
            return int.Parse(strAge);
        }

        private void buttonCheck_Clicked(object sender, EventArgs e)
        {
            string name = entryName.Text;
            string strAge = entryAge.Text;

            Validate validate = new Validate();

            validate.AddValidator(new Validator<string>(name, "Imie",
                new List<ISpecyficValidation<string>>()
                {
                    new ValidateStringEmpty()
                }));

            validate.AddValidator(new Validator<string>(strAge, "Wiek",
                new List<ISpecyficValidation<string>>()
                {
                    new ValidateStringEmpty(),
                    new ValidateStringIsNumber(),
                    new ValidateStringNumberIsInRange(1,150)
                }));

            if (!validate.Validation(out string message))
            {
                labelHello.Text = message;
                labelLegalAge.Text = "";
                return;
            }

            labelHello.Text = "Witaj " + name;
            labelLegalAge.Text = ConvertAgeStringToInt(strAge) >= 18 ? "Pełnoletni" : "Niepełnoletni";
        }
    }
}