using System;

namespace RockPaperScissors
{
  class Program
  {
    static void Main(string[] args)
    {
      //Welcome User
      Console.WriteLine("Welcome to Rock, Paper, Scissor");

      //Choose difficulty
      //Console.WriteLine("Choose Your Difficulty Level: Easy, Normal, Difficult")
      //var userDifficulty = Console.ReadLine().ToLower();

      //Ask to choose rock, paper or scissor
      Console.WriteLine("Please choose Rock, Paper or Scissor");

      //user input
      var userOption = Console.ReadLine().ToLower();

      //generate random computer option
      Random random1 = new Random();
      string[] computerOption = { "rock", "paper", "scissor" };

      int randomNumber = random1.Next(computerOption.Length);

      // below line test specific array item 0-2
      //randomNumber = 0;

      //showing user random computer option
      Console.WriteLine(computerOption[randomNumber]);

      // ROCK NORM
      if (userOption == "rock" && computerOption[randomNumber] == "rock")
      {
        Console.WriteLine("Tie");
      }
      else if (userOption == "rock" && computerOption[randomNumber] == "paper")
      {
        Console.WriteLine("You Lose");
      }
      else if (userOption == "rock" && computerOption[randomNumber] == "scissor")
      {
        Console.WriteLine("You win");
      }
      // PAPER NORM
      else if (userOption == "paper" && computerOption[randomNumber] == "paper")
      {
        Console.WriteLine("Tie");
      }
      else if (userOption == "paper" && computerOption[randomNumber] == "scissor")
      {
        Console.WriteLine("You Lose");
      }
      else if (userOption == "paper" && computerOption[randomNumber] == "rock")
      {
        Console.WriteLine("You win");
      }

      // SCISSOR NORM
      else if (userOption == "scissor" && computerOption[randomNumber] == "scissor")
      {
        Console.WriteLine("Tie");
      }
      else if (userOption == "scissor" && computerOption[randomNumber] == "rock")
      {
        Console.WriteLine("You Lose");
      }
      else if (userOption == "scissor" && computerOption[randomNumber] == "paper")
      {
        Console.WriteLine("You win");
      }

      //decide who the winner is


      //user sees what random selection was and who won or lost


      //validation on user input


    }
  }
}
