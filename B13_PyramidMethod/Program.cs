using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B13_PyramidMethod
{
  class Program
  {
    static void Main(string[] args)
    {
      DrawPyramid(3);
      DrawPyramid(11);
      DrawPyramid(16);
    }

    private static void DrawPyramid(int n)
    {
      for(int i=1; i<=n; i++)
      {
        // 빈칸
        for (int j = 1; j <= n - i; j++)
          Console.Write(" ");
        // 별표
        for (int k = 1; k <= 2 * i - 1; k++)
          Console.Write("*");
        Console.WriteLine();
      }
    }
  }
}
