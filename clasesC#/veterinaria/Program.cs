using System;
//using veterinaria.Structure.Enumerations;
//using veterinaria.Structure;

namespace veterinaria
{
    class Program
    {
        static void Main(string[] args)
        { 
            //Datos Perro
            System.Console.WriteLine("Ingresa el Nombre");
            String nombreP = Console.ReadLine();
            System.Console.WriteLine("Ingresa la edad");
            short edad = short.Parse(Console.ReadLine());
            System.Console.WriteLine("Ingresa la Raza");
            String raza = Console.ReadLine();
            System.Console.WriteLine("Ingresa el peso ");
            float peso = float.Parse(Console.ReadLine()); // ;
            System.Console.WriteLine("Ingresa si esta Vacunado: true si ya fue vacunado, false si no a sido vacunado ");
            bool vacunado = bool.Parse(Console.ReadLine());
            System.Console.WriteLine("Ingresa el Color");
            String color = Console.ReadLine();
        

             //Datos dueño del Perro

            System.Console.WriteLine("Ingresa tu Nombre");
            String nombre = Console.ReadLine();
            System.Console.WriteLine("Ingresa tu Apellido");
            String apellido = Console.ReadLine();
            System.Console.WriteLine("Ingresa tu Tipo documento");
            String tipoDocumento = Console.ReadLine();
            System.Console.WriteLine("Ingresa tu Numero de documento");
            int documento = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Ingresa tu Género");
           // String genero = Console.ReadLine();

          /*  Direccion dir1;
            dir1.numeroCalle = 85;
            dir1.letra = "A";
            dir1.numero = 35;
            string direccion =  $"Calle {dir1.numeroCalle} {dir1.letra} # {dir1.numero}";*/
            
            // 

            //Servicios
            Console.WriteLine("Ingresa el Servicio");
            String servicio = Console.ReadLine();
            Console.WriteLine("Ingresa el valor del servicio");
            double Vlorservicio = double.Parse(Console.ReadLine());
            Console.WriteLine("Tipos de Pago 1=efectivo 2=tarjeta, 3=Transferencia");
            string tipoPago = Console.ReadLine();
            Console.WriteLine("Estado de pago: true si ya fue cancelado y false si no a sido cancelado ");
            string estadoPago = Console.ReadLine();
        }
    }
}
