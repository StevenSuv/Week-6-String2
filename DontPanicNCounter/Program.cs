using System;

namespace DontPanicNCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            string dontPanic = "Don't panic".ToLower();

            int counter = 0;

            for(int i = 0; i < dontPanic.Length; i++)
            {
                if (dontPanic[i] == 'n')
                {
                    counter++;
                }
            }

            Console.WriteLine($"In sentence {dontPanic} there is {counter} 'n' letters");
        }
    }
}
