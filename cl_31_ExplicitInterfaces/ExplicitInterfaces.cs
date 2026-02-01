using System;
using System.Security.Principal;

namespace cl_31_ExplicitInterfaces
{
  class ExplicitInterfaces : IOne, ITwo, IThree
  {
    void IOne.printInterface()
    {
      Console.WriteLine("Talking from IOne");
    }

    void ITwo.printInterface()
    {
      Console.WriteLine("Talking from ITwo");
    }

    public void printInterface()
    {
      Console.WriteLine("Talking from IThree");
    }

    public static void Main()
    {
      //call IOne method
      ExplicitInterfaces obj = new ExplicitInterfaces();
      obj.printInterface();
      //Call ITwo method
      ((ITwo)obj).printInterface();
    }
  }

  interface IOne
  {
    void printInterface();
  }

  interface ITwo
  {
    void printInterface();
  }

  interface IThree
  {
    void printInterface();
  }
}
