using System;

namespace Question9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*   We are given 5 integer numbers. Write a program that finds those subsets whose sum is 0. Examples:
              - If we are given the numbers {3, -2, 1, 1, 8}, the sum of -2, 1 and 1 is 0.
              - If we are given the numbers {3, 1, -7, 35, 22}, there are no subsets with sum 0.  */


              Console.WriteLine("Enter First number");
              int m= int.Parse(Console.ReadLine());

              Console.WriteLine("Enter  2nd number");
              int w= int.Parse(Console.ReadLine());

              Console.WriteLine("Enter 3rd number");
              int x = int.Parse(Console.ReadLine());

              Console.WriteLine("Enter 4th number");
              int y= int.Parse(Console.ReadLine());

              Console.WriteLine("Enter 5th number");
              int z= int.Parse(Console.ReadLine());
              
              if(m + w ==0)
              {
               Console.WriteLine($"{m} {w}");
              }
              if(m+w+x==0)
              {
                Console.WriteLine($"{m} {w} {x}");
              }
              if(m+w+x+y==0)
              {
                  Console.WriteLine($"{m} {w} {x} {y}");
              }
              if(m+w+x+y+z==0)
              {
                  Console.WriteLine($"{m} {w} {x} {y} {z}");
              }
              if(w+x==0)
              {
                  Console.WriteLine($" {w} {x} ");
              }
              if(w+x+y==0)
              {
                  Console.WriteLine($" {w} {x} {y} ");
              }
              if(w+x+y+z==0)
              {
                  Console.WriteLine($"{w} {x} {y} {z}");
              }
              if(x+y==0)
              {
                  Console.WriteLine($" {x} {y} ");
              }
              if(x+y+z==0)
              {
                  Console.WriteLine($"{x} {y} {z}");
              }
              if(y+z==0)
              {
                  Console.WriteLine($"{y} {z}");
              }
              else
              {
                  Console.WriteLine("There are no subsets with sum 0");
              }


        }
    }
}
