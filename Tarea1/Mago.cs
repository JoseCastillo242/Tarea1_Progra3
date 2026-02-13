using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    internal class Mago : CharBase
    {
        public Mago(
            int vida,
            int ataque,
            string rol,
            string nombre
            ) : 
            base(
                vida,
                ataque,
                rol,
                nombre
                )
        {

        }
    }
}
