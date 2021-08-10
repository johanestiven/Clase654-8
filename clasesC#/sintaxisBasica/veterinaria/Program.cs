using System;

namespace veterinaria
{
    class Program
    {
        static void Main(string[] args)
        {
           String nombre = Console.ReadLine();
            short edad = short.Parse(Console.ReadLine());
            String raza = Console.ReadLine();
            float peso = float.Parse(Console.ReadLine()); // ;
            bool vacunado = bool.Parse(Console.ReadLine());
            String color = Console.ReadLine();

            Console.WriteLine("Nombre : " + nombre);
            Console.WriteLine("Edad: " + edad);
            Console.WriteLine("Raza: " + raza);
            Console.WriteLine("Peso: " + peso);
            Console.WriteLine("Esta Vacunado: " + vacunado);
            Console.WriteLine("Color: " + color);
        }
    }
}
