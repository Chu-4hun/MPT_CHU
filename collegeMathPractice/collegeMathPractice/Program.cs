using System;
using System.IO;

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
            
            //task1
                Double res1 = ((2 * c + Math.Sqrt(23) / (a / 4) - 1));
                Console.WriteLine("task 1 = "+res1);
                
            //task 2
                Double res2 = ((c+4*d-Math.Sqrt(123))/(1-a/2));
                Console.WriteLine("task 2 = " + res2);
                
            //task 3
                Double res3 = ((-2*c+d*82)/(Math.Tan(a/4-1)));
                Console.WriteLine("task 3 = " + res3);
                
            //task 4
                Double res4 = ((Math.Log10(2 * c) + d - 52)/((a/4)+1));
                Console.WriteLine("task 4 = "+res4);
            
            // task 5
                Double res5 = (Math.Atan(c / 4) - d * 62) / (a * a - 1);
                Console.WriteLine("Task 5 = " +res5);
                
            //task 6
                Double res6 = ((-2 * c) + d - 52) / (a / 4) - 1;
                Console.WriteLine("task 6 = "+res6);
            
            //task 7
                Double res7 =(((2 * c) - Math.Log10(d / 4)) / (a * a - 1));
                Console.WriteLine("task 7 = " +res7);
                
            //task 8
                Double res8 = ((Math.Tan(c)-d*23)/(2*a-1));
                Console.WriteLine("task 8 = " + res8);
                
            //task 9
                Double res9 = ((2*c-Math.Log10(d/4))/Math.Log10(1-a/4));
                Console.WriteLine("task 9 = " + res9);
                
            //task 10
                Double res10 = ((4*c+d-1)/(c-Math.Tan(a/2)));
                Console.WriteLine("task 10 = "+res10);
                
            //task 11
                Double res11 = (((2 * c) -(d*Math.Sqrt(42)))/(c+a-1));
                Console.WriteLine("task 11 = "+res11);
                
            //task 12
                Double res12 = (Math.Sqrt(25 / c) - d + 2) / (d + a * a - 1);
                Console.WriteLine("task 12 = "+res12);
                
            //task 13
                Double res13 = (Math.Atan(c-d/2)/(2*a-1));
                Console.WriteLine("task 13 = " + res13);
                
            //task 14
                Double res14 = ((4*Math.Log10(c)-d/2+23)/(a*a-1));
                Console.WriteLine("task 14 = " + res14);
                
            //task 15 
                Double res15 = (c * Math.Tan(d + 23))/(a / 2 - 4 * d - 1);
                Console.WriteLine("Task 15 = "+res15);
                
            //task 16
                Double res16 = (c / d + Math.Log10(3 * a / 2)) / c - a + 1;
                Console.WriteLine("task 16 = "+res16);
                
            //task 17
                Double res17 = ((2*c+Math.Log10(d)*51)/(d-a-1));
                Console.WriteLine("task 17 = " + res17);
                
            //task 18 
                Double res18 = (2 * c + Math.Log10(d / 4) + 23) / a * a - 1;
                Console.WriteLine("task 18 = "+res18);
                
            //task 19
                Double res19 = ((42*c-d/2+1)/(a*a-Math.Log10(d-5)));
                Console.WriteLine("task 19 = " + res19);
                
            //task 20
                Double res20 = (Math.Atan(2 * c) / d + 2) / d - a * a - 1;
                Console.WriteLine("task 20 = "+res20);
                
            Console.ReadKey();
        }
    }
}
