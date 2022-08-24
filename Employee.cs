using System;
using System.Collections.Generic;


public class Employee
{
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; }

         public Employee() 
        {
             FirstName = "";
             LastName = "";
             Title =  "";  
             StartDate = new DateTime();
        }
}
