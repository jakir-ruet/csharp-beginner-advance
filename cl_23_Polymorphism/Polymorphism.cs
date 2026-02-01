using System;

namespace cl_23_Polymorphism
{
  class Polymorphism
  {
    static void Main(string[] args)
    {
      Employee[] employees = new Employee[4];
      employees[0] = new Employee();
      employees[1] = new partTimeEmployee();
      employees[2] = new fullTimeEmployee();
      employees[3] = new temporaryEmployee();
      foreach (Employee e in employees)
      {
        e.employeeDetails();
      }
    }
  }

  public class Employee
  {
    public string firstName = "Jakir";
    public string lastName = "Ahmed";

    public virtual void employeeDetails()
    {
      Console.WriteLine(firstName +" " + lastName);
    }
  }

  public class partTimeEmployee : Employee
  {
    public override void employeeDetails()
    {
      Console.WriteLine(firstName + " " + lastName+ " Part Time Employee");
    }
  }

  public class fullTimeEmployee : Employee
  {
    public override void employeeDetails()
    {
      Console.WriteLine(firstName + " " + lastName + " Full Time Employee");
    }
  }

  public class temporaryEmployee : Employee
  {
    public override void employeeDetails()
    {
      Console.WriteLine(firstName + " " + lastName + " Temporary");
    }

  }
}
