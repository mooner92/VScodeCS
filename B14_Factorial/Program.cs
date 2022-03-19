using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B14_Factorial
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("n!을 계산하고자 합니다. n을 입력하세요 : ");
      int n = int.Parse(Console.ReadLine());

      int fact = 1;
      for (int i = 1; i <= n; i++)
        fact *= i;

      Console.WriteLine("{0}! = {1}", n, fact);

      Console.WriteLine("{0}! = {1}", n, Facto(n));

      // 1~10까지의 팩토리얼을 구하시오
      for(int i=1; i<=10; i++)
        Console.WriteLine("{0, 2}! = {1,8}", i, Facto(i));
    }

    private static int Facto(int n)
    {
      if (n == 1)
        return 1;
      else
        return Facto(n - 1) * n;
    }
  }
}
