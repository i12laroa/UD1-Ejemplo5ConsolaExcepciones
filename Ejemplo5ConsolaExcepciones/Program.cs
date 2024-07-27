using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo5ConsolaExcepciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string rutaArchivo;

            Console.WriteLine("Escribe el nombre del fichero para leer en la ruta actual: ");
            rutaArchivo = Console.ReadLine();

            try
            {
                string contenido = File.ReadAllText(rutaArchivo);
                Console.WriteLine(contenido);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Error: El archivo no se encontró.");
                Console.WriteLine(ex.Message);
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine("Error: No tienes permisos para acceder al archivo.");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrió un error inesperado:");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
