using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Scrabble.Models
{
  public class ScrabbleScorer
  {
    static Random _random = new Random();

    public char Generate(char c)
    {
      int num = _random.Next(0, 26);
      char letter = (char)('a' + num);

      // Console.WriteLine(letter);
      return letter;
    }
  }
}
