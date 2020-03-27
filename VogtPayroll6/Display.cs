using System;
using System.Collections.Generic;
using System.Text;

namespace VogtPayroll6
{
    class Display
    {
        public void PrintMenu(Employee[] empArray)
        {
            PayrollConsoleReader payrollConsoleReader = new PayrollConsoleReader();
            char option;
            Payroll payroll = new Payroll();
            EnterSelectionMenu();

            option = Convert.ToChar(Console.ReadLine().ToLower());
            do
            {
                switch (option)
                {
                    case 'a':
                        empArray = payrollConsoleReader.HowManyEmployees();
                        PrintMenu(empArray);
                        break;
                    case 'd':
                        DisplayEmployeeInfo(empArray);
                        Console.WriteLine("Here!");
                        PrintMenu(empArray);
                        break;
                    case 'p':
                        Console.WriteLine($"Gross pay total: {payroll.grossPaytotal}");
                        break;
                    case 's':
                        DisplayAllEmployeeInfo(empArray);
                        break;
                    case 'z':
                        Console.Clear();
                        Console.WriteLine("Exiting...");
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please select 'a', 'd', 'p', 's' or 'z'");
                        break;
                }
            } while (option != 'z');

        }
        public void EnterSelectionMenu()
        {
            Console.WriteLine("Please enter 'a' to add an employee info");
            Console.WriteLine("Enter 'd' to display employee info");
            Console.WriteLine("Enter 'p' to display total payroll");
            Console.WriteLine("Enter 's' to display info of all employees");
            Console.WriteLine("Enter 'z' to exit program");

        }

        public void DisplayEmployeeInfo(Employee[] empArray)
        {
            Console.Write("Please enter employee number: ");
            var empNum = Convert.ToInt32(Console.ReadLine());

            if (empArray[0].EmpNumber == empNum)
            {
                Console.WriteLine($"Hours Worked: {empArray[0].EmpNumber} ");
                Console.WriteLine($"Pay rate: {empArray[0].EmpPayrate:C2}");
                Console.WriteLine($"Tax deduction: {empArray[0].EmpTaxRate}%");
                Console.WriteLine($"Total pay: {empArray[0].GetGrossPay()}");
            }

            PrintMenu(empArray);   
        }

        public void DisplayAllEmployeeInfo(Employee[] empArray)
        {

            foreach (var employee in empArray)
            {
                Console.WriteLine($"Hours Worked: {employee.EmpHoursWorked}");
                Console.WriteLine($"Pay rate: {employee.EmpPayrate:C2}");
                Console.WriteLine($"Tax deduction: {employee.EmpTaxRate}%");
                Console.WriteLine($"Total pay: {employee.GetGrossPay()}");

            }

            Console.WriteLine();
            PrintMenu(empArray);
        }
    }
}
