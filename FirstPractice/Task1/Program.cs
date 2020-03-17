using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            short a = 150;
            object o = a;
            sbyte b = (sbyte)(short)o;
            Console.WriteLine(b);
            Console.WriteLine(b.GetType());
        }
    }
}