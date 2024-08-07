using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListHernanSanchez
{
    internal class ListaDeTareas // Clase que representa una lista de tareas
    {
        private List<Tarea> tareas = new List<Tarea>(); // Lista privada de tareas

        public void AgregarNuevaTarea(string descripcion, DateTime? fechaLimite = null) 
        {
            tareas.Add(new Tarea(descripcion, fechaLimite));
        }

        public void ListarTareas() 
        {
            if ( tareas.Count == 0) 
            {
                Console.WriteLine(" No hay tareas por listar ");
                return;
            }
            for (int i = 0; i < tareas.Count; i++) 
            {
                Console.WriteLine($"{i + 1}, {tareas[i]}");// Mostramos cada tarea con su número(indice)
            }
        }

        public void CompletarTarea(int numerodeTarea) 
        {
            if (numerodeTarea < 1 || numerodeTarea > tareas.Count) 
            {
                Console.WriteLine(" Número de tarea a completar no válido ");
                return;
            }
            tareas[numerodeTarea-1].Completada = true;// las listas en C# son base cero
            Console.WriteLine(" Tarea marcada como completada con éxito ");
        }

        public void EliminarTarea(int numerodetarea) 
        {
            if ( numerodetarea < 1 || numerodetarea > tareas.Count ) 
            {
                Console.WriteLine(" Número de tarea a eliminar no válido ");
                return;
            }
            tareas.RemoveAt(numerodetarea - 1);// las listas en C# son base cero
            Console.WriteLine(" Tarea Elimidada con éxito ");
        }
    }
}
