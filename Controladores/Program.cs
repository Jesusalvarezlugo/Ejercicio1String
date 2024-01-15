using Ejercicio1String.Servicios;

namespace Ejercicio1String.Controladores
{
    class Program
    {
        public static void Main(string[] args)
        {
            string nombre;
            string apellido1;
            string apellido2;
            string dniCompleto;
            OperativaInterfaz oi = new OperativaImplementacion();

            nombre = oi.pedirNombreOApe(0);
            apellido1 = oi.pedirNombreOApe(1);
            apellido2 = oi.pedirNombreOApe(2);

            while (nombre == apellido1 || nombre == apellido2)
            {
                Console.WriteLine("ERROR! su nombre coincide con alguno de sus apellidos.");

                nombre = oi.pedirNombreOApe(0);
                apellido1 = oi.pedirNombreOApe(1);
                apellido2 = oi.pedirNombreOApe(2);
            }

            dniCompleto = oi.pedirDniYVal();
        }
    }
}
