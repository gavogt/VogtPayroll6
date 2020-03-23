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

        public Employee(int empNumber, int empHoursWorked, decimal empPayrate, decimal empTaxRate)
        {
            this.empNumber = empNumber;
            this.empHoursWorked = empHoursWorked;
            this.empPayrate = empPayrate;
            this.empTaxRate = empTaxRate;
        }
    }
}
