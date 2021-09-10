using System;
using System.Globalization;
using System.Collections.Generic;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            double preco = 100;
            double desconto = (preco < 20) ? preco * 0.10 : preco * 0.05;

           Console.WriteLine(desconto);
        }
    }
}
