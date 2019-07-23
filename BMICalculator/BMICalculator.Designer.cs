namespace BMICalculator
{
    partial class BMICalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BMITableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.heightLabel = new System.Windows.Forms.Label();
            this.weightLabel = new System.Windows.Forms.Label();
            this.weightBox = new System.Windows.Forms.TextBox();
            this.heightBox = new System.Windows.Forms.TextBox();
            this.MetricRadioButton = new System.Windows.Forms.RadioButton();
            this.calculateBMIButton = new System.Windows.Forms.Button();
            this.BMITextBox = new System.Windows.Forms.TextBox();
            this.ImperialRadioButton = new System.Windows.Forms.RadioButton();
            this.BMIScaleTextBox = new System.Windows.Forms.TextBox();
            this.BMITableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BMITableLayoutPanel
            // 
            this.BMITableLayoutPanel.ColumnCount = 2;
            this.BMITableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BMITableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BMITableLayoutPanel.Controls.Add(this.heightLabel, 0, 0);
            this.BMITableLayoutPanel.Controls.Add(this.weightLabel, 0, 1);
            this.BMITableLayoutPanel.Controls.Add(this.weightBox, 1, 1);
            this.BMITableLayoutPanel.Controls.Add(this.heightBox, 1, 0);
            this.BMITableLayoutPanel.Font = new System.Drawing.Font("Gulim", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BMITableLayoutPanel.Location = new System.Drawing.Point(12, 12);
            this.BMITableLayoutPanel.Name = "BMITableLayoutPanel";
            this.BMITableLayoutPanel.RowCount = 2;
            this.BMITableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BMITableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BMITableLayoutPanel.Size = new System.Drawing.Size(278, 127);
            this.BMITableLayoutPanel.TabIndex = 0;
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(3, 0);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(101, 22);
            this.heightLabel.TabIndex = 2;
            this.heightLabel.Text = "My Height";
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(3, 63);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(106, 22);
            this.weightLabel.TabIndex = 4;
            this.weightLabel.Text = "My Weight";
            // 
            // weightBox
            // 
            this.weightBox.Location = new System.Drawing.Point(142, 66);
            this.weightBox.Name = "weightBox";
            this.weightBox.Size = new System.Drawing.Size(115, 32);
            this.weightBox.TabIndex = 5;
            // 
            // heightBox
            // 
            this.heightBox.Location = new System.Drawing.Point(142, 3);
            this.heightBox.Name = "heightBox";
            this.heightBox.Size = new System.Drawing.Size(115, 32);
            this.heightBox.TabIndex = 3;
            // 
            // MetricRadioButton
            // 
            this.MetricRadioButton.AutoSize = true;
            this.MetricRadioButton.Font = new System.Drawing.Font("Gulim", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MetricRadioButton.Location = new System.Drawing.Point(12, 145);
            this.MetricRadioButton.Name = "MetricRadioButton";
            this.MetricRadioButton.Size = new System.Drawing.Size(104, 29);
            this.MetricRadioButton.TabIndex = 1;
            this.MetricRadioButton.TabStop = true;
            this.MetricRadioButton.Text = "Metric";
            this.MetricRadioButton.UseVisualStyleBackColor = true;
            // 
            // calculateBMIButton
            // 
            this.calculateBMIButton.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.calculateBMIButton.Location = new System.Drawing.Point(75, 180);
            this.calculateBMIButton.Name = "calculateBMIButton";
            this.calculateBMIButton.Size = new System.Drawing.Size(132, 46);
            this.calculateBMIButton.TabIndex = 6;
            this.calculateBMIButton.Text = "CalculateBMI";
            this.calculateBMIButton.UseVisualStyleBackColor = true;
            // 
            // BMITextBox
            // 
            this.BMITextBox.Location = new System.Drawing.Point(75, 232);
            this.BMITextBox.Name = "BMITextBox";
            this.BMITextBox.Size = new System.Drawing.Size(132, 46);
            this.BMITextBox.TabIndex = 7;
            // 
            // ImperialRadioButton
            // 
            this.ImperialRadioButton.AutoSize = true;
            this.ImperialRadioButton.Font = new System.Drawing.Font("Gulim", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ImperialRadioButton.Location = new System.Drawing.Point(154, 145);
            this.ImperialRadioButton.Name = "ImperialRadioButton";
            this.ImperialRadioButton.Size = new System.Drawing.Size(118, 29);
            this.ImperialRadioButton.TabIndex = 8;
            this.ImperialRadioButton.TabStop = true;
            this.ImperialRadioButton.Text = "Imperial";
            this.ImperialRadioButton.UseVisualStyleBackColor = true;
            // 
            // BMIScaleTextBox
            // 
            this.BMIScaleTextBox.Font = new System.Drawing.Font("Gulim", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BMIScaleTextBox.Location = new System.Drawing.Point(12, 284);
            this.BMIScaleTextBox.Multiline = true;
            this.BMIScaleTextBox.Name = "BMIScaleTextBox";
            this.BMIScaleTextBox.Size = new System.Drawing.Size(278, 128);
            this.BMIScaleTextBox.TabIndex = 9;
            this.BMIScaleTextBox.Text = "Underweight: less than 18.5\r\n\r\nNormal: between 18.5 and 24.9\r\n\r\nOverweight: betwe" +
    "en 25 and 29.9\r\n\r\nObese: 30 or greater";
            // 
            // BMICalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 433);
            this.Controls.Add(this.BMIScaleTextBox);
            this.Controls.Add(this.ImperialRadioButton);
            this.Controls.Add(this.BMITextBox);
            this.Controls.Add(this.calculateBMIButton);
            this.Controls.Add(this.MetricRadioButton);
            this.Controls.Add(this.BMITableLayoutPanel);
            this.Font = new System.Drawing.Font("Gulim", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximizeBox = false;
            this.Name = "BMICalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMICalculator";
            this.BMITableLayoutPanel.ResumeLayout(false);
            this.BMITableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel BMITableLayoutPanel;
        private System.Windows.Forms.RadioButton MetricRadioButton;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.TextBox heightBox;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.TextBox weightBox;
        private System.Windows.Forms.Button calculateBMIButton;
        private System.Windows.Forms.TextBox BMITextBox;
        private System.Windows.Forms.RadioButton ImperialRadioButton;
        private System.Windows.Forms.TextBox BMIScaleTextBox;
    }
}

