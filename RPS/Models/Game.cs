using System;
using System.Collections.Generic;

namespace RPS.Models
{
  public class Game
  {
    private string PlayerOneMove;
    private string PlayerTwoMove;

    public Game(string playerOneMove, string playerTwoMove)
    {
      PlayerOneMove = playerOneMove;
      PlayerTwoMove = playerTwoMove;
    }

    public string CheckWinner()
    {
      if (PlayerOneMove == PlayerTwoMove)
      {
        return "draw";
      }
      else if (PlayerOneMove == "rock" && PlayerTwoMove == "paper" || PlayerOneMove == "paper" && PlayerTwoMove == "scissors" || PlayerOneMove == "scissors" && PlayerTwoMove == "rock")
      {
        return "player two wins";
      }
      else
      {
        return "player one wins";
      }
    }
    public string ComputerMove()
    {
      Random myRand = new Random();
      int moveNumber = myRand.Next(1, 3);
      if (moveNumber == 1)
      {
        return "rock";
      }
      else if (moveNumber == 2)
      {
        return "paper";
      }
      else
      {
        return "scissors";
      }
    }

    public string GetMoveOne()
    {
      return PlayerOneMove;
    }
    public string GetMoveTwo()
    {
      return PlayerTwoMove;
    }
    public void SetMoveTwo(string newMove)
    {
      PlayerTwoMove = newMove;
    }
  }
}
