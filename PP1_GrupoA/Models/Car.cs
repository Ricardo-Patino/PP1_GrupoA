using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PP1_GrupoA.Models
{
    public class Car
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Año { get; set; }
        public decimal Precio { get; set; }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Descripcion: {Descripcion}");
            Console.WriteLine($"Fecha de Creacion: {FechaCreacion}");
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Año: {Año}");
            Console.WriteLine($"Precio: {Precio}");
        }
    }
}