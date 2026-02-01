using System;
//name Alias
using PATA = ProjectA.TeamA;
using PATB = ProjectA.TeamB;

namespace cl_18_Namespaces
{
  class Namespaces
  {
    static void Main()
    {
      //ProjectA.TeamA.ClassA.Print();
      //ProjectA.TeamB.ClassA.Print();

      //name Alias
      PATA.ClassA.Print();
      PATB.ClassA.Print();

    }
  }
}

namespace ProjectA
{
  namespace TeamA
  {
    class ClassA
    {
      public static void Print()
      {
        Console.WriteLine("This is ClassA & TeamA");
      }
    }
  }
}

namespace ProjectA
{
  namespace TeamB
  {
    class ClassA
    {
      public static void Print()
      {
        Console.WriteLine("This is ClassA & TeamB");
      }
    }
  }
}