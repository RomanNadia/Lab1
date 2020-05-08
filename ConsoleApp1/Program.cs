using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        static public double Line(int x1, int y1, int x2, int y2)
        {
            double a;
            a = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return a;
        }

        static public double Example1(double a, double b, double c)
        {
            double P;
            P = a + b + c;
            return P;
        }
        static public double Example2(double P, double a, double b, double c)
        {
            P = P / 2;
            double S;
            S = Math.Sqrt(P * (P - a) * (P - b) * (P - c));
            return P;
        }

        static int Main(string[] args)
        {
            int x1, x2, x3, y1, y2, y3;
            double P, S;
            Console.Write(" Enter x1: ");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Enter y1: ");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Enter x2: ");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Enter y2: ");
            y2 = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Enter x3: ");
            x3 = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Enter y3: ");
            y3 = Convert.ToInt32(Console.ReadLine());
            P = Example1(Line(x1, y1, x2, y2), Line(x2, y2, x3, y3), Line(x1, y1, x3, y3));
            S = Example2(P, Line(x1, y1, x2, y2), Line(x2, y2, x3, y3), Line(x1, y1, x3, y3));
            Console.WriteLine("P = " + P);
            Console.WriteLine("S = " + S);
            Console.ReadKey();
            return 0;
        }
    }
}
