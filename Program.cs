﻿using System;

namespace GuessingGame
{
  class Program
  {
    static void Main(string[] args)
    {
      Random rand = new Random();
      int secretNumber = rand.Next(1, 11);

      while (true)
      {
        for (int i = 0; i < 3; i++)
        {
          Console.WriteLine("Guess a number between 1 and 10");
          string userGuess = Console.ReadLine();
          int userGuessInt = int.Parse(userGuess);

          if (userGuessInt == secretNumber)
          {
            Console.WriteLine($"You guess it! It was {secretNumber}!");
            break;
          }
          else if (userGuessInt > secretNumber && i != 2)
          {
            Console.WriteLine("Nope. Too High. Guess Lower.");
          }
          else if (userGuessInt < secretNumber && i != 2)
          {
            Console.WriteLine("Nope. Too Low. Guess Higher.");
          }
          else
          {
            Console.WriteLine($"Game Over! It was {secretNumber}!");
          }
        }
      }
    }
  }
}