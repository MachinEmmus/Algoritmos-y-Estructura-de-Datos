using System;
using System.Diagnostics;

namespace SumarNúmerosCiclosGauss
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Ingresa un número entero positivo hasta el que quiera sumar: \n");
            int num = int.Parse(Console.ReadLine());

            int suma = 0; // Variable para almacenar la suma

            Stopwatch stopwatch_ciclo = Stopwatch.StartNew();
            // Bucle for para sumar los números desde 1 hasta N
            for (int i = 1; i <= num; i++)
            {
                suma += i; // Sumar el número actual a la variable suma
            }
            stopwatch_ciclo.Stop();

            // Mostrar la suma por consola
            Console.WriteLine("La suma de los números desde 1 hasta {0} es: {1}", num, suma);

            // Imprime el tiempo de ejecución en microsegundos
            Console.WriteLine($"Tiempo de ejecución: {stopwatch_ciclo.ElapsedTicks / (TimeSpan.TicksPerMillisecond / 1000)} μs\n");


            Stopwatch stopwatch_gauss = Stopwatch.StartNew();
            int suma_gauss = (num * (num + 1)) / 2; // Algoritmo de Gauss para la suma
            stopwatch_gauss.Stop();

            // Mostrar la suma por consola
            Console.WriteLine("La suma de los números desde 1 hasta {0} es: {1}", num, suma_gauss);

            // Imprime el tiempo de ejecución en microsegundos
            Console.WriteLine($"Tiempo de ejecución: {stopwatch_gauss.ElapsedTicks / (TimeSpan.TicksPerMillisecond / 1000)} μs\n");

            Console.ReadKey();

        }
    }
}
