using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B04_BMI
{
  class Program
  {
    static void Main(string[] args)
    {
      double height, weight;

      Console.Write("키를 입력하세요(cm): ");
      height = double.Parse(Console.ReadLine());

      Console.Write("체중을 입력하세요(kg): ");
      weight = double.Parse(Console.ReadLine());

      height = height / 100;  // height /= 100;
      double bmi = weight / (height * height);

      Console.WriteLine("BMI = {0}", bmi);

      // 이제 판단을 하는 코딩
      if (bmi < 20)
        Console.WriteLine("저체중");
      else if (bmi < 25)
        Console.WriteLine("정상체중");        
      else if (bmi < 30)
        Console.WriteLine("경도비만");        
      else if (bmi < 40)
        Console.WriteLine("비만");
      else
        Console.WriteLine("고도비만");
        
    }
  }
}
