﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3Csharp
{
    internal class Program
    {
        public void Add()
        {
            int a = 10, b = 20, c = a + b;
            Console.WriteLine(c);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Add();

            Console.ReadLine();
        }
    }
}
