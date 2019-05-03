using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();

            int[] numerosAleatorios = new int[100];

            int temp = 0;

            for (int i = 0; i < 100; i++)
            {
                numerosAleatorios[i] = rnd.Next(1, 100);
            }

            numerosAleatorios = NumerosAleatorios(numerosAleatorios);

            for (int i = 0; i < numerosAleatorios.Length; i++)
            {
                Console.WriteLine(numerosAleatorios[i]);
            }
            Console.ReadKey();            
        }

        public static int[] NumerosAleatorios(int[] ret)
        {

            int temp = ret[0];

            for (int i = 0; i < ret.Length; i++)
            {
                for (int j = i + 1; j < ret.Length; j++)
                {
                    if (ret[i] > ret[j])
                    {
                        temp = ret[i];

                        ret[i] = ret[j];

                        ret[j] = temp;
                    }
                }
            }

            return ret;
        }
    }
}

