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
            new Person { Id = "1", Nombre = "Alice", Apellido = "Ramos", Descripcion = "Ingeniera", Email = "ejemplo1@mail.com", Telefono = "(555) 123-4567", FechaCreacion = DateTime.Now },
            new Person { Id = "2", Nombre = "Bob", Apellido = "Fonseca",Descripcion = "Doctor", Email = "prueba2@mail.com", Telefono = "(555) 987-6543", FechaCreacion = DateTime.Now },
            new Person { Id = "3", Nombre = "Charlie",Apellido = "Castro", Descripcion = "Artista", Email = "usuario3@mail.com", Telefono = "(555) 654-3210", FechaCreacion = DateTime.Now },
            new Person { Id = "4", Nombre = "David", Apellido = "Pacheco",Descripcion = "Músico", Email = "ficticio4@mail.com", Telefono = "(555) 321-0987", FechaCreacion = DateTime.Now },
            new Person { Id = "5", Nombre = "Emma", Apellido = "Brown",Descripcion = "Diseñadora", Email = "correo5@mail.com", Telefono = "(555) 567-1234", FechaCreacion = DateTime.Now },
            new Person { Id = "6", Nombre = "Frank", Apellido = "Arce", Descripcion = "Escritor",Email = "demo6@mail.com", Telefono = "(555) 432-8765",  FechaCreacion = DateTime.Now },
            new Person { Id = "7", Nombre = "Grace", Apellido = "Vega", Descripcion = "Fotógrafa", Email = "test7@mail.com", Telefono = "(555) 789-6540", FechaCreacion = DateTime.Now },
            new Person { Id = "8", Nombre = "Hank", Apellido = "Ramirez", Descripcion = "Chef", Email = "cuenta8@mail.com", Telefono = "(555) 345-6789", FechaCreacion = DateTime.Now },
            new Person { Id = "9", Nombre = "Ivy", Apellido = "Benavidez",Descripcion = "Enfermera", Email = "ejemplo9@mail.com", Telefono = "(555) 876-5432", FechaCreacion = DateTime.Now },
            new Person { Id = "10", Nombre = "Jack", Apellido = "Chavez",Descripcion = "Científico",Email = "ficticio10@mail.com", Telefono = "(555) 210-9876",  FechaCreacion = DateTime.Now }
        };

        [Route("persons/lista")]
        public ActionResult Index()
        {
            var persons = ObtenerTodasLasPersons();
            return View(persons);
        }


        [Route("persons/create")]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route("persons/create")]
        public ActionResult Crear(Person person)
        {
            if (ModelState.IsValid)
            {
                int nuevoId = persons.Count > 0 ? persons.Max(c => int.Parse(c.Id)) + 1 : 1;
                person.Id = nuevoId.ToString();

                persons.Add(person);

                return RedirectToAction("Index");
            }

            return View(person);
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
                personExistente.Apellido = person.Apellido;
                personExistente.Descripcion = person.Descripcion;
                personExistente.FechaCreacion = person.FechaCreacion;
            }
        }
    }
}
