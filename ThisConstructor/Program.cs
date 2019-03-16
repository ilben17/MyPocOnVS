using System;
using System.Diagnostics;



namespace ThisConstructor
{
  public class Program
  {
    public class Employee
    {
      public int Salary;

      public Employee()
      {
        Salary = 1000;
      }

      public Employee(int weeklySalary, int numberOfWeeks) :this()
      {
        Console.WriteLine(Salary);

        Salary = weeklySalary * numberOfWeeks;

        Console.WriteLine(Salary);
      }
    }

    static void Main(string[] args)
    {
      var emp = new Employee(20, 10);
      Console.ReadLine();
      //output : 1000 puis 200
    }
  }
}
