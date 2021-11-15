using System;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            
           /* Write a program that shows the sign (+ or -) of the product of three real numbers, 
           without calculating it. Use a sequence of if operators*/
           Console.WriteLine("Enter first Number");
           int x= int.Parse(Console.ReadLine());
           Console.WriteLine("Enter Second Number");
           int y= int.Parse(Console.ReadLine());
           Console.WriteLine("Enter Third Number");
           int z= int.Parse(Console.ReadLine());

           if(x>0|| y<0 || z<0)
           {
            Console.WriteLine("The result of the products of these three integers is  negative");
           }
           
           else if( x >0 || y>0 || z>0)
           {
               Console.WriteLine("The result of the products of these three integers is positive");
           }
           else if (x<0 || y>0 || z<0)
           {
               Console.WriteLine(" The result of the products of these three integers is positive");
           }

        }
    }
}
