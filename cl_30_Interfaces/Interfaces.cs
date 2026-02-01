using System;

namespace cl_30_Interfaces
{
  class Interfaces
  {
    static void Main(string[] args)
    {
      Customer c1 = new Customer();
      c1.printCustomerOne();

      Customer C2 = new Customer();
      C2.printCustomerTwo();
    }
  }

  interface ICustomerOne
  {
    void printCustomerOne();
  }

  interface ICustomerTwo
  {
    void printCustomerTwo();
  }

  class Customer : ICustomerOne , ICustomerTwo
  {
    public void printCustomerOne()
    {
      Console.WriteLine("Interface One");
    }

    public void printCustomerTwo()
    {
      Console.WriteLine("Interface Two");
    }
  }
}
