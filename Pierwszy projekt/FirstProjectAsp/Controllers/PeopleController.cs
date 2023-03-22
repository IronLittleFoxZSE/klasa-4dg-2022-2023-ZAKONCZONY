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
        private PeopleDbContext peopleDbContext;// = new PeopleDbContext();

        public PeopleController(PeopleDbContext peopleDbContext)
        {
            this.peopleDbContext = peopleDbContext;
        }

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

            return RedirectToAction("ShowAllPersons");
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

        [HttpGet]
        public IActionResult EditPerson(int id)
        {
            PersonDto personDto = peopleDbContext.Persons
                .Where(x => x.Id == id)
                .Select(x => new PersonDto() 
                {
                Id = x.Id,
                Name = x.Name,
                Surname = x.Surname,
                Age = x.Age
                })
                .FirstOrDefault();
            return View(personDto);
        }

        [HttpPost]
        public IActionResult EditPerson(PersonDto personDto)
        {
            Person person = peopleDbContext.Persons.FirstOrDefault(x => x.Id == personDto.Id);

            if (person == null)
                return NotFound();

            person.Name = personDto.Name;
            person.Surname = personDto.Surname;
            person.Age = personDto.Age;
            peopleDbContext.SaveChanges();

            return RedirectToAction("ShowAllPersons");
        }

        public IActionResult DeletePerson(int id)
        {
            Person person = peopleDbContext.Persons.FirstOrDefault(x => x.Id == id);

            if (person == null)
                return NotFound();

            peopleDbContext.Persons.Remove(person);
            peopleDbContext.SaveChanges();

            return RedirectToAction("ShowAllPersons");
        }

        [HttpGet]
        public IActionResult SearchPerson([FromQuery]string name, [FromQuery] string surname)
        {
            List<PersonDto> newList = peopleDbContext.Persons
                .Where(x => string.IsNullOrWhiteSpace(name) || x.Name.Contains(name))
                .Where(x => string.IsNullOrWhiteSpace(surname) || x.Surname.Contains(surname))
                .Select(x => new PersonDto()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Surname = x.Surname,
                    Age = x.Age
                })
                .ToList();

            /*
            var newCollection = peopleDbContext.Persons.AsQueryable();
            if (!string.IsNullOrWhiteSpace(name))
                newCollection = newCollection.Where(x => x.Name.Contains(name));

            List<PersonDto> newList = newCollection.Select(x => new PersonDto()
            {
                Id = x.Id,
                Name = x.Name,
                Surname = x.Surname,
                Age = x.Age
            })
            .ToList();
            */

            return View(newList);
        }
    }
}
