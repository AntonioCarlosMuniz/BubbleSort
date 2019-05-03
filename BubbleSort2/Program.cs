using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort2
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * Deixei um codigo funcional de outra forma de fazer o bubbleSort. 
             * OBS nao consegui melhorar a adicao na colecao
             */
            Random rnd = new Random();
            List<numerosAleatorios> num = new List<numerosAleatorios>()
            {
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },
                new numerosAleatorios() { numeros = rnd.Next(0, 100) },

            };


            var ordNum = num.OrderBy(x => x.numeros);

            foreach (var val in ordNum)
            {
                Console.WriteLine(val.numeros);
            }

            Console.ReadKey();

    
        }

        class numerosAleatorios
        {
            public int numeros { get; set; }

        }
    }
}
