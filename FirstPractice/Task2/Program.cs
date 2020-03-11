using System;
using System.Collections;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            //int Add(object? value)
            arrayList.Add(45); //true, box
            arrayList.Add(true); //true, box
            arrayList.Add("Hello"); //false
            arrayList.Add(23.45); //true, box
        }
    }
}