using System;

namespace Nth_fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt user to enter a temperature in Fahrenheit
            Console.Write("Enter a positive whole number in Fibonacci sequence: ");

            var numberPrompt = Console.ReadLine();

            // Check if entered values is a number
            int nthNumber;
            while ((!int.TryParse(numberPrompt, out nthNumber)) || (int.Parse(numberPrompt) < 0))
            {
                Console.Write("This is not positive whole number! Please enter a positive whole number in Fibonacci sequence: ");
                numberPrompt = Console.ReadLine();
            }

            // Calculate nth Fibonacci number
            var calc = new Numbers();
            int newFibonacciNumber = calc.FibonacciSequence(nthNumber);

            // Check the spelling of number (st,nd,rd,th)
            string numberSpelling = calc.NumberSpelling(nthNumber);

            // Return nth Fibonacci number
            Console.WriteLine($"The {nthNumber}{numberSpelling} number in Fibonacci Sequence is: {newFibonacciNumber}");
        }
    }
    internal class Numbers
    {
        public int FibonacciSequence(int nthNumber)
        {
            int fibonacciNumberOne = 0;
            int fibonacciNumberTwo = 1;
            int newFibonacciNumber = 0;
            for (int i = 0; i <= nthNumber; i++)
            {
                if (i == 0)
                    newFibonacciNumber = 0;
                else if (i == 1 || i == 2)
                    newFibonacciNumber = 1;
                else
                    newFibonacciNumber = fibonacciNumberOne + fibonacciNumberTwo;
                    int fibonacciTemp = fibonacciNumberTwo;
                    fibonacciNumberOne = fibonacciTemp;
                    fibonacciNumberTwo = newFibonacciNumber;
            }
            return newFibonacciNumber;
        }
        public string NumberSpelling(int nthNumber)
        {
            string numberSpellingCheck = nthNumber.ToString();
            int lastOneDigit = int.Parse(numberSpellingCheck.Substring(numberSpellingCheck.Length - 1));
            int lastTwoDigit;
            if (numberSpellingCheck.Length < 2)
                lastTwoDigit = lastOneDigit;
            else
                lastTwoDigit = int.Parse(numberSpellingCheck.Substring(numberSpellingCheck.Length - 2));

            string numberSpelling;
            if (lastTwoDigit == 11 || lastTwoDigit == 12 || lastTwoDigit == 13)
                numberSpelling = "th";
            else if (lastOneDigit == 1)
                numberSpelling = "st";
            else if (lastOneDigit == 2)
                numberSpelling = "nd";
            else if(lastOneDigit == 3)
                numberSpelling = "rd";
            else
                numberSpelling = "th";

            return numberSpelling;
        }
    }
}
