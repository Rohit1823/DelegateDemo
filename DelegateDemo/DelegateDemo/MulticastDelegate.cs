using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateDemo
{
    class MulticastDelegate
    {
        delegate void Devlop(int x, int y);
        public static void ImplementDelegate()
        {
            Devlop obj = Operation.Add;
            obj += Operation.Square;
            obj(5, 5);
            obj(8, 3);
        }
    }
    public class Operation
    {
        public Operation(int a)
        {
            Console.WriteLine(a);
        }
        public static void Add(int a, int b)
        {
            Console.WriteLine("Addition = {0}", a + b);
        }
        public static void Square(int a, int b)
        {
            Console.WriteLine("Multiple = {0}", a * b);
        }
    }

}
