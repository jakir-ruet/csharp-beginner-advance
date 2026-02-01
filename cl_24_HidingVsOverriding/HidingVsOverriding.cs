using System;

namespace cl_24_HidingVsOverriding
{
  public class HidingVsOverriding
  {
    static void Main(string[] args)
    {
      baseClass b = new derivedClass();
      b.Print();
      derivedClass d = new derivedClass();
      d.Print();
    }
  }

  public class baseClass
  {
    public virtual void Print()
    {
      Console.WriteLine("I am base class");
    }
  }

  public class derivedClass : baseClass
  {
    //to use hiding use new instead of override
    public override void Print()
    {
      Console.WriteLine("I am derived class");
    }
  }
}
