using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B07_Gugu
{
  class Program
  {
    static void Main(string[] args)
    {
      for (int y = 1; y <= 9; y++)
      {
        for (int x = 2; x <= 9; x++)
        {
          Console.Write("{0}x{1}={2}\t", x, y, x * y);
        }
        Console.WriteLine();
      }
    }
  }
}
