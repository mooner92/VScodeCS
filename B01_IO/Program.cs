using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B01_IO
{
  class Program
  {
    static void Main(string[] args)
    {
      int id; // 학번
      int[] k = new int[0];
      string name;  // 이름(스트링=문자열)
  

      Console.Write("학번을 입력하세요 : ");
      id = int.Parse(Console.ReadLine());

      Console.Write("이름을 입력하세요 : ");
      name = Console.ReadLine();

      Console.WriteLine("학번 : {0}", id);
      Console.WriteLine("이름 : {0}", name);
      
    }
  }
}
