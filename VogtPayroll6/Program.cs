using System;

namespace VogtPayroll6
{
    class Program
    {
        static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            Payroll payroll = new Payroll();
            Display display = new Display(payroll);
            Employee[] empArray = default;
            display.PrintMenu(empArray);

        }
    }
}
