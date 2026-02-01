using System;

namespace cl_19_Classes
{
  class Classes
  {
    static void Main()
    {
      areaCalculation roomArea = new areaCalculation();
      roomArea.height = 100;
      roomArea.width = 80;
      double resultRoom = roomArea.Area();
      Console.WriteLine("The Room Area = {0}", resultRoom);

      areaCalculation diningRoom = new areaCalculation();
      diningRoom.height = 80;
      diningRoom.width = 60;
      double resultDiningRoom = diningRoom.Area();
      Console.Write("The Dining Rood Area = {0}", resultDiningRoom);
    }

    class areaCalculation
    {
      public double height;
      public double width;

      public double Area()
      {
        return height * width;
      }
    }
  }
}
