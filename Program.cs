using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace liste_2026_DusanVukic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int [] x;
            //niz
            x = new int[5];
            Console.WriteLine(x[1]);
            // matrica
            string[,] y;
            y = new string[3,4];
            */
            //liste
            List<int> z;
            z = new List<int>();
            z.Add(1);
            z.Add(2);
            //Console.WriteLine(z[2]);
            //stek
            Stack<int> a;
            a = new Stack<int>();
            a.Push(1);
            a.Push(2);
            a.Push(3);
            int u = a.Pop();
            //Console.WriteLine(u);

            //red
            Queue <string> q;
            q = new Queue<string>();
            q.Enqueue("Andrej");
            q.Enqueue("Aleksa");
            q.Enqueue("Jaksa");
            string sledeci = q.Dequeue();
            Console.WriteLine(sledeci);
            sledeci=q.Dequeue();
            Console.WriteLine(sledeci);
        }
    }
}
