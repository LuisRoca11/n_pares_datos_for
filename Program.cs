// Confeccionar un programa que lea n pares de datos, cada par de datos corresponde a la medida de la base y la altura de un triángulo. El programa deberá informar:
// a) De cada triángulo la medida de su base, su altura y su superficie. 
// b) La cantidad de triángulos cuya superficie es mayor a 12.

using System;

namespace n_pares_datos_for
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0, altura=0, baseT=0, contador=0;
            double superficie;

            Console.Write("Ingrese la cantidad de triangulos a ingresar: ");
            num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                Console.Write("Ingrese la base del triangulo: ");
                baseT = int.Parse(Console.ReadLine());

                Console.Write("Ingrese la altura del triangulo: ");
                altura = int.Parse(Console.ReadLine());

                superficie = (double)(baseT * altura) / 2;

                Console.WriteLine($"La superficie resultante de base: {baseT} y altura de: ̱{altura} es: ̱{superficie}");

                if (superficie>12)
                {
                    contador = contador + 1;
                }
            }
            Console.WriteLine($"La cantidad de triangulos con superficies mayores a 12 es: {contador}");
            Console.WriteLine("Fin de programa...");
            Console.ReadKey();
        }
    }
}