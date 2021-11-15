using System;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write an if-statement that takes two integer variables and exchanges
            // their values if the first one is greater than the second one.
           
           Console.WriteLine("Enter First Number");
           int num1= int.Parse(Console.ReadLine());
           Console.WriteLine("Enter Second Number");
           int num2= int.Parse(Console.ReadLine());
           int a=0;
           int b=0;
           int c=0;

           if(num1 > num2)
           {
               a= num1;
               b= num2;
               c=0;
               c=num1;
               a=num2;
               b=c;
               
           }   
            Console.WriteLine(a);
            Console.WriteLine(b);
          


        
        }
    }
}
