using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B02_Arithmetic
{
  class Program
  {
    static void Main(string[] args)
    {
      int x, y;

      Console.Write("첫번째 숫자를 입력하세요 : ");
      x = int.Parse(Console.ReadLine());
      Console.Write("두번째 숫자를 입력하세요 : ");
      y = int.Parse(Console.ReadLine());

      Console.WriteLine("{0} + {1} = {2}", x, y, x+y);
      Console.WriteLine("{0} - {1} = {2}", x, y, x - y);
      Console.WriteLine("{0} * {1} = {2}", x, y, x * y);
      Console.WriteLine("{0} / {1} = {2}", x, y, x / y);
      Console.WriteLine("{0} % {1} = {2}", x, y, x % y);

      Console.WriteLine("{0} % {1} = {2}", 3.14, 2.56, 3.14%2.56);
    }
  }
}
