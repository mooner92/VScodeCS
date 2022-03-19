using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B05_Loop
{
  class Program
  {
    static void Main(string[] args)
    {
      int sum = 0;
      for (int i = 1; i <= 100; i++)
        sum += i;
      Console.WriteLine("1~100의 합 : {0}", sum);

      int oddSum = 0; 
      int evenSum = 0;
      for (int i = 1; i <= 100; i++)
      {
        if (i % 2 == 0)
          evenSum += i;
        else
          oddSum += i;
      }
      Console.WriteLine("1~100의 짝수의 합 = {0}", evenSum);
      Console.WriteLine("1~100의 홀수의 합 = {0}", oddSum);

      double rSum = 0;
      for (int i = 1; i <= 100; i++)
        rSum += 1.0 / i;

      Console.WriteLine("1~100의 역수의 합 = {0}", rSum);
    }
  }
}
