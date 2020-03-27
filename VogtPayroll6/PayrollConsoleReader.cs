using System;
using System.Collections.Generic;
using System.Text;

namespace VogtPayroll6
{
    class PayrollConsoleReader
    {
        public Employee[] HowManyEmployees()
        {
            Display display = new Display();
 
            int howMany;
            do {

                Console.WriteLine("How many employees would you like to add? The max is 15");
                howMany = Convert.ToInt32(Console.ReadLine());
            } while (howMany < 0 || howMany > 15);

            Employee[] empArray = new Employee[howMany];

            for (int i = 0; i < empArray.Length; i++)
            {
                Employee emp = AddEmployee();

                empArray[i] = emp;
            }

            display.PrintMenu();
            return empArray;
        }

        public Employee AddEmployee()
        {
            Console.Write("Please enter employee number: ");
            var empNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter hours worked: ");
            var empHoursWorked = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter pay rate: ");
            var empPayrate = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Please enter tax rate deduction: ");
            var empTaxRate = Convert.ToDecimal(Console.ReadLine());

            return new Employee(empNumber, empHoursWorked, empPayrate, empTaxRate);
        }
    }
}
