using System;

namespace lab_2_3_oop
{
    class task3
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Oleg", "Ivanov");
            employee.Print();

            Console.WriteLine("Type an employee's post:");
            employee.post = Console.ReadLine();

            Console.WriteLine("Type an employee's expirience:");
            employee.expirience = Convert.ToInt32(Console.ReadLine());
            employee.PostChoosing();

            Console.WriteLine("Type employee's work hours:");
            employee.WorkHours = Convert.ToDouble(Console.ReadLine());
            employee.SalaryCounting();
            Console.ReadKey();
        }
    }
}
