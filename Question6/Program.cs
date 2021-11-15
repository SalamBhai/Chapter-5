using System;

namespace Question6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*   Write a program that gets the coefficients a, b and c of a quadratic 
            equation: ax
             2 + bx + c, calculates and prints its real roots (if they exist). 
              Quadratic equations may have 0, 1 or 2 real roots.   */

             Console.WriteLine("Enter Co-efficient a");
             double a= int.Parse(Console.ReadLine());

             Console.WriteLine("Enter Co-efficient of b");
             double b= int.Parse(Console.ReadLine());

             Console.WriteLine("Enter Co-efficient of C");
             double c= int.Parse(Console.ReadLine());

             double discriminant= (b * b) - (4*(a*c));

           if(discriminant==0)
           {
               Console.WriteLine("The Quadratic Equation Has One Double Real Root And it Is Calculated as x below");
                  double x= -b/2*a;
                  Console.WriteLine(x);
           }
           else if(discriminant > 0)
           {
               Console.WriteLine("The Quadratic Equation Has Two Distinct Real Roots");
               double x1= -b + Math.Sqrt((b*b) - (4 * (a*c) ) ) / 2 * (a);
               double x2= -b - Math.Sqrt((b*b) - (4 * (a*c)))/ 2 * (a);
               Console.WriteLine(x1);
               Console.WriteLine(x2);
           }
           else
           {
               Console.WriteLine("The Quadratic Equation has no real roots");
           }
           
           



        }
    }
}
