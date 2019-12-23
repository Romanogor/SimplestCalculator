using System;

namespace SimplestCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            ILoggerManager loggerManager = new LoggerManager();
            var calculator = new Calculator(loggerManager);

            Console.WriteLine("Please Insert values for add sepasrated with space");
            var userInput = Console.ReadLine();
            var splittedInput = userInput.Split(" ");

            var addResult = calculator.Add(splittedInput[0], splittedInput[1]);

            Console.WriteLine("Sum result is: " + addResult);

            var substructResult = calculator.Substruct(splittedInput[0], splittedInput[1]);

            Console.WriteLine("Substruct result is: " + substructResult);

            var multiplyResult = calculator.Multiply(splittedInput[0], splittedInput[1]);

            Console.WriteLine("Multiply result is: " + multiplyResult);


            var divideResult = calculator.Divide(splittedInput[0], splittedInput[1]);

            Console.WriteLine("Divide result is: " + divideResult);

            Console.ReadKey();
        }
    }
}
