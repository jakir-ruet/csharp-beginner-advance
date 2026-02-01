using System;

namespace cl_26_Properties
{
  class Properties
  {
    static void Main(string[] args)
    {
      Student c1 = new Student();
      c1.SetId(101);
      c1.SetName("Mark");

      Console.WriteLine("Student ID = {0}", c1.GetId());
      Console.WriteLine("Student Name = {0}", c1.GetName());
      Console.WriteLine("Pass Mark = {0}", c1.GetPassMark());
    }
  }

  public class Student
  {
    private int _id;
    private string _Name;
    private int _passMark = 35;

    public int GetPassMark()
    {
      return this._passMark;
    }

    public void SetName(string Name)
    {
      if (string.IsNullOrEmpty(Name))
      {
        throw new Exception("Number cannot Null");
      }
      this._Name = Name;
    }

    public string GetName()
    {
      //return string.IsNullOrEmpty(this._Name) ? "Number cannot Null" : this._Name;

      if (string.IsNullOrEmpty(this._Name))
      {
        return "No Name";
      }
      else
      {
        return this._Name;
      }
    }

    public void SetId(int Id)
    {
      if (Id <= 0)
      {
        throw new Exception("Student ID cannot be negative");
      }
      this._id = Id;
    }

    public int GetId()
    {
      return this._id;
    }
  }
}
