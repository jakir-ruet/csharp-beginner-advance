using System;

namespace cl_27_useProperties
{
  class useProperties
  {
    static void Main(string[] args)
    {
      Student c1 = new Student();
      c1.Id = 105;
      c1.Name = "Jakir";
      c1.City = "Rajshahi";
      c1.Email = "jakir.ruet.bd@gmail.com";

      Console.WriteLine("Student ID = {0}", c1.Id);
      Console.WriteLine("Student Name = {0}", c1.Name);
      Console.WriteLine("Pass Mark = {0}", c1.PassMark);
      Console.WriteLine("City = {0}", c1.City);
      Console.WriteLine("Email = {0}", c1.Email);
    }
  }
  public class Student
  {
    private int _id;
    private string _Name;
    private int _passMark = 35;
    private string _city;
    //private string _email;

    
    public int Id
    {
      set
      {
        if (value <= 0)
        {
          throw new Exception("Student ID cannot be negative");
        }
        this._id = value;
      }
      get
      {
        return this._id;
      }
    }
    
    public string Name
    {
      set
      {
        if (string.IsNullOrEmpty(value))
        {
          throw new Exception("Number cannot Null");
        }
        this._Name = value;
      }
      get
      {
        return string.IsNullOrEmpty(this._Name) ? "Number cannot Null" : this._Name;
      }
    }

    public int PassMark
    {
      get
      {
        return this._passMark;
      }
    }

    public string City
    {
      get
      {
        return this._city;
      }
      set
      {
        this._city = value;
      }
    }

    public string Email { get; set; }
    //{
    //  get
    //  {
    //    return this._email;
    //  }
    //  set
    //  {
    //    this._email = value;
    //  }
    //}
  }
}
