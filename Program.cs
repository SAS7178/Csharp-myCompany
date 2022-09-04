using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            Company MyCompany = new Company()
            {
                Name = "FitGen",
                CreatedOn = new DateTime(),
                Employees = new List<Employee>(),
            };
            // Create three employees
                 List<Employee> EmployeeList = new List<Employee>();
            
                Employee John = new Employee()
                {
                    firstName = "John",
                    lastName = "Smith",
                    Title = "Electrician",
                };
                Employee J = new Employee()
                {
                    firstName = "J",
                    lastName = "S",
                    Title = "E",
                };
                Employee Jo = new Employee()
                {
                    firstName = "Jo",
                    lastName = "Smit",
                    Title = "Elect",
                };
            EmployeeList.Add(John);
            EmployeeList.Add(J);
            EmployeeList.Add(Jo);

            // Assign the employees to the company
                MyCompany.Employees = EmployeeList;
            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
            foreach (Employee employee in MyCompany.Employees)
            {
            Console.WriteLine($"{employee.firstName} {employee.lastName} works for {MyCompany.Name} as a {employee.Title} since {employee.startDate}.");
            }
        }
    }
}