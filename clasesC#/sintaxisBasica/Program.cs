using System;
using sintaxisBasica.Enumerations;
using sintaxisBasica.Structure;

namespace sintaxisBasica
{
    class Program
    {
       
        //Enumeraciones, la forma para las numeraciones 
       
        static void Main(string[] args)
        {
            String nombre = Console.ReadLine();
            short edad = short.Parse(Console.ReadLine());
            int numeroDocumento = int.Parse(Console.ReadLine());
            float peso = float.Parse(Console.ReadLine()); // ;
            double estatura = double.Parse(Console.ReadLine());
            bool tieneMascota = bool.Parse(Console.ReadLine());  // buleanos ;
        //    var tipoDocumento = TipoDocumento. CedulaCiudadania;
          //  DateTime fechaNacimiento = new DateTime(1994, 4, 14);
          //  DateTime fechaActual = DateTime.Now; // fecha actual con l ahora actual.
            System.Console.WriteLine("Escribe el año del nacimiento");
            int añoNac = int.Parse (Console.ReadLine());
            System.Console.WriteLine("Escribe el mes de nacimiento");
            int mesNac =  int.Parse (Console.ReadLine());
            System.Console.WriteLine("Escribe el dia del nacimiento");
            int diaNac =  int.Parse (Console.ReadLine());

            Direccion dir1;
            dir1.numeroCalle = 85;
            dir1.letra = "A";
            dir1.numero = 35;
            string direccion =  $"Calle {dir1.numeroCalle} {dir1.letra} # {dir1.numero}";
            var genero = Genero.Masculino;

            DateTime fechaNacimiento = new DateTime(añoNac, mesNac, diaNac);
            DateTime fechaActual = DateTime.Now;

            Console.WriteLine("Nombre: " + nombre);
         //   Console.WriteLine("TipoDocumento : " + TipoDocumento);
            Console.WriteLine("Numero de Documento : " + numeroDocumento);
            Console.WriteLine("Edad: " + edad);
            Console.WriteLine("Peso: " + peso);
            Console.WriteLine("Estatura: " + estatura);
            Console.WriteLine("Tiene Mascota: " + tieneMascota);
            Console.WriteLine("Genero: " + genero);
            Console.WriteLine(fechaNacimiento);
            Console.WriteLine(fechaNacimiento.Date.ToShortDateString()); // Fecha sin hora
            System.Console.WriteLine(fechaActual.ToShortDateString());
            int edad2 = (fechaActual - fechaNacimiento).Days/365;
            System.Console.WriteLine("Edad: " + edad2);
           
            int? cantidad  = null;
            int cantidad2 = 50;

            if (cantidad.HasValue)
            {
                cantidad2 = cantidad.Value;
            }
            Console.WriteLine(cantidad);
            Console.WriteLine(cantidad2);

            int estaturaEntero = (int)estatura;
            double estatura2 = estaturaEntero; // Combertir de entero a double

            System.Console.WriteLine(estaturaEntero);

            double numero = double.Parse("5.36"); // Combertir con Parse

            Console.WriteLine(55==25);

            /*Console.WriteLine("Escribe un numero");
            int numero2 = int.Parse (Console.ReadLine());*/ 
            System.Console.WriteLine(primerNumero);
            
        }
    }
}
