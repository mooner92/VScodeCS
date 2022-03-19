using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B08_Prime
{
  class Program
  {
    static void Main(string[] args)
    {
      // (1) 어떤 숫자가 소수인지를 판단하는 프로그램
      //Console.Write("숫자하나를 입력하세요: ");
      //int x = int.Parse(Console.ReadLine());

      //int i;
      //for (i = 2; i < x; i++)
      //{
      //  if (x % i == 0) // 소수가 아님
      //    break;
      //}
      //if (i == x)
      //  Console.WriteLine("소수입니다.");
      //else
      //  Console.WriteLine("소수가 아닙니다");

      // (2) 1000까지 소수를 출력하고 몇개인지를 출력하는 프로그램
      int nPrime = 0;
      for (int x = 2; x<=1000; x++)
      {
        int i;
        for (i = 2; i < x; i++)
        {
          if (x % i == 0) // 소수가 아님
            break;
        }
        if (i == x)
        {
          Console.Write("{0}\t", x);
          nPrime++;
        }
      }
      Console.WriteLine();
      Console.WriteLine("소수의 갯수 = {0}", nPrime);
    }
  }
}
