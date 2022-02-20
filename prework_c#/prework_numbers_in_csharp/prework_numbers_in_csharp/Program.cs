using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prework_numbers_in_csharp
{
    class Program
    {
        static void Main(string[] args)
        {

            //WorkWithIntegers();
            //OrderPrecedence();
            CircleArea();
          

            Console.ReadKey();
        }

        static void CircleArea()
        {
            double Pi = Math.PI;
            double radious = 2.5;

            double area = Pi * PowerOf(radious, 2);
            Console.WriteLine($"The area of the circle is: {area}");
        }

        static double PowerOf(double number, int index)
        {
            double power = number;
            for(int i = 1; i < index; i++)
            {   
                if(index == 0 || index == 1)
                {
                    power = 1;
                }
                power *= number;
            }
            return power;
        }


       static void WorkWithIntegers()
        {
            int a = 5;
            int b = 4;
            int c = 2;
            int d = a + b * c;
            Console.WriteLine(d);

            int e = 7;
            int f = 4;
            double g = 3;
            double h = (e + f) / g;
            Console.WriteLine(h);
        }

        static void OrderPrecedence()
        {
            int a = 5;
            int b = 4;
            int c = 2;
            int d = a + b * c;
            Console.WriteLine(d);

            d = (a + b) * c;
            Console.WriteLine(d);

            d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
            Console.WriteLine(d);

            int e = 7;
            int f = 4;
            int g = 3;
            int h = (e + f) / g;
            Console.WriteLine(h);
        }
    }
}
