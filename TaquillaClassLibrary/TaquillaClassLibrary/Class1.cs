using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HorarioClassLibrary;
using PeliculaClassLibrary;

namespace TaquillaClassLibrary
{
    public class Taquilla
    {
        /// <summary>
        /// Clase Taquilla
        /// </summary>
        // atributos
        public List<Pelicula> PeliculasDisponibles { get; set; }

        public Taquilla()
        {
            PeliculasDisponibles = new List<Pelicula>();
        }

        public void AgregarPelicula(Pelicula pelicula)
        {
            PeliculasDisponibles.Add(pelicula);
        }

        public List<Pelicula> ObtenerPeliculasDisponibles()
        {
            return PeliculasDisponibles;
        }

        public List<Horario> ObtenerHorariosDisponibles(Pelicula pelicula)
        {
            return pelicula.HorariosDisponibles;
        }

        public bool ReservarAsientos(Pelicula pelicula, Horario horario, int cantidadAsientos)
        {
            foreach (Pelicula p in PeliculasDisponibles)
            {
                if (p == pelicula)
                {
                    foreach (Horario h in p.HorariosDisponibles)
                    {
                        if (h == horario && h.AsientosDisponibles >= cantidadAsientos)
                        {
                            h.AsientosDisponibles -= cantidadAsientos;
                            return true;
                        }
                    }
                }
            }
            return false;
        }
    }
}
