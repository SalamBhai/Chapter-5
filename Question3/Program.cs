using System;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*    Write a program that finds the biggest of three integers,
             using nested if statements. */
       
             int max=0;
             Console.WriteLine("Enter First Number");
             int a= int.Parse(Console.ReadLine());
             Console.WriteLine("Enter Second Number");
             int b= int.Parse(Console.ReadLine());
              Console.WriteLine("Enter Third Number");
              int c= int.Parse(Console.ReadLine());

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
             } Console.WriteLine("The biggest of The Three Numbers is " +max);          
           
        } 
    }
}
