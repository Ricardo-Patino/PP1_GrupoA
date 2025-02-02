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
        private List<Person> person = new List<Person>
        {
            new Person { Id = "1", Name = "Alice", Description = "Engineer", DateCreated = DateTime.Now },
            new Person { Id = "2", Name = "Bob", Description = "Doctor", DateCreated = DateTime.Now },
            new Person { Id = "3", Name = "Charlie", Description = "Artist", DateCreated = DateTime.Now },
            new Person { Id = "4", Name = "David", Description = "Musician", DateCreated = DateTime.Now },
            new Person { Id = "5", Name = "Emma", Description = "Designer", DateCreated = DateTime.Now },
            new Person { Id = "6", Name = "Frank", Description = "Writer", DateCreated = DateTime.Now },
            new Person { Id = "7", Name = "Grace", Description = "Photographer", DateCreated = DateTime.Now },
            new Person { Id = "8", Name = "Hank", Description = "Chef", DateCreated = DateTime.Now },
            new Person { Id = "9", Name = "Ivy", Description = "Nurse", DateCreated = DateTime.Now },
            new Person { Id = "10", Name = "Jack", Description = "Scientist", DateCreated = DateTime.Now }
        };


    }
}
