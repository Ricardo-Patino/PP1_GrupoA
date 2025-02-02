using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PP1_GrupoA.Models
{
    public class Job
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string Estado { get; set; }
        public DateTime FechaModificacion { get; set; }

        public void ActualizarEstado(string nuevoEstado)
        {
            Estado = nuevoEstado;
            FechaModificacion = DateTime.Now;
        }
    }
}