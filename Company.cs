using System;
using System.Collections.Generic;

namespace Classes
{
    public class Company
    {

        // Some readonly properties (let's talk about gets, baby)
        public string? Name { get; set; }
        public DateTime CreatedOn { get; set; }
        public List<Employee>? Employees {get; set;}
        // Create a public property for holding a list of current employees

              public Company ()
        {
             Name = "";
             CreatedOn = new DateTime();
        }
              public Company (string name, DateTime Date)
        {
             Name = name;
             CreatedOn = Date;
        }
        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties

        */
    }
}