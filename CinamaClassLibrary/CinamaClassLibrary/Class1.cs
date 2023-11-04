using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HorarioClassLibrary;

namespace PeliculaClassLibrary
{
    public class Pelicula
    {   
        /// <summary>
        /// Clase Pelicula
        /// </summary>
        // atributos
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public List<Horario> HorariosDisponibles { get; set; }
        public Pelicula(string titulo, string descripcion)
        {
            Titulo = titulo;
            Descripcion = descripcion;
            HorariosDisponibles = new List<Horario>();
        }

    }
}
