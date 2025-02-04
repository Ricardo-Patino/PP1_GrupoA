using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PP1_GrupoA.Models;

namespace PP1_GrupoA.Controllers
{
    public class PersonController : Controller
    {
        private static List<Person> persons = new List<Person>
        {
            new Person { Id = "1", Nombre = "Alice", Descripcion = "Ingeniera", FechaCreacion = DateTime.Now },
            new Person { Id = "2", Nombre = "Bob", Descripcion = "Doctor", FechaCreacion = DateTime.Now },
            new Person { Id = "3", Nombre = "Charlie", Descripcion = "Artista", FechaCreacion = DateTime.Now },
            new Person { Id = "4", Nombre = "David", Descripcion = "Músico", FechaCreacion = DateTime.Now },
            new Person { Id = "5", Nombre = "Emma", Descripcion = "Diseñadora", FechaCreacion = DateTime.Now },
            new Person { Id = "6", Nombre = "Frank", Descripcion = "Escritor", FechaCreacion = DateTime.Now },
            new Person { Id = "7", Nombre = "Grace", Descripcion = "Fotógrafa", FechaCreacion = DateTime.Now },
            new Person { Id = "8", Nombre = "Hank", Descripcion = "Chef", FechaCreacion = DateTime.Now },
            new Person { Id = "9", Nombre = "Ivy", Descripcion = "Enfermera", FechaCreacion = DateTime.Now },
            new Person { Id = "10", Nombre = "Jack", Descripcion = "Científico", FechaCreacion = DateTime.Now }
        };

        [Route("persons/lista")]
        public ActionResult Index()
        {
            var persons = ObtenerTodasLasPersons();
            return View(persons);
        }

        [Route("persons/detalles/{id}")]
        public ActionResult Detalles(string id)
        {
            var person = ObtenerPersonPorId(id);
            if (person == null)
            {
                return View("PersonNoEncontrada");
            }
            return View(person);
        }

        [HttpPost]
        [Route("persons/detalles/{id}")]
        public ActionResult Detalles(Person person)
        {
            if (ModelState.IsValid)
            {
                ActualizarPerson(person);
            }
            return View(person);
        }

        private static List<Person> ObtenerTodasLasPersons()
        {
            return persons;
        }

        private static Person ObtenerPersonPorId(string id)
        {
            return persons.FirstOrDefault(p => p.Id == id);
        }

        private static void ActualizarPerson(Person person)
        {
            var personExistente = ObtenerPersonPorId(person.Id);
            if (personExistente != null)
            {
                personExistente.Nombre = person.Nombre;
                personExistente.Descripcion = person.Descripcion;
                personExistente.FechaCreacion = person.FechaCreacion;
            }
        }
    }
}
