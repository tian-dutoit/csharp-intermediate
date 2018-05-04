using System;

namespace csharp_intermediate
{
    public class Calculator {
        public int Add (params int[] numbers) {
            var sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }
            return sum;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            System.Console.WriteLine(calculator.Add(1, 2));
        }
    }
}
