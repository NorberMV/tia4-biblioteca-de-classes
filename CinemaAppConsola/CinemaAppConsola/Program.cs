using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PeliculaClassLibrary;
using HorarioClassLibrary;
using TaquillaClassLibrary;

namespace CinemaAppConsola
{
    internal class Program
    {
        static void Main(string[] args)
        {   // Definir peliculas
            // Pelicula 1
            string Titulo1 = "Indiana Jones";
            string Descripcion1 = "Pelicula de accion, y aventura.";
            Pelicula Pelicula1 = new Pelicula(Titulo1, Descripcion1);

            // Pelicula 2
            string Titulo2 = "La Guardiana del Bosque";
            string Descripcion2 = "Pelicula de animacion, y aventura.";
            Pelicula Pelicula2 = new Pelicula(Titulo2, Descripcion2);

            Taquilla TaquillaCine = new Taquilla();
            // Anadir peliculas
            TaquillaCine.AgregarPelicula(Pelicula1);
            TaquillaCine.AgregarPelicula(Pelicula2);

            // Obtener Peliculas disponibles
            List<Pelicula> PeliculasDisponibles = TaquillaCine.ObtenerPeliculasDisponibles(); 
            for (int i = 0;i<PeliculasDisponibles.Count;i++)
            {
                Console.WriteLine(PeliculasDisponibles[i].Titulo);
            }
            Console.ReadKey();

        }
    }
}
