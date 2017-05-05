using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpQuiz
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime HireDate { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return $"First Name: {FirstName}, Last Name: {LastName}, Hire Date: {HireDate}, Email: {Email}";
        }
    }

    // CloneEmployee Deep Copy //
    
    //public static Employee CloneEmployee(Employee employee)
    //    {
    //    employee = new Employee
    //    }

    // Number of Days Hired Method //
    
    //public int HiredDays( DateTime start )
    //{
    //    start = HireDate;
    //    return (DateTime.Now - Employee.HireDate);
    //}



 
}
