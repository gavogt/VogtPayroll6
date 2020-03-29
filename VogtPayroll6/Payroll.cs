using System;
using System.Collections.Generic;
using System.Text;

namespace VogtPayroll6
{

    class Payroll
    {
        public decimal grossPaytotal = 0.00m;

        #region DisplayPayRoll
        /// <summary>
        /// Displays total gross pay
        /// </summary>
        public void DisplayPayroll(Employee[] empArray) {
            var grossPaytotal = 0.00m;

            foreach (var employee in empArray)
            {
                grossPaytotal += employee.GetGrossPay();
            }

            Console.WriteLine($"Payroll: {grossPaytotal:C2}");
            Console.WriteLine();
      
        }
        #endregion

    }
}
