﻿using System;
using System.Collections.Generic;
using System.Text;

namespace VogtPayroll6
{
    class PayrollConsoleReader
    {
        public void HowManyEmployees()
        {
            int howMany;
            do {

                Console.WriteLine("How many employees would you like to add? The max is 15");
                howMany = Convert.ToInt32(Console.ReadLine());
            } while (howMany < 0 || howMany > 15);

            double[] empArray = new double[howMany];



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
