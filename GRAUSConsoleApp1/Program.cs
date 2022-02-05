using System;

namespace GRAUSConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("graus");
            Console.WriteLine("Quantos graus Celsius voce quer transformar em Fahrenheit?");
            double c = double.Parse(Console.ReadLine());
            double f = c * 1.8 + 32;
            Console.Clear();
            Console.WriteLine($"{c} graus Celsius é equivalente a {f}");
            Console.ReadLine();
        }
    }
}
