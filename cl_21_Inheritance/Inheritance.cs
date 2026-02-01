using System;

namespace cl_21_Inheritance
{
  class Inheritance
  {
    static void Main(string[] args)
    {
      fullTimeEmployee FTE = new fullTimeEmployee();
      FTE.firstName = "Jakir";
      FTE.lastName = "Ahmed";
      FTE.email = "jakir.ruet.bd@gmail.com";
      FTE.yearlySalary = 120000;
      FTE.empployeeDetails();

      partTimeEmployee PTE = new partTimeEmployee();
      PTE.firstName = "Jasin";
      PTE.lastName = "Uddin";
      PTE.email = "jasim.ruet.bd@gmail.com";
      PTE.hourlyRate = 220000;
      PTE.empployeeDetails();
    }
  }

  public class Employee
  {
    public string firstName;
    public string lastName;
    public string email;

    public void empployeeDetails()
    {
      Console.WriteLine(firstName + " " + lastName + " " +email);
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
