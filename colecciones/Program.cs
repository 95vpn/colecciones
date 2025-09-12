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
            //List<int> numeros = new List<int>();

            /*
            numeros.Add(5);
            numeros.Add(6);
            numeros.Add(7);
            */

            /*
            int[] listaNumeros = new int[] {3, 6, 8, 2, 4}; 

            for(int i = 0; i < 5; i++)
            {
                numeros.Add(listaNumeros[i]);
            }

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(numeros[i]);
            }
            */

            /*
            Console.WriteLine("¿Cuantos elementos quieres introducir?");

            int elem = Int32.Parse(Console.ReadLine());

            for(int  i = 0; i < elem; i++)
            {
                numeros.Add(Int32.Parse(Console.ReadLine()));
            }


            for (int i = 0; i < elem; i++)
            {
                Console.WriteLine(numeros[i]);
            }
            */

            /*
            Console.WriteLine("Introduce elementos en l colección (0 para salir)");

            int elem = 1;

            while (elem != 0)
            {
                elem = Int32.Parse(Console.ReadLine());

                numeros.Add(elem);
            }

            numeros.RemoveAt(numeros.Count-1);

            Console.WriteLine("Elemento introducidos: ");

            foreach (var item in numeros)
            {
                Console.WriteLine(item);
            }
            */

            LinkedList<int> numeros = new LinkedList<int>();

            foreach (int numero in new int[] { 10, 8, 6, 4, 2, 0 }) 

            {
                numeros.AddFirst(numero);
            }

            /*
            foreach(int numero in numeros)
            {
                Console.WriteLine(numero);
            }
            */

            for(LinkedListNode<int> nodo = numeros.First; nodo != null; nodo = nodo.Next)
            {
                Console.WriteLine(nodo.Value); 
            }
        }
    }
}
