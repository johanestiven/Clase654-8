using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {System.Console.WriteLine("Ingrese la cantidad de personas");
            int cantidadPersonas = int.Parse(Console.ReadLine());
            String[,] personas = new string[cantidadPersonas, 4];


            for (int i = 0; i < cantidadPersonas; i++)
            {
                System.Console.WriteLine("Ingrese los datos de las personas" + (i + 1));
                for (int j = 0; j < 4; j++)
                {
                    if (j == 2)
                    {
                        System.Console.WriteLine("Genero: m - Masculino - F Femenino");
                    }

                    string dato = Console.ReadLine();
                    personas[i, j] = dato;
                }
            }

            int generof = 0, generom = 0, sumaEdad = 0, regalo = 0, edad =0;
            for (int i = 0; i < cantidadPersonas; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (j == 1)
                    {
                        if (personas[i, j] == "f" || personas[i, j] == "F")
                        {
                            generof++;
                        }
                        else if (personas[i, j] == "m" || personas[i, j] == "M")
                        {
                            generom++;
                        }
                    }
                    if (j == 2)
                    {
                        sumaEdad += int.Parse(personas[i,j]);
                        edad++;
                    }

                     if(j==3)
                     {
                         if(personas[i, j]=="s" || personas[i, j] == "S")
                         {
                             regalo ++;
                         }
                     }
                }
            }
            System.Console.WriteLine("La cantidad de mujeres es: "+ generof);
            System.Console.WriteLine("La cantidad de mujeres es: "+ generom);
        }
    }
}
