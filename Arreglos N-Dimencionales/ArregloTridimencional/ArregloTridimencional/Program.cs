using System;

namespace ArregloTridimencional
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Crear un arreglo tridimensional de 3x20x3
            int[,,] arreglo = new int[3, 20, 3];

            // Crear un objeto Random para generar números aleatorios
            Random rnd = new Random();

            // Llenar el arreglo con números aleatorios
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        arreglo[i, j, k] = rnd.Next(1, 181); // Generar un número aleatorio entre 1 y 100
                    }
                }
            }

            // Imprimir el arreglo en formato tridimensional
            for (int j = 0; j < 20; j++)
            {
                Console.WriteLine("Plano " + (j + 1));
                for (int i = 0; i < 3; i++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        Console.Write("#" + arreglo[i, j, k].ToString("00") + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            int y = 0;
            int x = 0;
            int z = 0;
            do
            {
                if (y%3 == 0)
                {
                    x = 0;
                }
                x++;
                y++;

                int valor = arreglo[x, y, z];
                Console.WriteLine("Valor en (" + x + "," + y + "," + z + "): " + valor);
            } while (y < 20);
        }
    }
}
