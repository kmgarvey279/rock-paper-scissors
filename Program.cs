using System;
using System.Collections.Generic;
using RPS.Models;

public class Program
{
  static void Main()
  {
    Console.WriteLine("Would you like to play Rock-Paper-Scissors against another person, or against the computer? (person/computer)");
    string opponentInput = Console.ReadLine();
    Console.WriteLine("Player One, select your move: (rock/paper/scissors)");
    string playerOneInput = Console.ReadLine();
    if (opponentInput == "person")
    {
      Console.WriteLine("Player Two, select your move: (rock/paper/scissors)");
      string playerTwoInput = Console.ReadLine();
      Game newGame = new Game(playerOneInput, playerTwoInput);
      string winner = newGame.CheckWinner();
      Console.WriteLine("Player One picked: " + playerOneInput + " Player Two picked: " + playerTwoInput + ". " + winner);
    }
    else
    {
      string playerTwoInput = "";
      Game newGame = new Game(playerOneInput, playerTwoInput);
      string comMove = newGame.ComputerMove();
      newGame.SetMoveTwo(comMove);
      string winner = newGame.CheckWinner();
      Console.WriteLine("Player One picked: " + playerOneInput + " Player Two picked: " + comMove + ". " + winner);
    }
  }
}
