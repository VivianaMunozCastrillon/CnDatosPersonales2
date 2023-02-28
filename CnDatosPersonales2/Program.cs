using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CnDatosPersonales2
{
    internal class Program
    {
        /// <summary>
        /// Nombre:Viviana Muñoz
        /// Fecha:26/02/2023
        /// Descripcion:Este programa solicita el nombre de la persona y evalua que sea mayor de edad para continuar pidiendo los demas datos personales.
        /// </summary>
        
        static void Main(string[] args)
        {
            //Solicita los datos de entrada
            Console.WriteLine("Digite su nombre");
            string Nombre = Console.ReadLine();
            Console.WriteLine("elija una opcion");
            Console.WriteLine("digita (1) si eres mayor de edad");
            Console.WriteLine("digita (2) si eres menor de edad");
            int opcion = int.Parse(Console.ReadLine());

            //Condicion
            if (opcion == 1)
            {
                Console.WriteLine("Escriba su apellido");
                string Apellido = Console.ReadLine();
                Console.WriteLine("Escriba su edad");
                string Edad = Console.ReadLine();
                Console.WriteLine("escriba su correo electronico");
                string Correo = Console.ReadLine();
                Console.WriteLine(Nombre + " " + Apellido + " " + "su edad es " + Edad + " " + "años" + "y su correo electronico es:" + Correo);




            }

            else
            {
                Console.WriteLine("lo siento debe ser mayor para continuar");
            }

            Console.ReadKey();
        }
    }
}
