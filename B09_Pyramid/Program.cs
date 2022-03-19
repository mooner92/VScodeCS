using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B09_Pyramid
{
  class Program
  {
    static void Main(string[] args)
    {
      for(int i=1; i<=5; i++)
      {
        for(int j=1; j<=5-i; j++)
          Console.Write(" ");
        for(int j=1; j<=2*i-1; j++)
          Console.Write("*");
        Console.WriteLine();
      }
    }
  }
}
