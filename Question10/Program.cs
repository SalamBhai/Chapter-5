using System;

namespace Question10
{
    class Program
    {
        static void Main(string[] args)
        {
            /*   Write a program that applies bonus points to given scores in the range 
               [1…9] by the following rules:
              - If the score is between 1 and 3, the program multiplies it by 10.
                - If the score is between 4 and 6, the program multiplies it by 100.
                   - If the score is between 7 and 9, the program multiplies it by 1000.
                 - If the score is 0 or more than 9, the program prints an error 
                 message.  */
               
               Console.WriteLine("Welcome To BonusMarks! Home To Additional points");

              Console.WriteLine("Enter A Number Between The Range of 1 and 9 ");
              int score= int.Parse(Console.ReadLine());

              if (score>0 && score<=3)
              {
                  Console.WriteLine(score*10);
              }
            else if(score>3 && score<=6)
            {
                Console.WriteLine(score*100);
            }
            else if(score>6 && score<=9)
            {
                Console.WriteLine(score*1000);
            }
           else
           {
               Console.WriteLine("Error! ");
           }                  



        }
    }
}
