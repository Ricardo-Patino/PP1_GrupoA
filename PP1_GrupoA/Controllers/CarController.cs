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
            new Car { Id = "1", Nombre = "Toyota", Descripcion = "Sedán", FechaCreacion = DateTime.Now },
            new Car { Id = "2", Nombre = "Honda", Descripcion = "SUV", FechaCreacion = DateTime.Now },
            new Car { Id = "3", Nombre = "Ford", Descripcion = "Camioneta", FechaCreacion = DateTime.Now },
            new Car { Id = "4", Nombre = "Chevrolet", Descripcion = "Coupé", FechaCreacion = DateTime.Now },
            new Car { Id = "5", Nombre = "BMW", Descripcion = "Convertible", FechaCreacion = DateTime.Now },
            new Car { Id = "6", Nombre = "Mercedes", Descripcion = "Lujo", FechaCreacion = DateTime.Now },
            new Car { Id = "7", Nombre = "Tesla", Descripcion = "Eléctrico", FechaCreacion = DateTime.Now },
            new Car { Id = "8", Nombre = "Mazda", Descripcion = "Hatchback", FechaCreacion = DateTime.Now },
            new Car { Id = "9", Nombre = "Nissan", Descripcion = "Crossover", FechaCreacion = DateTime.Now },
            new Car { Id = "10", Nombre = "Hyundai", Descripcion = "Compacto", FechaCreacion = DateTime.Now }
        };

        [Route("cars/lista")]
        public ActionResult Index()
        {
            var cars = ObtenerTodosLosCars();
            return View(cars);
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
                carExistente.Nombre = car.Nombre;
                carExistente.Descripcion = car.Descripcion;
                carExistente.FechaCreacion = car.FechaCreacion;
            }
        }
    }
}