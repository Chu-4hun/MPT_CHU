using System;

namespace MPT_CH
{
    class Program
    {
        static double seven(double a, double b, double c)
        {
            return (((2 * c) - Math.Log10(b / 4)) / (a * a - 1));
        }
        static double eleven(double a, double b, double c)
        {
            return (((2 * c) -(b*Math.Sqrt(42)))/(c+a-1));
        }
        static void Main(string[] args)
        {
            Console.Write("Ответ: " + eleven(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine())));






            /*// Задача №3
            double a, c, d;
            a = Convert.ToDouble(Console.ReadLine());
            d = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ответ: " + ((Math.Atan(c / 4) - d * 62) / (a * a - 1)));
*/
            /*Задача №2
              double a,n;
              a = Convert.ToDouble(Console.ReadLine());
              n = Convert.ToDouble(Console.ReadLine());
              Console.Write("Ответ" + ((((a * a) / (a + n)) - ((a * a) / (a * a + n * n + 2 * a * n))) / (((a * a) / (a - n)) - ((a * a) / (a * a - n * n)))));*/

            //Задача №1
            //double x,y;
            //x = Convert.ToDouble(Console.ReadLine());
            //y = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Ответ"+(Math.Pow(x, 5) + Math.Pow(y, 2)) / (Math.Pow(y, 7) + Math.Pow(y, 5)));
        }
    }
}
