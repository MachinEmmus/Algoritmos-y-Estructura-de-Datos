using System;
using System.Diagnostics;

namespace FibonacciFactorial
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int factorial = 1;

            Console.Write("Ingresa un número entero positivo para calcular el factorial: \n");
            int num_factorial = int.Parse(Console.ReadLine());

            Stopwatch stopwatch_recursivo = Stopwatch.StartNew();
            Console.WriteLine("Factorial Recursivo: {0}! = {1}", num_factorial, Factorial(num_factorial));
            stopwatch_recursivo.Stop();

            // Imprime el tiempo de ejecución en microsegundos
            Console.WriteLine($"Tiempo de ejecución: {stopwatch_recursivo.ElapsedTicks / (TimeSpan.TicksPerMillisecond / 1000)} μs\n");

            Stopwatch stopwatch_ciclo = Stopwatch.StartNew();
            for (int i = 1; i <= num_factorial; i++)
            {
                factorial *= i;
            }
            stopwatch_ciclo.Stop();

            Console.WriteLine("Factorial Ciclos: {0}! = {1}", num_factorial, Factorial(num_factorial));

            // Imprime el tiempo de ejecución en microsegundos
            Console.WriteLine($"Tiempo de ejecución: {stopwatch_ciclo.ElapsedTicks / (TimeSpan.TicksPerMillisecond / 1000)} μs\n");


            Console.WriteLine("Ingresa un número entero positivo para calcular fibonacci: ");
            int num_fibonacci = int.Parse(Console.ReadLine());

            int a = 0;
            int b = 1;

            Stopwatch stopwatch_ciclo_fibo = Stopwatch.StartNew();
            Console.Write(a + " " + b + " ");

            for (int i = 2; i < num_fibonacci; i++)
            {
                int c = a + b;
                Console.Write(c + " ");
                a = b;
                b = c;
            }
            stopwatch_ciclo_fibo.Stop();

            // Imprime el tiempo de ejecución en microsegundos
            Console.WriteLine($"\nTiempo de ejecución ciclos: {stopwatch_ciclo_fibo.ElapsedTicks / (TimeSpan.TicksPerMillisecond / 1000)} μs\n");

            Stopwatch stopwatch_recursiva_fibo = Stopwatch.StartNew();
            for (int i = 0; i < num_fibonacci; i++)
            {
                Console.Write(Fibonacci(i) + " ");
            }
            stopwatch_recursiva_fibo.Stop();

            // Imprime el tiempo de ejecución en microsegundos
            Console.WriteLine($"\nTiempo de ejecución recursivo: {stopwatch_recursiva_fibo.ElapsedTicks / (TimeSpan.TicksPerMillisecond / 1000)} μs\n");

            Console.ReadKey();
        }

        static int Factorial(int num)
        {
            if (num == 0)
            {
                return 1;
            }
            else
            {
                return num * Factorial(num - 1);
            }
        }

        static int Fibonacci(int n)
        {
            if (n <= 1)
            {
                return n;
            }

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
