using System;

namespace cl_25_Overloading
{
  class Overloading
  {
    static void Main(string[] args)
    {
      
    }

    public static void Add(int FN, int SN, int TN)
    {
      Console.WriteLine("Sum = {0}", FN+SN);
    }

    public static void Add(int FN, int SN, out int sum)
    {
      Console.WriteLine("Sum = {0}", FN+SN);
      sum = FN + SN;
    }
  }
}
