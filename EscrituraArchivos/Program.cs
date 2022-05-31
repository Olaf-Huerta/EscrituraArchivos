using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EscrituraArchivos
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("ejemplo.txt",true);
            // si el archivo no existe, lo creará
            // si ya existe, escribirá en él
            // true es para agregar y no sobreescribir

            string[] lines = {
                "Esta es la información de la primera línea",
                "Esta es la segunda linea",
                "Fin del texto",
                "probando"
            };

            foreach(string line in lines)
            {
                sw.WriteLine(line); // escribe en el archivo
            }
            sw.Close(); // se debe cerrar el archivo

            Console.WriteLine("Escribiendo en el archivo...");
            Console.ReadKey();
        }
    }
}
