using System;

namespace part3
{
    class Program
    {
        static void Main(string[] args)
        {
          Hello(5);
        }  

        static void Hello(int n)
        {
          Console.WriteLine(" Hello!");
      
          if (n == 1) return;
          Hello(n - 1);

        }

        
    }
}
