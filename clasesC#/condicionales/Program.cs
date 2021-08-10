using System;

namespace condicionales
{
    class Program
    {
        static void Main(string[] args)

        /* { // CONDICIONAL Simple
             int a = 5;
             int b = 10;
             if (a < b) {
                 Console.WriteLine("B es mayor que A");
             }*/

        /* { // Condicionales Multiples
                int a = 50;
                int b = 10;
                int c = 56;
                if (a > b && a > c) {
                    Console.WriteLine("A es mayor que B");
                }
                else if (b > a && b > c)
                {
                    Console.WriteLine("B es mayor que A y C");
                }
                else {
                    Console.WriteLine("C es mayor que A y B");
                } */

        // Condicionales anidadas
        /*  {
                double hemoglobina = double.Parse(Console.ReadLine());
                char genero = char.Parse(Console.ReadLine());

                if(genero == 'm')
                {
                    if (hemoglobina < 13)
                    {
                        Console.WriteLine("Baja");
                    }
                else if (hemoglobina >= 13 && hemoglobina < 16)
                {
                    Console.WriteLine("Normal");
                }
            }
              else if(genero == 'f')
                {
                    if (hemoglobina < 11)
                    {
                        Console.WriteLine("Baja");
                    }
                else if (hemoglobina >= 11 && hemoglobina < 15)
                {
                    Console.WriteLine("Normal");
                }
            }

            else
            {
                Console.WriteLine("Ingresaste un Genero no valido");
            } } */

        /*   System.Console.WriteLine("Ingresa tu Edad");
           int edad = int.Parse(Console.ReadLine());

           if (edad > 0 && edad <= 13)
               System.Console.WriteLine("Perteneces a la categoria de Niños");
           else if (edad >= 13 && edad <= 29)
           {
               Console.WriteLine("Perteneces a la categoria de Jovenes");
           }
           else if (edad >= 30 && edad <= 65)
           {
               Console.WriteLine("Perteneces a la categoria de Adulto");
           }
           else if (edad >= 65 && edad <= 150)
           {
               Console.WriteLine("Perteneces a la categoria de Adulto Mayor");
           }
           else
           {
               Console.WriteLine("Edad no valido");
           }  */
        /*  {
              System.Console.WriteLine("Ingresa tu Nombre");
              String nombre = Console.ReadLine();
              System.Console.WriteLine("Ingresa tu Edad");
              int edad = int.Parse(Console.ReadLine());
              System.Console.WriteLine("Ingresa tu Sexo 1Femenino/ 2 Masculino");
              int sexo = int.Parse(Console.ReadLine());
              System.Console.WriteLine("Estado Civil 1 Soltero, 2 Casado, 3 Otro");
              int estadoCivil = int.Parse(Console.ReadLine());

              if (sexo == 1)
              {
                  if (estadoCivil == 1)
                  {
                      if (edad >= 18 && edad <= 25)
                          System.Console.WriteLine("Bienvenido al club");
                      else
                          System.Console.WriteLine("No cumples con los requisitos");
                  }
                  else
                      System.Console.WriteLine("No cumples con los requisitos");
              }
              else if (sexo == 2)
              {
                  if (estadoCivil == 1)
                  {
                      if (edad >= 18 && edad <= 38)
                          System.Console.WriteLine("Bienvenido al club");
                      else
                          System.Console.WriteLine("No cumples con los requisitos");
                  }
                  else
                      System.Console.WriteLine("No cumples con los requisitos");

              }
          }*/
        
         /*   System.Console.WriteLine("Escribe 1. Enero o 2 Febrero");
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {

                case 1:
                    Console.WriteLine("El mes de Enero tiene 31 dias");
                    break;
                case 2:
                    System.Console.WriteLine("El mes de Febreo tiene 28 o 29 dias");
                    break;
                default:
                    Console.WriteLine("Ingrese un valor correcto");
                    break;
            }
*/
            
         /*   
            // int totalPagoDes = 0;
            

            if (opcion == 1)
            {
                totalPago = precioHam * cantidadProductos;
                if (cantidadProductos >= 5)
                {
                    totalPago -= (int)(totalPago * descuento);
                }
            }
            else if (opcion == 2)
            {
                totalPago = precioPerro * cantidadProductos;
                if (cantidadProductos >= 5)
                {
                    totalPago -= (int)(totalPago * descuento);
                }
            }
            else if (opcion == 3)
            {
                totalPago = precioSalch * cantidadProductos;
                if (cantidadProductos >= 5)
                {
                    totalPago -= (int)(totalPago * descuento);
                }
            } */
{
            Console.WriteLine("Menu");
            Console.WriteLine("1. Hamburguesa \n2. Perro Caliente \n3. Salchipapa");
            Console.WriteLine("Elige una Opcion");
            int opcion = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite la cantidad de Productos");
            int cantidadProductos = int.Parse(Console.ReadLine());

            int precioHam = 14500, precioPerro = 9000, precioSalch = 12000;
            int totalPago = 0;
            double descuento = 0.10;

            switch (opcion)
            {

                case 1:
                 totalPago = precioHam * cantidadProductos;
                if(cantidadProductos >=5)
                {
                    totalPago -= (int)(totalPago * descuento);
                }
                    Console.WriteLine("El total a pagar es: " + totalPago);
                    break;
                case 2:
                 totalPago = precioPerro * cantidadProductos;
                if(cantidadProductos >=5)
                {
                    totalPago -= (int)(totalPago * descuento);
                }
                    Console.WriteLine("El total a pagar es: " + totalPago);
                    break;
                case 3:
                 totalPago = precioSalch * cantidadProductos;
                if(cantidadProductos >=5)
                {
                    totalPago -= (int)(totalPago * descuento);
                }
                    Console.WriteLine("El total a pagar es: " + totalPago);
                    break;
                default:
                    Console.WriteLine("Ingrese un valor correcto");
                    break;
            }

        }
    }
}

