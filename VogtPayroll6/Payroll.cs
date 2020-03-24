using System;
using System.Collections.Generic;
using System.Text;

namespace VogtPayroll6
{
    class Payroll
    {

        public void DisplayPayroll(Employee[] empArray) {
            decimal grossPaytotal = 0.00m;

            foreach (var employee in empArray)
            {
                grossPaytotal += employee.GetGrossPay();
            }
        }

    }
}
