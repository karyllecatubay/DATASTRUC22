using System;
using System.Windows.Forms;

namespace EnhancedCalculator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Enable visual styles for a more modern look
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            // Start the calculator application
            Application.Run(new CalculatorForm());
        }
    }
}
