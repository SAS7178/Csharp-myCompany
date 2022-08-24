using System;
using System.Collections.Generic;


namespace Classes
{
    public class Company
    {

        // Some read only properties (let's talk about gets, baby)
        public string Name { get; set; }
        public DateTime CreatedOn { get; set; }
        public List<Employee> Employees { get; set;}
        // Create a public property for holding a list of current employees
        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created
            The constructor will set the value of the public properties

        */
        public Company ()
        {
             Name = "";
             CreatedOn = new DateTime();
             Employees =  new List<Employee> {};  
        }
        void ListEmployees()
        {
            foreach(Employee Employee in Employees)
            System.Console.WriteLine($"{Employee.FirstName} works for {Name} as {Employee.Title} since {Employee.StartDate}");
        }
    }
}