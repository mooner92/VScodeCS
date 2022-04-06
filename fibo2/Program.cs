using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("정수 하나를 입력하세요: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("1항부터 {0}항까지: {1}", n, Fibo(n));
            for (int i = 1; i <= n; i++)
                Console.Write(Fibo(i) + " ");
            Console.WriteLine(" ");

        }

        private static int Fibo(int n)
        {
            if (n == 1 || n == 2)
                return 1;
            else
                return Fibo(n - 1) + Fibo(n - 2);
        }
    }
}

