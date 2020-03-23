using System;

namespace Lect5.Greeting
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan date1 = DateTime.Now.TimeOfDay;
            int r = date1.Hours;
            if (r >=9 && r < 12)
            {
                Console.WriteLine("Good morning, guys!");
            }
            else
            {
                if (r >= 12 && r < 15)
                {
                    Console.WriteLine("Good day, guys!");
                }
                else
                {
                    if (r >= 15 && r < 22)
                    {
                        Console.WriteLine("Good evening, guys!");
                    }
                    else
                    {
                        Console.WriteLine("Sleep!");
                    }
                }
            }
        }
    }
}
