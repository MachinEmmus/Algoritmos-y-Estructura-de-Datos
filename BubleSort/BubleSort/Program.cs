using System;

namespace BubleSort
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] arr = { 5, 2, 7, 3, 1, 8, 6, 9, 4 };

            Console.WriteLine("Arreglo antes de ser ordenado:");
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }

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

            Console.WriteLine("\nArreglo ordenado:");
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }

            Console.ReadLine();
        }
    }
}
