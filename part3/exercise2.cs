using System;

namespace part3
{
  class SmallestDifference
  {
    public int Calculate(int[] t)
    {
      Array.Sort(t);
      int subs=0;
      int diff=t[t.Length-1];
    
      for(int i =0;i<t.Length-1;i++)
      {
      subs = t[i+1]-t[i];
    
      if(subs<diff)
      {
        diff = subs;
      }
      }
            return diff;
    }
  }
}