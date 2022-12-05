using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beszuro
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] t = new int[80000];

            Beolvas(t);

            Stopwatch stopper = new Stopwatch();

            Console.WriteLine("Beszúró rendezés");

            stopper.Start();

            for (int i = 1; i < t.Length; i++)
            {
                int j = i - 1;
                while (j >= 0 && t[j] > t[j + 1])
                {
                    int temp = t[j];
                    t[j] = t[j + 1];
                    t[j + 1] = temp;
                    j = j - 1;
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
