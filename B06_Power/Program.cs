using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B06_Power
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("x를 입력하세요: ");
      int x = int.Parse(Console.ReadLine());
      Console.Write("y를 입력하세요: ");
      int y = int.Parse(Console.ReadLine());

      int power = 1;
      for (int i = 0; i < y; i++)
        power *= x;

      Console.WriteLine("{0} ^ {1} = {2}", x, y, power);
    }
  }
}
