using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("정수 하나를 입력하세요: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("결과: {0}", Fibo(n));
        }

        private static int Fibo(int n)
        {
            if (n == 1 || n == 2)
                return 1;
            return Fibo(n - 1) + Fibo(n - 2);
        }
    }
}