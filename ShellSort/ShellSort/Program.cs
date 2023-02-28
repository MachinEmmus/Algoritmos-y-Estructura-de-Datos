using System;
using System.Diagnostics;

namespace ShellSort
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Pide al usuario que ingrese la cantidad de elementos del arreglo
            Console.Write("Ingrese la cantidad de elementos del arreglo: ");
            int tamaño = int.Parse(Console.ReadLine());

            // Crea un arreglo de n posiciones
            int[] miArray = new int[tamaño];

            // Llena el arreglo con números aleatorios entre 1 y 100
            Random random = new Random();
            for (int i = 0; i < tamaño; i++)
            {
                miArray[i] = random.Next(1, (tamaño + 1));
            }

            // Mide el tiempo de ejecución del algoritmo de ordenamiento
            Stopwatch stopwatch = Stopwatch.StartNew();
            ShellSort(miArray);
            stopwatch.Stop();

            // Imprime el arreglo ordenado
            Console.WriteLine("\nEl arreglo ordenado es:");
            foreach (int num in miArray)
            {
                Console.Write(num + " ");
            }

            // Imprime el tiempo de ejecución en microsegundos
            Console.WriteLine($"\nTiempo de ejecución: {stopwatch.ElapsedTicks / (TimeSpan.TicksPerMillisecond / 1000)} μs");

            // Esperamos a que el usuario presione una tecla para salir
            Console.ReadKey();

        }

        static void ShellSort(int[] arr)
        {
            int n = arr.Length;
            int gap = n / 2;

            while (gap > 0)
            {
                for (int i = gap; i < n; i++)
                {
                    int temp = arr[i];
                    int j = i;

                    while (j >= gap && arr[j - gap] > temp)
                    {
                        arr[j] = arr[j - gap];
                        j -= gap;
                    }

                    arr[j] = temp;
                }

                gap /= 2;
            }
        }
    }
}
