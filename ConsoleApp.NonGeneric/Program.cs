using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp.NonGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("demo");
            list.Add("demo1");
            list.Add("dem1");
            list.Add("dem112");
           // list.Clear();
            Console.WriteLine("-----------------");
            Console.WriteLine(list[1]);
            Console.WriteLine("--------salm-----------");
            
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
