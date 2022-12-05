using FirstProjectAsp.Database.Context;
using FirstProjectAsp.Database.Entities;
using FirstProjectAsp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstProjectAsp.Controllers
{
    public class PeopleController : Controller
    {
        private PeopleDbContext peopleDbContext = new PeopleDbContext();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreatePerson()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreatePerson(PersonDto personDto)
        {
            peopleDbContext.Add(new Person()
            {
                Name = personDto.Name,
                Surname = personDto.Surname,
                Age = personDto.Age
            });
            peopleDbContext.SaveChanges();

            return View("Index");
        }

        public IActionResult ShowAllPersons()
        {
            List<PersonDto> allPersonsList = peopleDbContext.Persons.
                Select(p => new PersonDto() 
                {
                    Id = p.Id,
                    Name = p.Name,
                    Surname = p.Surname,
                    Age = p.Age
                }).ToList();


            return View(allPersonsList);
        }


        //-----------------------------------------------------------------------------

        public IActionResult ViewPerson()
        {
            PersonDto person = new PersonDto()
            {
                Name="Jan",
                Surname = "Kowalski",
                Age = 19
            };

            return View(person);
        }

        //[HttpPost]
        public IActionResult EditPerson([FromBody]PersonDto person)
        {
            
            return View(person);
        }
    }
}
