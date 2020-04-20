using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    class Program
    {
        
        static void Main(string[] args)
        {
            ////Colecciones genericas.
            ////List.------------------------------------------
            ////Que tengan <> significa que es generico y puedo meter el tipo de dato que quiera.
            //List<string> lista = new List<string>();
            //lista.Add("Yago");
            //lista.Add("Cami");
            //lista.Add("Maggie");

            ////lista.Remove("Yago");
            ////lista.RemoveAt(2);//remueve por indice.

            //lista.Sort(Program.Ordenar);

            //foreach (string item in lista)
            //{
            //    Console.WriteLine(item);
            //}

            //for (int i = 0; i < lista.Count; i++)
            //{
            //    Console.WriteLine(lista[i]);
            //}

            //---------------------------------------------------------------------------------------------------------
            //Dictionary.------------------------------------------
            //Estan indexados por la key, no por la posición.
            //Dictionary<int, string> dic = new Dictionary<int, string>();
            //dic.Add(1, "Cami");
            //dic.Add(2, "Maggie");
            //dic.Add(21, "Yago");

            //foreach (KeyValuePair<int,string> item in dic)
            //{
            //    Console.WriteLine("{0} : {1}", item.Key, item.Value);
            //}

            //---------------------------------------------------------------------------------------------------------
            //Queue(cola).------------------------------------------
            //Queue<string> cola = new Queue<string>();
            //cola.Enqueue("Valor1");//encolar
            //cola.Enqueue("Valor2");
            //cola.Enqueue("Valor3");

            //while(cola.Count > 0)
            //{
            //    Console.WriteLine(cola.Dequeue());//desencolar
            //}

            //---------------------------------------------------------------------------------------------------------
            //Stack.------------------------------------------
            Stack<int> pila = new Stack<int>();
            pila.Push(150);
            pila.Push(15);
            pila.Push(1000);
            pila.Push(250);

            while (pila.Count > 0)
            {
                Console.WriteLine(pila.Pop());//desencolar
            }

            Console.ReadKey();
        }
        public static int Ordenar(string s1, string s2)
        {
            int aux;
            if (s1.CompareTo(s2) > 0)
            {
                aux = 1;
            }
            else if (s1.CompareTo(s2) < 0)
            {
                aux = -1;
            }
            else
            {
                aux = 0;
            }
            return aux;//si a aux le pongo "-"aux, me duelve todo al reves.

        }
    }
}
