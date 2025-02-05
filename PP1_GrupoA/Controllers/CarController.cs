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
        private static List<Car> cars = new List<Car>
        {
            new Car { Id = "1", Nombre = "Toyota", Modelo = "Sedán", Año = "2000", Precio = "$5000", FechaCreacion = DateTime.Now },
            new Car { Id = "2", Nombre = "Honda", Modelo = "SUV", Año = "2010", Precio = "$5000", FechaCreacion = DateTime.Now },
            new Car { Id = "3", Nombre = "Ford", Modelo = "Camioneta", Año = "2005", Precio = "$5000", FechaCreacion = DateTime.Now },
            new Car { Id = "4", Nombre = "Chevrolet", Modelo = "Coupé", Año = "2003", Precio = "$5000", FechaCreacion = DateTime.Now },
            new Car { Id = "5", Nombre = "BMW", Modelo = "Convertible", Año = "2020", Precio = "$5000", FechaCreacion = DateTime.Now },
            new Car { Id = "6", Nombre = "Mercedes", Modelo = "Lujo", Año = "2015", Precio = "$5000", FechaCreacion = DateTime.Now },
            new Car { Id = "7", Nombre = "Tesla", Modelo = "Eléctrico", Año = "2025", Precio = "$100000", FechaCreacion = DateTime.Now },
            new Car { Id = "8", Nombre = "Mazda", Modelo = "Hatchback", Año = "2005", Precio = "$6000", FechaCreacion = DateTime.Now },
            new Car { Id = "9", Nombre = "Nissan", Modelo = "Crossover", Año = "2004", Precio = "$4000", FechaCreacion = DateTime.Now },
            new Car { Id = "10", Nombre = "Hyundai", Modelo = "Compacto", Año = "2000", Precio = "$5000", FechaCreacion = DateTime.Now }
        };

        [Route("cars/lista")]
        public ActionResult Index()
        {
            var cars = ObtenerTodosLosCars();
            return View(cars);
        }


        [Route("cars/create")]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route("cars/create")]
        public ActionResult Crear(Car car)
        {

            return View(car);
        }


        [Route("cars/detalles/{id}")]
        public ActionResult Detalles(string id)
        {
            var car = ObtenerCarPorId(id);
            if (car == null)
            {
                return View("CarNoEncontrado");
            }
            return View(car);
        }

        [HttpPost]
        [Route("cars/detalles/{id}")]
        public ActionResult Detalles(Car car)
        {
            if (ModelState.IsValid)
            {
                ActualizarCar(car);
            }
            return View(car);
        }

        private static List<Car> ObtenerTodosLosCars()
        {
            return cars;
        }

        private static Car ObtenerCarPorId(string id)
        {
            return cars.FirstOrDefault(c => c.Id == id);
        }

        private static void ActualizarCar(Car car)
        {
            var carExistente = ObtenerCarPorId(car.Id);
            if (carExistente != null)
            {
                carExistente.Marca = car.Marca;
                carExistente.Modelo = car.Modelo;
                carExistente.Año = car.Año;
                carExistente.Precio = car.Precio;
                carExistente.FechaCreacion = car.FechaCreacion;
            }
        }
    }
}