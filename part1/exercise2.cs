using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace part1
{
  public class Substrings
  {
    public int Calculate(string a, string b)
    {
      //first done it by myself
      int match = 0;
      int st = a.Length;
      int sub = b.Length;

      for(int i =0;i<st-(sub-1);i++)
      {
        if(a.Substring(i, sub) == b)
        {
            match++;
            
        }
      }
      //then found a line from internet
      match = Regex.Matches(a, b).Count;
      return match;
    }
  }
} 