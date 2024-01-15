using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1String.Servicios
{
    internal interface OperativaInterfaz
    {
        public string pedirNombreOApe(int controladorMens);

        public string pedirDniYVal();

        public int codigoPostal();
    }
}
