using System;

namespace EmployeeData
{
    class Program
    {
        static void Main(string[] args)
        {
            var firtstName = Console.ReadLine();
            var lastName = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var sex = char.Parse(Console.ReadLine());
            var personalId = long.Parse(Console.ReadLine());
            var employeeNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("First name: {0}\nLast name: {1}\nAge: {2}\nGender: {3}\nPersonal ID: {4}\nUnique Employee number: {5}", firtstName, lastName, age, sex, personalId, employeeNumber);
        }
    }
}
