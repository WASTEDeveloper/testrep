using System;
using addSubMulDiv;

namespace trying
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 2 числа: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine(Class1.Add(a, b));
            Console.WriteLine(Class1.Sub(a, b));
            Console.WriteLine(Class1.Mul(a, b));
            Console.WriteLine(Class1.Div(a, b));
        }
    }
}
