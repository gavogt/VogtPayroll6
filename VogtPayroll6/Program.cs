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
            Display display = new Display();
            Employee[] empArray = default;
            display.PrintMenu(empArray);
        }
    }
}
