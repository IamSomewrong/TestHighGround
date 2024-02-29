using System;

namespace TestHighGround
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers separated by commas:");
            string[] numbers = Console.ReadLine().Replace(" ", "").Split(',');

            Console.WriteLine("Choose mode (1, 2, 3):");
            switch (Console.ReadLine())
            {
                case "1":
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        numbers[i] = NumberProcessor.ProcessNumberFirst(numbers[i]);
                    }
                    break;
                case "2":
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        numbers[i] = NumberProcessor.ProcessNumberSecond(numbers[i]);
                    }
                    break;
                default:
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        numbers[i] = NumberProcessor.ProcessNumberThird(numbers[i]);
                    }
                    break;
            }

            Console.WriteLine(NumberProcessor.PrepareForPrint(numbers));
        }
    }
}