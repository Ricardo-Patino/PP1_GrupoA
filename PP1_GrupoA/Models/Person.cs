using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PP1_GrupoA.Models
{
    public class Person
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string edad { get; set; }
        public DateTime FechaCreacion { get; set; }

        public int CalcularEdad()
        {
            int edad = DateTime.Now.Year - FechaNacimiento.Year;
            if (DateTime.Now.DayOfYear < FechaNacimiento.DayOfYear){
                edad = edad - 1;
            }
            return edad;
        }
    }
}