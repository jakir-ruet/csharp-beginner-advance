using System;

namespace cl_28_Structs
{
  class Structs
  {
    static void Main(string[] args)
    {
      Customer c1 = new Customer(105, "Jakir");
      c1.printDetails();

      Customer c2 = new Customer();
      c2.ID = 110;
      c2.Name = "Jasim";
      c2.printDetails();

      Customer c3 = new Customer
      {
        ID = 115,
        Name = "Jakia"
      };
      c3.printDetails();
    }
  }

  public struct Customer
  {
    private int _id;
    private string _name;

    public string Name
    {
      get { return _name; }
      set { _name = value; }
    }

    public int ID
    {
      get { return this._id;}
      set { this._id = value; }
    }

    public Customer(int Id, string Name)
    {
      this._id = Id;
      this._name = Name;
    }

    public void printDetails()
    {
      Console.WriteLine("Id = {0} & Name = {1}", this._id, this._name);
    }
  }
}
