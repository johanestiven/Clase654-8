using System;

namespace Examen
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Clasificar a N cantidad personas según la edad y el sexo al final deberá visualizar:
            -	La cantidad de personas masculinas mayores de edad 
            -	La cantidad de personas femeninas menores de edad
            -	Promedio de edades. */

            Console.WriteLine("Ingrese la cantidad de Personas");
            int cantidadPersonas = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Ingresa tu Edad");
            int edad = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Ingresa tu Sexo 1Maculino/ 2 Femenino");
            int sexo = int.Parse(Console.ReadLine());
            //int i = 0;
            double promedioedad = 0;
            for (int i = 0; i < cantidadPersonas; i++)

                if (sexo == 1 )
                {
                    if (edad >= 18)
                        System.Console.WriteLine("Masculino Mayor de edad" + i);
                    else

                        System.Console.WriteLine("Masculino Menor  de edad");
                }

                else if (sexo == 2)
                {
                    if (edad < 18)
                        System.Console.WriteLine("Femenino Menor de edad");
                    else

                        System.Console.WriteLine("Femenino Menor  de edad");
                }
            promedioedad = promedioedad / cantidadPersonas;
           // Console.WriteLine("La cantidad de personas Masculina es  "+ promedioedad);
            // Console.WriteLine("La cantidad de personas Femeninas es  " + 2);

        }


    }
}