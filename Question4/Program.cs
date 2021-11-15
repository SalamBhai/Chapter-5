using System;

namespace Question4
{
    class Program
    {
        static void Main(string[] args)
        {
          /* Sort 3 real numbers in descending order. Use nested if statements*/

            Console.WriteLine(" Enter Number 1");
            int x= int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Second Number");
            int y= int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Third Number");
            int z= int.Parse(Console.ReadLine());
           
            if(x > y && x > z)
            {
                Console.WriteLine($"The Numbers Are In {x}, {y}, and {z} respectively");
            }
            if (y > z && y > x )
            {
                Console.WriteLine($"The Numbers in descending order are {y} {x} and {z} respectively.");
            }
            if(z > y && z > x )
            {
              Console.WriteLine($"The Numbers in descending order are {z} {x} and {y} respectively.");
            }











        }
    }
}
