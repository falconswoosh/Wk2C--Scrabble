using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble.Models;

namespace Scrabble.Tests
{
  [TestClass]
  public class ScrabbleTest
{
    [TestMethod]
    public void Generate_PlayerReceives7RandomLetters_True()
    {
      ScrabbleScorer testScrabble = new ScrabbleScorer();
      char result = testScrabble.Generate('d');
      // Console.WriteLine("result: "+result);
      Assert.IsInstanceOfType(char, typeof(result));
      // Assert.AreEqual(true, testScrabble.Generate());
      // Assert.AreEqual(true, testRandomNumbers.Generate("HijKlmN"));
      // Assert.AreEqual(true, testRandomNumbers.Generate("oPqrStu"));
    }
    //
    // [TestMethod]
    // public void Input_PlayerWillInputAWord_Input()
    // {
    //
    // }
    //
    // [TestMethod]
    // public void Score_ProgramWillGenerateScore_Score()
    // {
    //
    // }
    //
    // [TestMethod]
    // public void MoreLetters()
    // {}
  }
}
