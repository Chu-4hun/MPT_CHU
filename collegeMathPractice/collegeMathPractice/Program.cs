using System;

namespace collegeMathPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Double c = Convert.ToDouble(Console.ReadLine());
            Double d = Convert.ToDouble(Console.ReadLine());
            Double a = Convert.ToDouble(Console.ReadLine());

            Double res = ((Math.Atan(c / 4) - d * 62) / (a*a-1));
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}