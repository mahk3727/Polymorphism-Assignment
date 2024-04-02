using System;

namespace EmployeeInterfaceDemo
{
    // Define the IQuittable interface
    interface IQuittable
    {
        void Quit();
    }

    // Define the Employee class
    class Employee : IQuittable
    {
        // Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Method to implement from the IQuittable interface
        public void Quit()
        {
            Console.WriteLine($"{FirstName} {LastName} has quit the company.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an Employee object
            Employee employee = new Employee
            {
                FirstName = "Shahrukh",
                LastName = "Khan"
            };

            // Call Quit() method using polymorphism
            // Since Employee class implements IQuittable interface, it can be treated as IQuittable
            IQuittable quittableEmployee = employee;
            quittableEmployee.Quit();

            Console.ReadLine(); // Keep console window open
        }
    }
}
