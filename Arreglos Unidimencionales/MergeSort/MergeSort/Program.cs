using System;
using System.Diagnostics;

namespace MergeSort
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
            MergeSort(miArray, 0, tamaño - 1);
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

        static void Merge(int[] arr, int inicio, int medio, int fin)
        {
            int n1 = medio - inicio + 1;
            int n2 = fin - medio;

            int[] L = new int[n1];
            int[] R = new int[n2];

            int i, j, k;

            for (i = 0; i < n1; i++)
            {
                L[i] = arr[inicio + i];
            }

            for (j = 0; j < n2; j++)
            {
                R[j] = arr[medio + 1 + j];
            }

            i = 0;
            j = 0;
            k = inicio;

            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }

            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }

        static void MergeSort(int[] arr, int inicio, int fin)
        {
            if (inicio < fin)
            {
                int medio = inicio + (fin - inicio) / 2;

                MergeSort(arr, inicio, medio);
                MergeSort(arr, medio + 1, fin);

                Merge(arr, inicio, medio, fin);
            }
        }
    }
}
