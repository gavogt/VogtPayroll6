using System;
using System.Collections.Generic;
using System.Text;

namespace VogtPayroll6
{
    class Employee
    {
        private int empNumber;
        private int empHoursWorked;
        private decimal empPayrate;
        private decimal empTaxRate;

        public int EmpNumber { get => empNumber; }
        public int EmpHoursWorked { get => empHoursWorked; }
        public decimal EmpPayrate { get => empPayrate; }
        public decimal EmpTaxRate { get => empTaxRate; }

        public Employee(int empNumber, int empHoursWorked, decimal empPayrate, decimal empTaxRate)
        {
            this.empNumber = empNumber;
            this.empHoursWorked = empHoursWorked;
            this.empPayrate = empPayrate;
            this.empTaxRate = empTaxRate;
        }

        public void DisplayEmployeeInfo(Employee[] empArray)
        {
            Console.Write("Please enter employee number: ");
            var empNum = Convert.ToInt32(Console.ReadLine());
            var temp = empArray[empNum];
            if (empArray[empNum].EmpNumber == empNum)
            {
                Console.WriteLine($"Hours Worked: {empArray[empNum].EmpNumber} ");
                Console.WriteLine($"Pay rate: {empArray[empNum].EmpPayrate:C2}");
                Console.WriteLine($"Tax deduction: {empArray[empNum].EmpTaxRate}%");
                Console.WriteLine($"Total pay: {empArray[empNum].GetGrossPay()}");
            }

            Program.Run();
        }
        public decimal GetGrossPay() {

            return empHoursWorked * empPayrate * empTaxRate;
        }

        public decimal GetTaxDeduction()
        {
            return (GetGrossPay() - (EmpTaxRate % 100.00m * GetGrossPay()));

        }
    }
}
