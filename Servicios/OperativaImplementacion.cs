using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1String.Servicios
{
    internal class OperativaImplementacion : OperativaInterfaz
    {
        public string pedirNombreOApe(int controladorMens)
        {
            string nombreVal=" ";
            
            if(controladorMens == 0)
            {
                Console.WriteLine("Introduzca su nombre: ");
                nombreVal = Console.ReadLine();
            }else if(controladorMens == 1)
            {
                Console.WriteLine("Introduzca su primer apellido");
                nombreVal = Console.ReadLine();
            }else if (controladorMens == 2)
            {
                Console.WriteLine("Introduzca su segundo apellido");
                nombreVal = Console.ReadLine();
            }

            return nombreVal;


        }
    }
}
