using System;
using System.Collections.Generic;
using System.Text;

namespace cl_01_HelloWord
{
  class HelloWorld
  {
    static void Main()
    {
      Console.WriteLine("Hello, I am main class");
      MainOne();
    }

    static void MainOne()
    {
      Console.WriteLine("Hello, I am not main class");
    }
  }
}
