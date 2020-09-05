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
            //task 10
            Double res1 = ((4*c+d-1)/(c-Math.Tan(a/2)));
            //task 4
            Double res2 = ((Math.Log10(2 * c) + d - 52)/((a/4)+1));
            Console.WriteLine(res1);
            Console.WriteLine(res2);
            Console.ReadKey();
        }
    }
}
