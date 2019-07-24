using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Author: Yeseul Kang
 * #301029474
 * Last modified date: 19-07-24
 * Description: It is BMI calculator
 * Revision history:
 * 19-07-23 Yeseul Kang Built basic code and UI
 * 19-07-24 Yeseul Kang Built calculating code
 * 19-07-24 Yeseul Kang Added splash page and edited some code
 * 19-07-24 Yeseul Kang Added progress bar and edited some code
 * 
 */
namespace BMICalculator
{
    static class Program
    {
        public static StartingPage startingPage;
        public static BMICalculator bMICalculator;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            startingPage = new StartingPage();
            bMICalculator = new BMICalculator();
            Application.Run(startingPage);
        }
    }
}
