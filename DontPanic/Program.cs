﻿using System;

namespace DontPanic
{
    class Program
    {
        static void Main(string[] args)
        {
            string dontPanic = "Don't panic".ToUpper();
            for (int i = dontPanic.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(dontPanic[i]);
            }
        }
    }
}
