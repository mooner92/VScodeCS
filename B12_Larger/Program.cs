using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B12_Larger
{
  class Program
  {
    static void Main(string[] args)
    {
      int x, y, z;
      Console.Write("첫번째 값을 입력하세요 : ");
      x = int.Parse(Console.ReadLine());
      Console.Write("두번째 값을 입력하세요 : ");
      y = int.Parse(Console.ReadLine());
      Console.Write("세번째 값을 입력하세요 : ");
      z = int.Parse(Console.ReadLine());

      //int max = Larger(x, y);
      //max = Larger(max, z);
      //int max = Larger(Larger(x, y), z);

      Console.WriteLine("최대값은 {0}", Larger(Larger(x, y), z));
    }

    private static int Larger(int x, int y)
    {
      //if (x > y)
      //  return x;
      //else
      //  return y;
      // 조건연산자( ? : )
      return (x > y) ? x : y;
    }
  }
}
