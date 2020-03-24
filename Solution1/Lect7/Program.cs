using System;

namespace Lect7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Task_1();
            Task_2();
            Task_3();
        }
        static void Task_1()
        {
            int[] data0;
            //Возможно
        }
        static void Task_2()
        {
            object[] data = new object[3] { 32, 'A', "Hello" };
            foreach (var x in data)
            {
                Console.WriteLine(x);
            }
            data[0] = (int)data[0] + 10;
            data[2] = (string)data[2] + ", guys";
            foreach (var x in data)
            {
                Console.WriteLine(x);
            }
        }
        static void Task_3()
        {
            Random rnd = new Random();
            int[] data1 = new int[13];
            for (int x = 0; x < 13; x++)
            {
                data1[x] = rnd.Next();
            }
            foreach (var y in data1)
            {
                Console.Write(y);
                Console.Write(" ");
            }
            int index_max = 0;
            for (int z = 1; z < 13; z++)
            {
                if (data1[z] > data1[z - 1])
                {
                    index_max = z;
                }
            }
            Console.WriteLine();
            Console.WriteLine(data1[index_max]);
        }
    }
}
