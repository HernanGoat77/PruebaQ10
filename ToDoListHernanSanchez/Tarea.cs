using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListHernanSanchez
{
    internal class Tarea // Clase que representa una tarea
    {
        public string Descripcion {  get; set; }
        public DateTime? FechaLimite { get; set; } // DateTime? indicamos que puede ser nula la fecha
        public bool Completada { get; set; }

        public Tarea( string descripcion, DateTime? fechaLimite = null) //constructor
        {
            Descripcion = descripcion;
            FechaLimite = fechaLimite;
            Completada = false;
        }
        public override string ToString() //representamos la tarea como una cadena
        {
            return $"Descripción: {Descripcion}, Fecha Límite: {FechaLimite?.ToString("dd/MM/yyyy") ?? "Sin fecha límite"}, Completada: {Completada}";
        }
    }
}
