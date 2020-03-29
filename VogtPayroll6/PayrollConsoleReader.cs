using System;
using System.Collections.Generic;
using System.Text;

namespace VogtPayroll6
{
    class PayrollConsoleReader
    {
        #region HowManyEmployees
        /// <summary>
        /// Asks how many users want to be added
        /// </summary>
        /// <returns>An employee array with added users</returns>
        public Employee[] HowManyEmployees()
        {
            int howMany;
            do
            {

                Console.WriteLine("How many employees would you like to add? The max is 15");
                howMany = Convert.ToInt32(Console.ReadLine());
            } while (howMany < 0 || howMany > 15);

            Employee[] empArray = new Employee[howMany];

            for (int i = 0; i < empArray.Length; i++)
            {
                Employee emp = AddEmployee();

                empArray[i] = emp;
            }

            return empArray;

        }
        #endregion

        #region AddEmployee
        /// <summary>
        /// Adds an employee
        /// </summary>
        /// <returns>An employee</returns>
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
        #endregion

    }
}
