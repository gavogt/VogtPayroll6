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

        #region GetGrossPay
        /// <summary>
        /// Get gross pay
        /// </summary>
        /// <returns>Gross pay</returns>
        public decimal GetGrossPay() {

            return empHoursWorked * empPayrate;

        }
        #endregion

        #region GetTaxDeduction
        /// <summary>
        /// Gets tax deductions
        /// </summary>
        /// <returns>Tax deductions</returns>
        public decimal GetTaxDeduction()
        {
            return (GetGrossPay() - (EmpTaxRate % 100.00m * GetGrossPay()));

        }
        #endregion
    }
}
