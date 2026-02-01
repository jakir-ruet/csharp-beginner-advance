using System;

namespace cl_20_StaticInstanceClass
{
  class StaticInstanceClass
  {
    static void Main()
    {
      Circle c1 = new Circle(10);
      float area1 = c1.areaCalculate();
      Console.WriteLine("The area = {0}", area1);

      Circle c2 = new Circle(15);
      float area2 = c2.areaCalculate();
      Console.WriteLine("The area = {0}", area2);

    }

    class Circle
    {
      float _PI = 3.141F;
      int _Radius;

      public Circle(int Radius)
      {
        this._Radius = Radius;
      }

      public float areaCalculate()
      {
        return this._PI * this._Radius * this._Radius;
      }
    }
  }
}
