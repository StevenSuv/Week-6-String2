using System;

namespace HOLCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            string helloWorld = "Hello world!".ToLower();

            int counterH = 0;
            int counterO = 0;
            int counterL = 0;

            for (int i = 0; i < helloWorld.Length; i++)
            {
                if (helloWorld[i] == 'h')
                {
                    counterH++;
                }
                else if(helloWorld[i] == 'o')
                {
                    counterO++;
                }
                else if(helloWorld[i] == 'l')
                {
                    counterL++;
                }
                else
                {
                    continue;
                }
            }

            Console.WriteLine($"In sentence '{helloWorld}' there is {counterH} 'h' letters, {counterO} 'o' letters and {counterL} 'l' letters.");
        }
    }
}
