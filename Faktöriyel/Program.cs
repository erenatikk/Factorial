using System;

namespace Faktöriyel
{
    class Program
    {

        
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter a number");
            int i;
            int number = int.Parse(Console.ReadLine());
            int result = 1;
            for (i = 1; i <= number ;i++)
            {
                result *= i;
                
            }
            Console.WriteLine(result);
        }
    }
}
