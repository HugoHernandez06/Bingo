using System;
using System.Collections.Generic;
using System.Text;

namespace Bingo
{
    class Carton
    {
        private string[] tabla1;
        private int[,] carton1;
        public Carton( int[,]carton)
        {
            Carton1 = carton;
        }

        public string[] Tabla1 { get => tabla1; set => tabla1 = value; }
        public int[,] Carton1 { get => carton1; set => carton1 = value; }

        public string imprimirTabla()
        {
            string matriz = "";

            for(int i =0; i<carton1.GetLength(0); i++)
            {
                for(int j =0; j< carton1.GetLength(0); j++)
                {
                    matriz += carton1[i, j] + " | ";
                }
                matriz += "\n";
            }
            Console.WriteLine("  B " + "  I " + "  N " + "  G " + "  O ");
            return matriz ;
        }
        public int [,]Marcar(string ubicacion)
        {
            string[] split = (ubicacion.Split(','));
            for(int i=0; i < carton1.GetLength(0); i++)
            {
                for (int j = 0; j < carton1.GetLength(0); j++)
                {
                    if (i == Convert.ToInt32(split[0]) && j == Convert.ToInt32(split[1]))
                    {
                        carton1[i, j] = 0;
                    }
                }
            }
            return carton1;
        }


    }
}
