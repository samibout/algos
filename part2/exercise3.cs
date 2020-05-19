using System;

namespace part2
{
  public class Changes
  {
    public int Calculate(int[] t)
    {
      int repe = 0;

      for(int i = 0; i < t.Length-1;i++)
      {
        if(t[i] == t[i+1]) 
        {
          t[i+1]= t[i]+t[i+2];
          repe++;
        }
      }  

      return repe;
    }

  }
}