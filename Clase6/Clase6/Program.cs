using System;

namespace clase_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Resolver con FOR y WHILE
            //Sortee 10 numeros y luego muestre en pantalla el promedio de los mismos


            /* int i = 0;
             float num, suma = 0;
             Random objetoRandom = new Random();

             while (i < 10)
             {

                 num = objetoRandom.Next(1000);

                 suma += num;
                 i++;

                 Console.WriteLine(i);

             }

             Console.WriteLine("El promedio de los 10 números es: " + suma / 10);
             */

            //Ingrese un número y calcule el factorial del mismo. El factorial de un número (Ej: 5), es:
            int numero, resultado = 1;

            Console.WriteLine("Ingrese un número a factorizar");
            numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numero; i++)
            {
                resultado = resultado * i;
            }

            Console.WriteLine("El factorial de " + numero + " es: " + resultado);

        }
    }
}
