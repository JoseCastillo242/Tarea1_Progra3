using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    internal class CharBase
    {
        public int Vida { get; set; }
        public int Ataque { get; set; }
        public string Rol { get; set; }
        public string Nombre { get; set; }

        public CharBase
            (
            int vida,
            int ataque,
            string rol,
            string nombre
            )
        {
            Vida = vida;
            Ataque = ataque;
            Rol = rol;
            Nombre = nombre;
        }

        public string Imprimir()
        {
            return $"Clase: {GetType().Name}, Nombre: {Nombre}, Vida: {Vida}, Ataque: {Ataque}, Rol: {Rol}";
        }
    }
}
