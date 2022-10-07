﻿namespace LineComparison
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program");
            Console.WriteLine("Use Case #1: Model a Line and Calculate Length");

            Console.Write("Choose a use case number to run the program: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    ModelALine.CalculateLineLength();
                    break;
                default:
                    Console.WriteLine("Please enter a valid use case number!");
                    break;
            }
            
        }
    }
}