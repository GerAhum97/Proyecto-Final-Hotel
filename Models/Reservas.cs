using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelTrabajoFinal.Models
{
    public class Reservas
    {
        public int Id { get; set; }
        public string Nombre { get; set;}
        public string Apellido { get; set;}
        public string NombreHabitacion { get; set;}
        public DateTime FechaIngreso { get; set;}
        public bool EstaPagado { get; set;}
        public decimal Precio { get; set;}
    }
}