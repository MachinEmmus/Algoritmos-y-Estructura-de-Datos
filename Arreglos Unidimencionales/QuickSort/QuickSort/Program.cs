using System;
using System.Diagnostics;

namespace QuickSort
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
            QuickSort(miArray, 0, tamaño - 1);
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

        static void QuickSort(int[] arr, int izquierda, int derecha)
        {
            if (izquierda < derecha)
            {
                int pivot = Partition(arr, izquierda, derecha);
                QuickSort(arr, izquierda, pivot - 1);
                QuickSort(arr, pivot + 1, derecha);
            }
        }

        static int Partition(int[] arr, int izquierda, int derecha)
        {
            int pivot = arr[derecha];
            int i = izquierda - 1;

            for (int j = izquierda; j <= derecha - 1; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    Swap(ref arr[i], ref arr[j]);
                }
            }

            Swap(ref arr[i + 1], ref arr[derecha]);
            return i + 1;
        }

        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
