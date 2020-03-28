﻿using System;
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
                        payroll.DisplayPayroll(empArray);
                        PrintMenu(empArray);
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
            Console.WriteLine();
            Console.WriteLine("Please enter 'a' to add an employee info");
            Console.WriteLine("Enter 'd' to display employee info");
            Console.WriteLine("Enter 'p' to display total payroll");
            Console.WriteLine("Enter 's' to display info of all employees");
            Console.WriteLine("Enter 'z' to exit program");

        }

        public void DisplayEmployeeInfo(Employee[] empArray)
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

        public void DisplayAllEmployeeInfo(Employee[] empArray)
        {

            foreach (var employee in empArray)
            {
                Console.WriteLine();
                Console.WriteLine($"HoursID: {employee.EmpNumber}");
                Console.WriteLine($"Hours Worked: {employee.EmpHoursWorked}");
                Console.WriteLine($"Pay rate: {employee.EmpPayrate:C2}");
                Console.WriteLine($"Tax deduction: {employee.EmpTaxRate}%");
                Console.WriteLine($"Total pay: {employee.GetGrossPay():C2}");
            }

            PrintMenu(empArray);        }
    }
}
