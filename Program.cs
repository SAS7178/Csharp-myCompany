using System;
using System.Collections.Generic;


namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
    //         // Create an instance of a company. Name it whatever you like.
    //    public Company myCompany = new Company("FitGen", new DateTime());
        Company MyCompany = new Company()
        {
             Name = "FitGen",
             CreatedOn = new DateTime(),
             Employees = new List<Employee>{},  
        };

            // Create three employees
         Employee John = new Employee()
        {
             FirstName = "John",
             LastName = "Smith",
             Title = "Electrician",  
        };
         Employee Amy = new Employee()
        {
             FirstName = "Amy",
             LastName = "Thompson",
             Title = "Designer",  
        };
         Employee James = new Employee()
        {
             FirstName = "James",
             LastName = "Hoyt",
             Title = "Human Resources",  
        };
           // Assign the employees to the company
            List<Employee> employees = new List<Employee>();
        employees.Add(John);
        employees.Add(Amy);
        employees.Add(James);

            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
        //         void ListEmployees()
        // {
        //     foreach(Employee Employee in employees)
        //     System.Console.WriteLine($"{Employee.FirstName} works for  as {Employee.Title} since {Employee.StartDate}");
        // }
        Console.WriteLine();
        }
    }
}