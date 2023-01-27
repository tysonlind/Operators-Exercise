using System.ComponentModel;

namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Divide(17, 4);
            Console.WriteLine("What is the radius of your circle?");
                double radius = double.Parse(Console.ReadLine());
            double radiusCalc = CalculateRadius(radius);
            Console.WriteLine($"The area of a circle with the radius of {radius} is {radiusCalc}");
        }
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Subtract(int a, int b)
        {
            return a - b;
        }
        public static int Multiply(int a, int b)
        {
            return a * b;
        }
        public static void Divide(int a, int b)
        {
            int quotient = a / b;
            int remainder = a % b;
            Console.WriteLine($"{a}/{b} is {quotient} with a remainder of {remainder}");
        }
        public static int Modulus(int a, int b)
        {
            return a % b;
        }
        public static double CalculateRadius(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
