using System;
using System.Collections.Generic;
using System.Text;

namespace VogtPayroll6
{
    class PayrollConsoleReader
    {

        public Employee AddEmployee()
        {
            Console.WriteLine(); 

            Console.Write("Please enter employee number: ");
            var empNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter hours worked: ");
            var empHoursWorked = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter pay rate: ");
            var empPayrate = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Please enter tax rate deduction: ");
            var empTaxRate = Convert.ToDecimal(Console.ReadLine());

            return new Employee(empNumber, empHoursWorked, empPayrate, empTaxRate);
        }
    }
}
