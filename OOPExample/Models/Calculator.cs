using OOPExample.Interfaces;

namespace OOPExample.Models
{
    public class Calculator : ICalculator
    {
        // public int Divide(int num1, int num2) // no error even when the method isn't implemented
        // {
        //     return num1 / num2;
        // }

        public int Divide(int num1, int num2)
        {
            Console.WriteLine("This is not the default implementation of the Divide method.");
            return num1 / num2;
        }

        public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Sum(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }
    }
}