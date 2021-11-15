using System;

namespace Question8
{
    class Program
    {
        static void Main(string[] args)
        {   
            // Write a program that, depending on the user’s choice, inputs int, double
            //      or string variable. If the variable is int or double, the program 
            // increases it by 1. If the variable is a string, the program appends "*" at 
            //   the end. Print the result at the console. Use switch statement.  
        
            Console.WriteLine("Enter number 0 for int, 1 for double and 2 for string");
            int answer= int.Parse( Console.ReadLine());
            double sum=1;
            string append= "*";
            switch (answer)
            {
                case 0:
                   Console.WriteLine("Enter Input to see its increase");
                   int input= int.Parse(Console.ReadLine());
                   sum= sum+input;
                   Console.WriteLine(sum);
                 break;

                 case 1:
                    Console.WriteLine("Enter A decimal number To See Its Increase");
                    double result= double.Parse(Console.ReadLine());
                    sum= sum + result;
                    Console.WriteLine(sum);
                 break;
                 case 2 :
                    Console.WriteLine("Enter a word!");
                    string word= Console.ReadLine();
                    append= word + append;
                    Console.WriteLine(append);
                 break;
                 default:
                    Console.WriteLine("The Number you entered is invalid!");
                 break;
                
            
            }
            


          



        }
    }
}
