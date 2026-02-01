using System;

namespace cl_17_MethodParams
{
  class MethodParams
  {
    static void Main()
    {
      //pass by value
      int b = 0;
      MethodParams.passbyValue(b);
      Console.WriteLine("Pass by Value " + b);

      //pass by ref
      int c = 0;
      MethodParams.passbyRef(ref c);
      Console.WriteLine("Pass by Ref " + c);

      //Out parameter
      int Total = 0;
      int Multi = 0;
      OutParams(50, 30, out Total, out Multi);
      Console.WriteLine("Sum = {0} and Product = {1}", Total, Multi);

      //param array
      int[] Numbers = new int[4];
      Numbers[0] = 100;
      Numbers[1] = 105;
      Numbers[2] = 110;
      Numbers[3] = 115;
      //paramArray(Number);
      paramArray(Numbers);

    }

    static void passbyValue(int a)
    {
      a = 100;
    }

    static void passbyRef(ref int c)
    {
      c = 120;
    }

    public static void OutParams(int FN, int SN, out int Sum, out int Product)
    {
      Sum = FN + SN;
      Product = FN * SN;
    }

    public static void paramArray(params int[] Numbers)
    {
      Console.WriteLine("There are {0} elements", Numbers.Length);
      foreach (var i in Numbers)
      {
        Console.WriteLine(i);
      }
    }
  }
}
