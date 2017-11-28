using System;
using System.Collections.Generic;

namespace BoxingPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> list = new List<object>();
            list.Add(7);
            list.Add(28);
            list.Add(-1);
            list.Add(true);
            list.Add("chair");
            int sum = 0;
            foreach(var item in list)
            {
                if(item is int)
                {
                    Console.WriteLine("Int: " + item);
                    sum += (int)item;
                }
                else if(item is bool)
                {
                    Console.WriteLine("Bool: " + item);
                }
                else if(item is string)
                {
                    Console.WriteLine("String: " + item);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Sum: " + sum);
        }
    }
}
