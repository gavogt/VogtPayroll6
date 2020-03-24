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

            display.PrintMenu();
        }
    }
}
