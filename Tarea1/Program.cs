using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Formato Stats Vida, Ataque, Rol, Nombre
            List<CharBase> personajes = new List<CharBase>();
            personajes.Add(new Mago(100, 20, "Heroe", "Hj"));
            personajes.Add(new Heroe(80, 10, "Heroe", "Black"));
            personajes.Add(new Mago(120, 30, "Heroe", "Pedro Pascal"));
            personajes.Add(new Heroe(90, 5, "Heroe", "Danilo"));
            personajes.Add(new Mago(110, 50, "Secuaz", "Hernesto"));
            personajes.Add(new Heroe(70, 25, "Heroina", "Hernestina"));
            personajes.Add(new Mago(200, 500, "Villano", "Eustaquio"));

            foreach (var personaje in personajes)
            {
                Console.WriteLine(personaje.Imprimir());
                Console.WriteLine();
            }
        }
    }
}
