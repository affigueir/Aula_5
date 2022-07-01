using System;

namespace Chronos
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("How many dice would you like to roll?");
            int n = Int32.Parse(Console.ReadLine());

            DiceRoll(n);
        }
        private static void DiceRoll(int x)
            {
                int sum = 0;
                int[] dice = new int[x];

                for(int i = 0; i < x; i++)
                {
                    Random random = new Random();

                    dice[i] = random.Next(1, 7);
                    sum += dice[i];
                }
                for(int i = 0; i < dice.Length; i++)
                {
                    System.Console.WriteLine($"{i+1} Roll is {dice[i]}");
                }

                System.Console.WriteLine($"The sum of all dice is {sum}!");
            }
    }
}    