using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListHernanSanchez
{
    internal class Program
    {
        static void Main(string[] args) // Método principal que ejecuta el program
        {
            ListaDeTareas listaDeTareas = new ListaDeTareas();//Creamos una instancia de la clase ListaDeTareas
            string Opcion;
            do
            {
                Console.WriteLine(" Lista de Tareas ");
                Console.WriteLine(" 1. Agregar una nueva Tarea ");
                Console.WriteLine(" 2. Listar Tareas ");
                Console.WriteLine(" 3. Completar una Tarea ");
                Console.WriteLine(" 4. Eliminar una Tarea ");
                Console.WriteLine(" 5. Salir ");
                Console.WriteLine(" Por favor, seleccione una opción ");
                Opcion = Console.ReadLine();// Leemos la opción ingresada por el usuario

                switch (Opcion) 
                {
                    case "1":
                        AgregarNuevaTarea(listaDeTareas);
                        break;
                    case "2":
                        ListarTareas(listaDeTareas);
                        break;
                    case "3":
                        CompletarTarea(listaDeTareas);
                        break;
                    case "4":
                        EliminarTarea(listaDeTareas);
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, seleccione una opción del menú (1-5).");
                        break;
                }
            }while(Opcion != "5");
        }

        static void AgregarNuevaTarea(ListaDeTareas listaDeTareas) 
        {
            Console.WriteLine(" Ingrese la descripcion de la tarea que desea agregar: ");
            string descripcion = Console.ReadLine();
            Console.WriteLine(" Ingrese la fecha limite(formato DD/MM/AÑO) o presione Enter para omitir: ");
            string fechaLimiteInput = Console.ReadLine();
            DateTime? fechaLimite = null;

            if ( DateTime.TryParse(fechaLimiteInput, out DateTime fechaLimiteEstandar) ) // convertimos a fecha estandar
            {
                fechaLimite = fechaLimiteEstandar;
            }

            listaDeTareas.AgregarNuevaTarea(descripcion, fechaLimite);
            Console.WriteLine(" Tarea Agregada con éxito ");

            
        }
        static void ListarTareas(ListaDeTareas listaDeTareas) 
        {
            listaDeTareas.ListarTareas();
        }

        static void CompletarTarea(ListaDeTareas listaDeTareas) 
        {
            Console.WriteLine(" Ingrese el número de la tarea a marcar como completada: ");
            if ( int.TryParse(Console.ReadLine(), out int numeroDeTarea) ) // convertimos a número entero
            {
                listaDeTareas.CompletarTarea(numeroDeTarea);
            }
            else 
            {
                Console.WriteLine(" Número de tarea a completar no válido ");
            }
        }
        static void EliminarTarea(ListaDeTareas listaDeTareas) 
        {
            Console.WriteLine( "Ingrese el número de la tarea a eliminar: ");
            if ( int.TryParse(Console.ReadLine(), out int numerodetarea)) // convertimos a número entero
            {
                listaDeTareas.EliminarTarea(numerodetarea);
            }
            else 
            {
                Console.WriteLine(" Número de tarea a eliminar no válido ");
            }
        }
    }
}
