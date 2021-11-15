using System;

namespace Question7
{
    class Program
    {
        static void Main(string[] args)
        {
             /* Find The Biggest Of Five Given integers */

             int max=0;
             Console.WriteLine("Enter First Number");
             int a= int.Parse(Console.ReadLine());
             Console.WriteLine("Enter Second Number");
             int b= int.Parse(Console.ReadLine());
              Console.WriteLine("Enter Third Number");
              int c= int.Parse(Console.ReadLine());
              Console.WriteLine("Enter Fourth Number");
              int d= int.Parse(Console.ReadLine());
              Console.WriteLine("Enter Fifth Number");
              int e= int.Parse(Console.ReadLine());

            if (a>max)
            {
             Console.WriteLine(max=a);
            }
            if(b>max)
             {
             Console.WriteLine(max=b);
             }
             if(c>max)
             {
              Console.WriteLine(max=c);
             }  
             if (d>max) 
             {
              Console.WriteLine(max=d);
             }
             if (e>max)
             {
                 Console.WriteLine(max=e);
             } Console.WriteLine($"The Greatsest of the five given integers {a} {b} {c} {d} and {e} is {max}");

            

           

        }
    }
}
