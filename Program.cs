using System;

namespace Bingo
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 1;
            int max = 15;
            string marcar;

            int[,] carton = new int[5, 5];
            var aleatorio = new Random();

            for (int i=0; i<carton.GetLength(0); i++)
            {
                for (int j = 0; j < carton.GetLength(0); j++)
                {
                    if (i == 2 && j == 2)
                    {
                        carton[i, j] = 0;
                    }
                    else
                    {
                        carton[j, i] = aleatorio.Next(min, max);
                    }
                }
                min+=15;
                max+=15;
            }
            Carton tablero1 = new Carton(carton);

            Console.WriteLine(tablero1.imprimirTabla());

            for(int i=0;i<26;i++)
            {
                marcar = Console.ReadLine();
                tablero1.Marcar(marcar);
                Console.WriteLine(tablero1.imprimirTabla());
            }

            Console.ReadKey();

















        }
    }
}
