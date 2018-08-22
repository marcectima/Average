using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, e, f, g, h, i, j, x, Percentage;
            Console.WriteLine("Enter the projects grades below.");
            Console.WriteLine("Project Python");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Project C#");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Project JavaScript");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Project Java");
            d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Project C++");
            e = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Project C");
            f = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Project HTML");
            g = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Project Asp.net");
            h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Project SQL");
            i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Project NET+");
            j = Convert.ToInt32(Console.ReadLine());
            x = (a + b + c + d + e + f + g + h + i + j) / 10;
            Console.Write(" Total Grade Average :" + x + "% ");
            x = Convert.ToInt32(x);
            Percentage = x;
            if (Percentage >= 96)
            {
                Console.WriteLine("A+");
            }
            else if (Percentage >= 93)
            {
                Console.WriteLine("A");
            }
            else if (Percentage >= 90)
            {
                Console.WriteLine("A-");
            }
            else if (Percentage >= 87)
            {
                Console.WriteLine("B+");
            }
            else if (Percentage >= 83)
            {
                Console.WriteLine("B");
            }
            else if (Percentage >= 80)
            {
                Console.WriteLine("B-");
            }
            else if (Percentage >= 77)
            {
                Console.WriteLine("C+");
            }
            else if (Percentage >= 73)
            {
                Console.WriteLine("C");
            }
            else if (Percentage >= 70)
            {
                Console.WriteLine("C-");
            }
            else if (Percentage <= 69)
            {
                Console.WriteLine("Fail");
            }
            Console.ReadKey();

        }

    }

}