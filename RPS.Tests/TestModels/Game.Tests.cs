using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPS.Models;
using System;
using System.Collections.Generic;

namespace RPS.Tests
{
  [TestClass]
  public class GameTests
  {
    [TestMethod]
    public void GameConstructor_CreatesInstanceOfGame_Game()
    {
      string testMoveOne = "paper";
      string testMoveTwo = "paper";
      Game testGame = new Game(testMoveOne, testMoveTwo);
      Assert.AreEqual(typeof(Game), testGame.GetType());
    }
    [TestMethod]
    public void GetMove_ReturnsMove_String()
    {
      string testMoveOne = "paper";
      string testMoveTwo = "paper";
      Game testGame = new Game(testMoveOne, testMoveTwo);
      Assert.AreEqual("paper", testGame.GetMoveOne());
    }
    [TestMethod]
    public void CheckWinner_ReturnsDraw_String()
    {
      string testMoveOne = "paper";
      string testMoveTwo = "paper";
      Game testGame = new Game(testMoveOne, testMoveTwo);
      Assert.AreEqual("draw", testGame.CheckWinner());
    }
    [TestMethod]
    public void CheckWinner_ReturnsWinner_String()
    {
      string testMoveOne = "scissors";
      string testMoveTwo = "paper";
      Game testGame = new Game(testMoveOne, testMoveTwo);
      Assert.AreEqual("player one wins", testGame.CheckWinner());
    }
    [TestMethod]
    public void ComputerMove_ReturnsMove_String()
    {
      string testMoveOne = "scissors";
      string testMoveTwo = "";
      Game testGame = new Game(testMoveOne, testMoveTwo);
      string comMove = testGame.ComputerMove();
      testGame.SetMoveTwo(comMove);
      string result = testGame.GetMoveTwo();
      Assert.IsTrue(result == "rock" || result == "paper" || result == "scissors", "Failed");
    }
  }
}
