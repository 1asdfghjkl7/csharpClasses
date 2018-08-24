using System;
using System.Collections.Generic;



public class Employee
{
    public string FirstName()
    {
        return firstName;
    }

    public string LastName()
    {
        return lastName;
    }

    public string Title()
    {
        return title;
    }
    public DateTime StartDate()
    {
        return startDate;
    }

    public Employee(string first, string last, string titlez, DateTime start)
    {
        firstName = first;
        lastName = last;
        title = titlez;
        startDate = start;
    }
    private string firstName { get; set; }
    private string lastName { get; set; }

    private string title { get; set; }

    private DateTime startDate { get; set; }
}

public class Company
{

    // Some readonly properties (let's talk about gets, baby)
    public string Name { get; }
    public DateTime CreatedOn { get; }

    // Create a public property for holding a list of current employees

    public List<Employee> Employees = new List<Employee>();

    public void ListEmployees()
    {
        foreach (Employee item in Employees)
        {
            string fullName = $"{item.FirstName()} {item.LastName()}";
            Console.WriteLine(fullName);
        }
    }
            
    /*
        Create a constructor method that accepts two arguments:
            1. The name of the company
            2. The date it was created

        The constructor will set the value of the public properties
    */

    public Company(string name, DateTime createdOn)
    {
        Name = name;
        CreatedOn = createdOn;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of a company. Name it whatever you like.

        Company TheKrustyKrab = new Company("TheKrustyKrab", new DateTime(1111, 1, 1));

        // Create three employees
        Employee Bob = new Employee("Bob", "Bilbo", "Spoon Feeder", new DateTime(1111, 1, 1));
        Employee Kyle = new Employee("Kyle", "Elbow", "Foot Smeller", new DateTime(2222, 2, 2));
        Employee Phil = new Employee("Phil", "Donald", "Peasant", new DateTime(3333, 3, 3));


        // Assign the employees to the company

        TheKrustyKrab.Employees.Add(Bob);
        TheKrustyKrab.Employees.Add(Kyle);
        TheKrustyKrab.Employees.Add(Phil);

        /*
            Iterate the company's employee list and generate the
            simple report shown above
        */
        TheKrustyKrab.ListEmployees();
    }
}