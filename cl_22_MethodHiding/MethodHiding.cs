using System;

namespace cl_22_MethodHiding
{
  class MethodHiding
  {
    static void Main()
    {
      fullTimeEmployee FTE = new fullTimeEmployee();
      FTE.firstName = "Jakir";
      FTE.lastName = "Ahmed";
      FTE.empployeeDetails();

      partTimeEmployee PTE = new partTimeEmployee();
      PTE.firstName = "Jasin";
      PTE.lastName = "Uddin";
      PTE.empployeeDetails();
    }
  }

  public class Employee
  {
    public string firstName;
    public string lastName;
    public void empployeeDetails()
    {
      Console.WriteLine(firstName + " " + lastName);
    }
  }

  public class fullTimeEmployee : Employee
  {
    public float yearlySalary;
  }

  public class partTimeEmployee : Employee
  {
    public float hourlyRate;
  }
}
