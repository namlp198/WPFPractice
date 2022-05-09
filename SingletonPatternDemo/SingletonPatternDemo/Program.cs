using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Start: {SingletonDemo.Instance.Count}");
            SingletonDemo.Instance.Increase();
            Console.WriteLine($"First: {SingletonDemo.Instance.Count}");
            SingletonDemo.Instance.Increase();
            Console.WriteLine($"Second: {SingletonDemo.Instance.Count}");
            SingletonDemo.Instance.Increase();
            Console.WriteLine($"Three: {SingletonDemo.Instance.Count}");

            //if (singletonDemo1 == singletonDemo2)
            //    Console.WriteLine("Only have a object");
            //else
            //    Console.WriteLine("Not only");
            Console.ReadLine();
        }
    }
}
