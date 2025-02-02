using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PP1_GrupoA.Models;

namespace PP1_GrupoA.Controllers
{
    public class JobController : Controller
    {
        private static List<Job> jobs = new List<Job>
        {
            new Job { Id = "1", Nombre = "Desarrollador de Software", Descripcion = "Escribe código", FechaCreacion = DateTime.Now },
            new Job { Id = "2", Nombre = "Profesor", Descripcion = "Enseña a los estudiantes", FechaCreacion = DateTime.Now },
            new Job { Id = "3", Nombre = "Doctor", Descripcion = "Trata a los pacientes", FechaCreacion = DateTime.Now },
            new Job { Id = "4", Nombre = "Piloto", Descripcion = "Vuela aviones", FechaCreacion = DateTime.Now },
            new Job { Id = "5", Nombre = "Arquitecto", Descripcion = "Diseña edificios", FechaCreacion = DateTime.Now },
            new Job { Id = "6", Nombre = "Chef", Descripcion = "Prepara comida", FechaCreacion = DateTime.Now },
            new Job { Id = "7", Nombre = "Bombero", Descripcion = "Rescata personas", FechaCreacion = DateTime.Now },
            new Job { Id = "8", Nombre = "Fotógrafo", Descripcion = "Captura momentos", FechaCreacion = DateTime.Now },
            new Job { Id = "9", Nombre = "Ingeniero", Descripcion = "Construye soluciones", FechaCreacion = DateTime.Now },
            new Job { Id = "10", Nombre = "Artista", Descripcion = "Crea arte", FechaCreacion = DateTime.Now }
        };

        [Route("jobs/lista")]
        public ActionResult Lista()
        {
            var jobs = ObtenerTodosLosJobs();
            return View(jobs);
        }

        [Route("jobs/detalles/{id}")]
        public ActionResult Detalles(string id)
        {
            var job = ObtenerJobPorId(id);
            if (job == null)
            {
                return View("JobNoEncontrado");
            }
            return View(job);
        }

        [HttpPost]
        [Route("jobs/detalles/{id}")]
        public ActionResult Detalles(Job job)
        {
            if (ModelState.IsValid)
            {
                ActualizarJob(job);
            }
            return View(job);
        }

        private static List<Job> ObtenerTodosLosJobs()
        {
            return jobs;
        }

        private static Job ObtenerJobPorId(string id)
        {
            return jobs.FirstOrDefault(j => j.Id == id);
        }

        private static void ActualizarJob(Job job)
        {
            var jobExistente = ObtenerJobPorId(job.Id);
            if (jobExistente != null)
            {
                jobExistente.Nombre = job.Nombre;
                jobExistente.Descripcion = job.Descripcion;
                jobExistente.FechaCreacion = job.FechaCreacion;
            }
        }
    }
}