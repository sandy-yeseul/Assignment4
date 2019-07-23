using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Author: Yeseul Kang
 * #301029474
 * Last modified date: 19-07-23
 * Description: It is BMI calculator
 * Revision history:
 * 19-07-23 Yeseul Kang Built basic code
 */
namespace BMICalculator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BMICalculator());
        }
    }
}
