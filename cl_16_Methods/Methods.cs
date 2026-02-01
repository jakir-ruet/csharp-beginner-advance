using System;
using System.Collections.Generic;
using System.Text;

namespace cl_16_Methods
{
  class Methods
  {
    static void Main()
    {
      //instance method
      Methods obj = new Methods();
      obj.evenNumbers();

      //static method
      Methods.oddNumbers();

      //static method with parameter
      Methods.evenNumbersPara(30);

      //instance method with parameter
      Methods objNumberParas = new Methods();
      int Sum = objNumberParas.Add(20, 50);
      Console.WriteLine("Sum = {0}", Sum);
    }

    public void evenNumbers()
    {
      int Start = 0;
      while (Start <= 20)
      {
        Console.WriteLine(Start);
        Start = Start + 2;
      }
    }

    public static void oddNumbers()
    {
      int Start = 1;
      while (Start <= 20)
      {
        Console.WriteLine(Start);
        Start = Start + 2;
      }
    }

    public static void evenNumbersPara(int Target)
    {
      int Start = 0;
      while (Start <= Target)
      {
        Console.WriteLine(Start);
        Start = Start + 2;
      }
    }

    public int Add(int FN, int SN)
    {
      return FN + SN;
    }
  }
}
