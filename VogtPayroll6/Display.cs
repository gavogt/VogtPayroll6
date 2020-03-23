using System;
using System.Collections.Generic;
using System.Text;

namespace VogtPayroll6
{
    class Display
    {
        public void PrintMenu()
        {
            char option;

            option = Convert.ToChar(Console.ReadLine().ToLower());
            PayrollConsoleReader payrollConsoleReader = new PayrollConsoleReader();

            switch (option)
            {
                case 'a':
                    payrollConsoleReader.AddEmployee();
                    break;
                case 'd':
                    break;
                case 'p':
                    break;
                case 's':
                    break;
                case 'z':
                    Console.Clear();
                    Console.WriteLine("Exiting...");
                    System.Environment.Exit(0);
                    break;
                default:
                    break;
            }
        }
    }
}
