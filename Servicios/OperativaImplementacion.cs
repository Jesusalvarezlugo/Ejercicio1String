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

        public string pedirDniYVal()
        {
            int numDni;
            char letraDni='f';

            Console.WriteLine("Introduzca el número del DNI: ");
            numDni=Int32.Parse(Console.ReadLine());

            switch (numDni % 23)
            {
                case 0:
                    letraDni = 'T';
                    break;

                case 1:
                    letraDni = 'R';
                    break;

                case 2:
                    letraDni = 'W';
                    break;

                case 3:
                    letraDni = 'A';
                    break;

                case 4:
                    letraDni = 'G';
                    break;

                case 5:
                    letraDni = 'M';
                    break;

                case 6:
                    letraDni = 'Y';
                    break;

                case 7:
                    letraDni = 'F';
                    break;

                case 8:
                    letraDni = 'P';
                    break;

                case 9:
                    letraDni = 'D';
                    break;

                case 10:
                    letraDni = 'X';
                    break;

                case 11:
                    letraDni = 'B';
                    break;

                case 12:
                    letraDni = 'N';
                    break;

                case 13:
                    letraDni = 'J';
                    break;

                case 14:
                    letraDni = 'Z';
                    break;

                case 15:
                    letraDni = 'S';
                    break;

                case 16:
                    letraDni = 'Q';
                    break;

                case 17:
                    letraDni = 'V';
                    break;

                case 18:
                    letraDni = 'H';
                    break;

                case 19:
                    letraDni = 'L';
                    break;

                case 20:
                    letraDni = 'C';
                    break;

                case 21:
                    letraDni = 'K';
                    break;

                case 22:
                    letraDni = 'E';
                    break;

                default:
                    Console.WriteLine("ERROR! numero fuera de rango");
                    break;
            }

            string dniCompleto = numDni + "-" + letraDni;

            return dniCompleto;
        }

        public int codigoPostal()
        {
            int codigoP;

            Console.WriteLine("Introduzca su codigo postal: ");
            codigoP = Int32.Parse(Console.ReadLine());

            if (codigoP !=)
            {

            }
        }
    }
}
