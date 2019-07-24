using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMICalculator
{
    public partial class BMICalculator : Form
    {
        public double Height { get; set; }
        public double Weight { get; set; }
        public double BMI { get; set; }

        public BMICalculator()
        {
            InitializeComponent();
        }

        private void BMICalculator_Load(object sender, EventArgs e)
        {
            BMITextBox.Visible = false;
            BMIScaleTextBox.Visible = false;
        }
        

        private void heightBox_TextChanged(object sender, EventArgs e)
        {

            Height = double.Parse(heightBox.Text);
        }

        private void weightBox_TextChanged(object sender, EventArgs e)
        {
            Weight = double.Parse(weightBox.Text);
        }

        private void calculateBMIButton_Click(object sender, EventArgs e)
        {
            if (MetricRadioButton.Checked)
            {
                BMI = Weight / (Height * Height);
            }
            else if (ImperialRadioButton.Checked)
            {
                BMI = (Weight*703) / (Height * Height);
            }
            BMI = Math.Round(BMI, 1);
            BMIScaleTextBox.Visible = true;
            BMITextBox.Visible = true;
            BMITextBox.Text = ""+ BMI;
        }

        private void BMICalculator_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
