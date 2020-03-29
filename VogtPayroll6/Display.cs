using System;
using System.Collections.Generic;
using System.Text;

namespace VogtPayroll6
{
    class Display
    {
        private readonly Payroll _payroll;

        public Display(Payroll payroll)
        {
            _payroll = payroll;
        }

        public void PrintMenu(Employee[] empArray)
        {
            PayrollConsoleReader payrollConsoleReader = new PayrollConsoleReader();
            char option;

            EnterSelectionMenu();

            option = Convert.ToChar(Console.ReadLine().ToLower());
            do
            {
                switch (option)
                {
                    case 'a':
                        empArray = _payroll.HowManyEmployees();
                        PrintMenu(empArray);
                        break;
                    case 'd':
                        PrintEmployeeInfo(empArray);
                        Console.WriteLine("Here!");
                        PrintMenu(empArray);
                        break;
                    case 'p':
                        _payroll.DisplayPayroll(empArray);
                        PrintMenu(empArray);
                        break;
                    case 's':
                        PrintAllEmployeeInfo(empArray);
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
            Console.WriteLine();
            Console.WriteLine("Please enter 'a' to add an employee info");
            Console.WriteLine("Enter 'd' to display employee info");
            Console.WriteLine("Enter 'p' to display total _payroll");
            Console.WriteLine("Enter 's' to display info of all employees");
            Console.WriteLine("Enter 'z' to exit program");

        }

        public void PrintEmployeeInfo(Employee[] empArray)
        {
            Console.WriteLine();
            Console.Write("Please enter employee number: ");
            var empNum = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < empArray.Length; i++)
            {
                if (empArray[i].EmpNumber == empNum)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Hours Worked: {empArray[i].EmpNumber} ");
                    Console.WriteLine($"Pay rate: {empArray[i].EmpPayrate:C2}");
                    Console.WriteLine($"Tax deduction: {empArray[i].EmpTaxRate}%");
                    Console.WriteLine($"Total pay: {empArray[i].GetGrossPay()}");
                }
            }

            PrintMenu(empArray);

        }

        public void PrintAllEmployeeInfo(Employee[] empArray)
        {

            foreach (var employee in empArray)
            {
                Console.WriteLine();
                Console.WriteLine($"Emp ID: {employee.EmpNumber}");
                Console.WriteLine($"Hours Worked: {employee.EmpHoursWorked}");
                Console.WriteLine($"Pay rate: {employee.EmpPayrate:C2}");
                Console.WriteLine($"Tax deduction: {employee.EmpTaxRate}%");
                Console.WriteLine($"Total pay: {employee.GetGrossPay():C2}");
            }

            PrintMenu(empArray);

        }
    }
}
