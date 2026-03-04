using System;
using System.Numerics;

namespace ValueExample
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myclass = new MyClass();
            myclass.a = 7;
            MyClass myclass2 = myclass;
            myclass2.a = 15;
            Console.WriteLine(myclass.a); // Output: 15

            int a = 1;
            int b = a;
            b = 5;
            Console.WriteLine(a);  // Output: 1
        }
    }

    public class MyClass
    {
        public int a;
    }
}