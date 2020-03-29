using System;
using System.Collections.Generic;
using System.Text;

namespace VogtPayroll6
{
    class Payroll
    {
        public decimal grossPaytotal = 0.00m;

        public void DisplayPayroll(Employee[] empArray) {

            foreach (var employee in empArray)
            {
                grossPaytotal += employee.GetGrossPay();
            }

            Console.WriteLine($"Payroll: {grossPaytotal:C2}");
            Console.WriteLine();
      
        }

        public Employee[] HowManyEmployees()
        {
            PayrollConsoleReader payrollConsoleReader = new PayrollConsoleReader();
            int howMany;
            do
            {

                Console.WriteLine("How many employees would you like to add? The max is 15");
                howMany = Convert.ToInt32(Console.ReadLine());
            } while (howMany < 0 || howMany > 15);

            Employee[] empArray = new Employee[howMany];

            for (int i = 0; i < empArray.Length; i++)
            {
                Employee emp = payrollConsoleReader.AddEmployee();

                empArray[i] = emp;
            }

            return empArray;
        }


    }
}
