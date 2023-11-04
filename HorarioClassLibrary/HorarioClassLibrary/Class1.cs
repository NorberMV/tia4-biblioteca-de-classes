using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorarioClassLibrary
{
    public class Horario
    {
        /// <summary>
        /// Clase Horario
        /// </summary>
        // atributos
        public DateTime Hora { get; set; }
        public int AsientosDisponibles { get; set; }

        public Horario(DateTime hora, int asientosDisponibles)
        {
            Hora = hora;
            AsientosDisponibles = asientosDisponibles;
        }
    }
}
