using System;
namespace part1
{
  public class Tables
  {
    public int Calculate(int[] t)
    {
      int len = t.Length;
      int ind = 0;
      int retu = 0;
      if(len==1)
      {
        retu = t[0];
        return retu;
      }
      int[][]numbers = new int [len][];
      numbers[ind] = new int [len];

      for(int i=1;i<len;i++)
      {
        numbers[i] = new int[len-1];
      }
      numbers[ind] = t;

      for(int a=1;a<len;a++)
      {
        for(int i=0;i<len-a;i++)
        {
          numbers[a][i] = numbers[a-1][i] + numbers[a-1][i+1];
          retu = numbers[a][i];
        }
      }


      return retu;
    }
  }
}