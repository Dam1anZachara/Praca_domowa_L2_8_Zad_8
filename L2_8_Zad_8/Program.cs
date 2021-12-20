using System;

namespace L2_8_Zad_8
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program odwróci wprowadzony przez użytkownika ciąg znaków.");

            Console.Write("Podaj łańcuch znaków: "); 
            string userInput = Console.ReadLine();

            int counterOne = userInput.Length - 1;
            int counterTwo = 0;

            while (counterOne >= 0)
            {
                char charOfTheStringBackward = userInput[counterOne];
                char charOfTheStringForward = userInput[counterTwo];

                counterOne--;
                counterTwo++;

                if (char.IsUpper(charOfTheStringForward))
                {
                    Console.Write(char.ToUpper(charOfTheStringBackward));
                }
                else
                {
                    Console.Write(char.ToLower(charOfTheStringBackward));
                }
            }
        }
    }
}
