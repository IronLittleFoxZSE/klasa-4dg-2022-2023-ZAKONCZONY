﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FirstProjectAsp.Models
{
    public class PersonDto
    {
        public int Id { get; set; }
        [Display(Name = "Imię:")]
        public string Name { get; set; }
        [Display(Name = "Nazwisko:")]
        public string Surname { get; set; }
        [Display(Name ="Wiek osoby:")]
        public int Age { get; set; }
    }
}
