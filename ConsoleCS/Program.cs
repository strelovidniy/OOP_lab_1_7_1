using System;

namespace ConsoleCS
{
    public class Program
    {
        static public int parse(int a)
        {
            int c = (a / 100) * 10;
            c += a % 10;
            return (c);
        }
        static void Main(string[] args)
        {
            string S = Console.ReadLine();
            int a = parse(int.Parse(S));
            Console.Write("d1 = ");
            Console.Write(a / 10);
            Console.Write(", d2 = ");
            Console.Write(a % 10);
            Console.ReadKey();
        }
    }
}
