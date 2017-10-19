using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Scrabble.Models
{
  public class ScrabbleScorer
  {
    static Random _random = new Random();

    public char GetRandomChar(char c)
    {
      int num = _random.Next(0, 26);
      char letter = (char)('a' + num);
      // Console.WriteLine(letter);
      return letter;
    }

    // public List<string> Generate()
    // {
    //   List<string> initialLetters = new List<string> {};
    //   for (int i = 1; i < 8; i++)
    //   {
    //
    //     int num = _random.Next(0, 26);
    //
    //     string letter = (string)('a' + num.ToString());
    //     initialLetters.Add(letter);
    //   }
    //   // Console.WriteLine(letter);
    //   return initialLetters;
    // }
  }
}
