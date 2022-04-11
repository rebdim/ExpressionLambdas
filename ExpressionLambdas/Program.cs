﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionLambdas
{
    public delegate void HelloDelegate();
    class Program
    {
        static void Main(string[] args)
        {
            HelloDelegate hD = () => Console.WriteLine("Hello");

            hD();

            Console.ReadKey();
        }
    }
}
