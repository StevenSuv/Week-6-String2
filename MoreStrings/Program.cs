﻿using System;

namespace MoreStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first name: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter your last name:  ");
            string lastName = Console.ReadLine();

            Console.WriteLine($"Greetings, {firstName[0]}. {lastName[0]}.");
        }
    }
}
