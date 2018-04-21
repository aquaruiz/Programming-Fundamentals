using System;

namespace Employee_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var employeeId = int.Parse(Console.ReadLine());
            var monthlySalary = double.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Employee ID: {employeeId:d8}");
            Console.WriteLine($"Salary: {monthlySalary:f2}");
        }
    }
}
