using System;

namespace ciclos
{
    class Program
    {
        static void Main(string[] args)
        /*    {
                int i = 2;
                while (i <= 20)
                {
                    Console.WriteLine("Recorrido " + i);
                    i += 2;
                }*/

        //Ingrese el numero de invitados 

        /*    { 
            Console.WriteLine("Digite la cantidad de Invitados");
            int cantidadInvitados = int.Parse(Console.ReadLine());   
            int i = 1;

            while (i <= cantidadInvitados)
            {
                Console.WriteLine("Ingrese el nombre del Invitado " );
                String cantidad = (Console.ReadLine());
                Console.WriteLine("Cantidad Invitados  " + i  );
                
                i ++;
            } */
        //   {
        /* 
            System.Console.WriteLine("Ingrese la cantidad de notas");
            int cantNotas = int.Parse(Console.ReadLine()); */
        /*  int i = 1;
          double promedio = 0;
          while (i <= cantNotas)
          {
              Console.WriteLine("Ingrese la nota " + i);
              double nota = double.Parse(Console.ReadLine());
              promedio += nota;
              i++;
          }
           promedio = promedio / cantNotas;
           System.Console.WriteLine(promedio); */



        /*  int j = 6;
         do
         {
             System.Console.WriteLine(j);
             j++;
         } while (j < 5);


         double promedio = 0;
         for (int i = 0; i < cantNotas; i++)
         {
             Console.WriteLine("Ingrese la nota " + i);
             double nota = double.Parse(Console.ReadLine());
             promedio += nota;
         }
         promedio = promedio / cantNotas;
         System.Console.WriteLine(promedio); */


        //Ciclos anidados
        /* {
                    for (int i = 0;  i < 3; i++)
                    {
                        System.Console.WriteLine("Saludo");
                        for (int k = 0; k < 2  ; k++)
                        {
                            System.Console.WriteLine("Saludo desde otra dimension");
                        }
                    }
                    
                } */

        // Solicitar la cantidad de Productos
        //Solicitar el valor de cada Productos
        //Mostrar el total a apagar por los productos
        /* 
                {
                    Console.WriteLine("Ingrese la cantidad de Productos");
                    int cantidadProductos = int.Parse(Console.ReadLine());
                    int totalpago = 0;
                    double descuento = 0.10;

                    for (int i = 0; i < cantidadProductos; i++)
                    {
                        Console.WriteLine("Ingrese el valor del Producto " + (i + 1));
                        int vproductos = int.Parse(Console.ReadLine());
                        totalpago += vproductos;
                    }
                    if (totalpago > 50000)
                    {
                        totalpago -= (int)(totalpago * descuento);
                    }

                    Console.WriteLine("El valor total a pagar es: " + totalpago);
                } */
        {
            //N cantidad de Personas
            //Solicitar el valor del impuesto a pagar por cada persona
            // Impuesto predial >500000 se aplica un descuanto del 5%
            //Total a pagar con descuento si aplica

            Console.WriteLine("Ingrese la cantidad de Personas");
            int cantidadPersonas = int.Parse(Console.ReadLine());
           // double descuento = 0.05;
            for (int i = 0; i < cantidadPersonas; i++)
            {
                Console.WriteLine("Ingrese el valor del Impuesto" + i);
                int vimpuesto=int.Parse(Console.ReadLine());
                if(vimpuesto >500000){
                    vimpuesto -= (int)(vimpuesto*0.05);
                    Console.WriteLine("el valñor total a pagar es " + vimpuesto);

                }
                 Console.WriteLine("el valor total a pagar es " + vimpuesto);

            }





        }

    }
}

