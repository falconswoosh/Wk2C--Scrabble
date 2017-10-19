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
  public void GetRandomChar_ProgramGeneratesOneRandomLetter_True()
  {
     ScrabbleScorer testScrabble = new ScrabbleScorer();
     char result = testScrabble.GetRandomChar('d');
     Console.WriteLine("result: "+result);
     Assert.IsInstanceOfType(result, typeof(char));
   }
    // [TestMethod]
    // public void Generate_PlayerReceives7RandomLetters_True()
    // {
    //   ScrabbleScorer testScrabble = new ScrabbleScorer();
    //   List<string> result = testScrabble.Generate();
    //   Console.WriteLine("result: "+result);
    //   Assert.IsInstanceOfType(List<string>, typeof(result));
    //
    // }
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
