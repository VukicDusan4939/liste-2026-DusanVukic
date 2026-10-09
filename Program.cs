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
            //Console.WriteLine(sledeci);
            sledeci=q.Dequeue();
            //Console.WriteLine(sledeci);

            // lista slogova
            List<grana> grane;
            grane = new List<grana>();
            // jedan slog pravim i popunjavam
            grana nova = new grana();
            nova.cvor = 2;
            nova.tezina = 5;
            //i ubacim u listu
            grane.Add(nova);
            nova = new grana();
            nova.cvor = 3;
            nova.tezina = 6;
            grane.Add(nova);
            nova = new grana();
            nova.cvor = 5;
            nova.tezina = 10;
            grane.Add(nova);
            Console.WriteLine(grane[1].cvor);
            Console.WriteLine(grane[2].tezina);

        }
    }
}
