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
        class Peliculas
        {
            //campos
            public string pelicula, director;
            public int año;

            //constructor
            public Peliculas(string pelicula, string director, int año)
            {
                this.pelicula = pelicula;
                this.director = director;
                this.año = año;
            }

        }
        static void Main(string[] args)
        {
            Console.Write("Ingrese una película: ");
            string pelicula = Console.ReadLine();
            Console.Write("Ingrese el nombre del director: ");
            string director = Console.ReadLine();
            Console.Write("Ingrese el año de estreno: ");
            int año = int.Parse(Console.ReadLine());

            Peliculas peli = new Peliculas(pelicula, director, año);

            StreamWriter sw = new StreamWriter("ejemplo.txt",true);
            // si el archivo no existe, lo creará
            // si ya existe, escribirá en él
            // true es para agregar y no sobreescribir

            sw.WriteLine(peli.pelicula+"  "+peli.director+"  "+peli.año);
            sw.Close();

            Console.WriteLine("Escribiendo en el archivo...");
            Console.ReadKey();

        }
    }
}
