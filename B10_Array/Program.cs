using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B10_Array
{
  class Program
  {
    static void Main(string[] args)
    {
      Random r = new Random();
      int[] a = new int[10];

      for (int i = 0; i < 10; i++)
        a[i] = r.Next(100); // 0~99사이의 랜덤값

      //for(int i=0; i<10; i++)
      //  Console.WriteLine(a[i]);

      // foreach 문
      foreach(var x in a)
        Console.WriteLine(x);

      // 평균, 최소, 최대값을 계산
      int sum = 0;
      int min = a[0];
      int max = a[0];

      foreach(var x in a)
      {
        sum += x;
        if (x < min)
          min = x;
        if (x > max)
          max = x;
      }

      Console.WriteLine("평균 = {0}", sum/10.0);
      Console.WriteLine("최소값 = {0}", min);
      Console.WriteLine("최대값 = {0}", max);
    }
  }
}
