using System;

namespace EmployeeInterfaceApp
{
    // Define an interface named IQuittable
    interface IQuittable
    {
        // Declare a method named Quit
        void Quit();
    }

    // Define a class named Employee that implements the IQuittable interface
    class Employee : IQuittable
    {
        // Properties for employee information
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Implementation of the Quit() method
        public void Quit()
        {
            Console.WriteLine($"{FirstName} {LastName} has quit the job. Best of luck!");
        }
    }

    // Main class containing program entry point
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new Employee object
            Employee emp = new Employee()
            {
                FirstName = "John",
                LastName = "Doe"
            };

            // Use polymorphism: assign the Employee object to an IQuittable interface reference
            IQuittable quittableEmp = emp;

            // Call the Quit method through the interface reference
            quittableEmp.Quit();

            // Keep console window open until key is pressed
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
