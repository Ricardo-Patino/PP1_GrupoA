using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PP1_GrupoA.Models;

namespace PP1_GrupoA.Controllers
{
    public class CarController : Controller
    {
        private List<Car> car = new List<Car>
        {
            new Car { Id = "1", Name = "Toyota", Description = "Sedan", DateCreated = DateTime.Now },
            new Car { Id = "2", Name = "Honda", Description = "SUV", DateCreated = DateTime.Now },
            new Car { Id = "3", Name = "Ford", Description = "Truck", DateCreated = DateTime.Now },
            new Car { Id = "4", Name = "Chevrolet", Description = "Coupe", DateCreated = DateTime.Now },
            new Car { Id = "5", Name = "BMW", Description = "Convertible", DateCreated = DateTime.Now },
            new Car { Id = "6", Name = "Mercedes", Description = "Luxury", DateCreated = DateTime.Now },
            new Car { Id = "7", Name = "Tesla", Description = "Electric", DateCreated = DateTime.Now },
            new Car { Id = "8", Name = "Mazda", Description = "Hatchback", DateCreated = DateTime.Now },
            new Car { Id = "9", Name = "Nissan", Description = "Crossover", DateCreated = DateTime.Now },
            new Car { Id = "10", Name = "Hyundai", Description = "Compact", DateCreated = DateTime.Now }
        };

    }
}