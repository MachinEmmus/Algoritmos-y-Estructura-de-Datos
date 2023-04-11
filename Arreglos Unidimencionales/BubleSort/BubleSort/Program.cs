using System;
using System.Diagnostics;

namespace BubleSort
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
            BubbleSort(miArray);
            stopwatch.Stop();

            // Imprime el arreglo ordenado
            Console.WriteLine("\nEl arreglo ordenado es:");
            foreach (int num in miArray )
            {
                Console.Write(num + " ");
            }

            // Imprime el tiempo de ejecución en microsegundos
            Console.WriteLine($"\nTiempo de ejecución: {stopwatch.ElapsedTicks / (TimeSpan.TicksPerMillisecond / 1000)} μs");

            // Esperamos a que el usuario presione una tecla para salir
            Console.ReadKey();
        }

        static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
    }

}
