using System;

namespace lect14.task1
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassString str = new ClassString();
            str.FormatString("Hello, guys!");
            Console.WriteLine(str.text);
        }
    }
}
