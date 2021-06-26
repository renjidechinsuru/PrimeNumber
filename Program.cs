using System;

namespace PrimeNumber
{
    class Program
    {
        // Write a function called PrimeNumber() that takes one integer number as parameter. The function will find if the number is prime or not and then print the results on the screen
        static void Main(string[] args)
        {
            int num, i, count = 0;
            Console.WriteLine("Please enter a number");
            num = Convert.ToInt32(Console.ReadLine());



            for (i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }
            }

            if (count == 2)
            {
                Console.WriteLine(num.ToString() + " is a Prime Number");
            }

            else
            {
                Console.WriteLine(num.ToString() + " is not a prime Number");
                    

            }

        }
          
               
            
           
      
            



        
    }
}
