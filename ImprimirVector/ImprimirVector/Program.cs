using System;

namespace ImprimirVector
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Pedimos al usuario el tamaño del array
            Console.WriteLine("Ingrese el tamaño del array:");
            int tamaño = Convert.ToInt32(Console.ReadLine());

            // Definimos un array de enteros con el tamaño ingresado por el usuario
            int[] miVector = new int[tamaño];

            // Llenamos el array con valores aleatorios entre 0 y 100
            Random rnd = new Random();
            for (int i = 0; i < tamaño; i++)
            {
                miVector[i] = rnd.Next(1, (tamaño + 1)); // Genera un número aleatorio entre 0 y 100
            }

            // Imprime el arreglo generado
            Console.WriteLine("El arreglo generado es:");
            foreach (int num in miVector)
            {
                Console.Write(num + " ");
            }

            // Esperamos a que el usuario presione una tecla para salir
            Console.ReadKey();
        }
    }
}
