using System;

namespace Lect5.LetterA
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            int i = a.Length;
            int r = 0;
            for (int x = 0; x < i; x++)
            {
                if (a[x] == 'a')
                {
                    r++;
                }
            }
            Console.WriteLine(r);
        }
    }
}
