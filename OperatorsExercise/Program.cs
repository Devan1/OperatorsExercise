using System;

namespace OperatorsExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double r;
            

            Console.Write("What is the first number?: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("What is the second number?: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine();

            double quotient = a / b;
            double remainder = a % b;

            Console.WriteLine($"{a} multiplied by {b} equals {a * b}");
            Console.WriteLine($"{a} added to {b} equals {a + b}");
            Console.WriteLine($"{a} subtracted by {b} equals {a - b}");
            Console.WriteLine($"{a} divided by {b} is {quotient} and the remainder is {remainder}");
            Console.WriteLine();

            Console.Write("What is the radius of your circle?: ");
            r = double.Parse(Console.ReadLine());
            Console.Write($"The area of a circle with the radius of {r} is {AreaOfCircle(r)}");
            Console.WriteLine();
                
            
        }
        
        public static double AreaOfCircle(double r)
        {
            return (Math.PI * (Math.Pow(r, 2)));
        }
        
    }
}
