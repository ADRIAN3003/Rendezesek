using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace EgyszeruCsere
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] t = new int[80000];

            Stopwatch stopper = new Stopwatch();

            Beolvas(t);

            Console.WriteLine("Egyszerű csere rendezés");

            stopper.Start();

            for (int i = 0; i < t.Length - 1; i++)
            {
                for (int j = i + 1; j < t.Length; j++)
                {
                    if (t[i] > t[j])
                    {
                        int temp = t[i];
                        t[i] = t[j];
                        t[j] = temp;
                    }
                }
            }

            stopper.Stop();

            //foreach (var item in t)
            //{
            //    Console.Write($"{item} ");
            //}

            Console.WriteLine(stopper.ElapsedMilliseconds);

            Console.ReadKey();
        }

        private static void Beolvas(int[] t)
        {
            using (StreamReader sr = new StreamReader("adatok.txt"))
            {
                int i = 0;
                while (!sr.EndOfStream)
                {
                    t[i++] = Convert.ToInt32(sr.ReadLine());
                }
            }
        }
    }
}
