using System;

namespace part2
{
  public class LongestRepetition
  {
    public int Calculate(int[] t)
    {
      int repe = 1;
      int lRepe = 0;

      for(int i = 0; i < t.Length-1;i++)
      {
        if(t[i] == t[i+1]) 
        {
          repe++;
        }
        else{
          repe = 1;
        }
        if(repe > lRepe)
        {
          lRepe = repe;
        }
          
      }
      return lRepe;
    }

  }
}