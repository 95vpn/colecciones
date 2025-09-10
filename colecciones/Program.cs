using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace colecciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();

            /*
            numeros.Add(5);
            numeros.Add(6);
            numeros.Add(7);
            */

            int[] listaNumeros = new int[] {3, 6, 8, 2, 4}; 

            for(int i = 0; i < 5; i++)
            {
                numeros.Add(listaNumeros[i]);
            }

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(numeros[i]);
            }
        }
    }
}
