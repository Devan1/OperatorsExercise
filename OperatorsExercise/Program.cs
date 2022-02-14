using System;

namespace OperatorsExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;
            

            Console.WriteLine($"{a} divided by {b} is {quotient} and the remainder is {remainder}");
            Console.Write("What is the radius of your circle?: ");
            double r = double.Parse(Console.ReadLine());
            Console.Write($"The area of a circle with the radius of {r} is {AreaOfCircle(r)}");
            Console.WriteLine();
                
            
        }
        
        public static double AreaOfCircle(double r)
        {
            return (3.14 * (r*r));
        }
        
    }
}
