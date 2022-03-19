using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B15_Hanoi
{
  class Program
  {
    static void Main(string[] args)
    {
      HanoiTower(4, 'A', 'B', 'C');
      // 교과서에서는 Hanoi(4, 'A', 'C', 'B')
    }

    private static void HanoiTower(int n, char from, char via, char to)
    {
      if(n == 1)
        Console.WriteLine("{0}->{1}", from, to);
      else
      {
        HanoiTower(n-1, from, to, via);
        Console.WriteLine("{0}->{1}", from, to);
        HanoiTower(n-1, via, from, to);
      }
    }
  }
}
