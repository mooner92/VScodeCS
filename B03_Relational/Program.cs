using System;

namespace B03_Relational
{
  class Program
  {
    static void Main(string[] args)
    {
      int x, y;

      Console.WriteLine("x를 입력하세요 : ");
      x = int.Parse(Console.ReadLine());

      Console.WriteLine("y를 입력하세요 : ");
      y = int.Parse(Console.ReadLine());

      Console.WriteLine("{0} > {1} = {2}", x, y, x > y);
      Console.WriteLine("{0} >= {1} = {2}", x, y, x >= y);
      Console.WriteLine("{0} < {1} = {2}", x, y, x < y);
      Console.WriteLine("{0} <= {1} = {2}", x, y, x <= y);
      Console.WriteLine("{0} == {1} = {2}", x, y, x == y);
      Console.WriteLine("{0} != {1} = {2}", x, y, x != y);


    }
  }
}
