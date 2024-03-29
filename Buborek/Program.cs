﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace Buborek
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] t = new int[80000];

            Stopwatch stopper = new Stopwatch();


            Beolvas(t);

            Console.WriteLine("Buborék rendezés");

            stopper.Start();

            for (int i = t.Length - 1; i >= 1; i--)
            {
                for (int j = 0; j <= i - 1; j++)
                {
                    if (t[j] > t[j + 1])
                    {
                        int temp = t[j];
                        t[j] = t[j + 1];
                        t[j + 1] = temp;
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
