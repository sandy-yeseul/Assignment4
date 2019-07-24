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
            this.NumericKeyboardPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ThreeButton = new System.Windows.Forms.Button();
            this.TwoButton = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.SixButton = new System.Windows.Forms.Button();
            this.FiveButton = new System.Windows.Forms.Button();
            this.FourButton = new System.Windows.Forms.Button();
            this.NineButton = new System.Windows.Forms.Button();
            this.EightButton = new System.Windows.Forms.Button();
            this.SevenButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.BackSpaceButton = new System.Windows.Forms.Button();
            this.ZeroButton = new System.Windows.Forms.Button();
            this.DoneButton = new System.Windows.Forms.Button();
            this.BMITableLayoutPanel.SuspendLayout();
            this.NumericKeyboardPanel.SuspendLayout();
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
            this.weightBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.weightBox.TextChanged += new System.EventHandler(this.weightBox_TextChanged);
            // 
            // heightBox
            // 
            this.heightBox.Location = new System.Drawing.Point(142, 3);
            this.heightBox.Name = "heightBox";
            this.heightBox.Size = new System.Drawing.Size(115, 32);
            this.heightBox.TabIndex = 3;
            this.heightBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.heightBox.TextChanged += new System.EventHandler(this.heightBox_TextChanged);
            // 
            // MetricRadioButton
            // 
            this.MetricRadioButton.AutoSize = true;
            this.MetricRadioButton.Font = new System.Drawing.Font("Gulim", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MetricRadioButton.Location = new System.Drawing.Point(19, 145);
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
            this.calculateBMIButton.Click += new System.EventHandler(this.calculateBMIButton_Click);
            // 
            // BMITextBox
            // 
            this.BMITextBox.Location = new System.Drawing.Point(75, 232);
            this.BMITextBox.Name = "BMITextBox";
            this.BMITextBox.ReadOnly = true;
            this.BMITextBox.Size = new System.Drawing.Size(132, 46);
            this.BMITextBox.TabIndex = 7;
            this.BMITextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.BMIScaleTextBox.ReadOnly = true;
            this.BMIScaleTextBox.Size = new System.Drawing.Size(278, 128);
            this.BMIScaleTextBox.TabIndex = 9;
            this.BMIScaleTextBox.Text = "Underweight: less than 18.5\r\n\r\nNormal: between 18.5 and 24.9\r\n\r\nOverweight: betwe" +
    "en 25 and 29.9\r\n\r\nObese: 30 or greater";
            // 
            // NumericKeyboardPanel
            // 
            this.NumericKeyboardPanel.ColumnCount = 4;
            this.NumericKeyboardPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.NumericKeyboardPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.NumericKeyboardPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.NumericKeyboardPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.NumericKeyboardPanel.Controls.Add(this.ThreeButton, 2, 2);
            this.NumericKeyboardPanel.Controls.Add(this.TwoButton, 1, 2);
            this.NumericKeyboardPanel.Controls.Add(this.button10, 0, 2);
            this.NumericKeyboardPanel.Controls.Add(this.SixButton, 2, 1);
            this.NumericKeyboardPanel.Controls.Add(this.FiveButton, 1, 1);
            this.NumericKeyboardPanel.Controls.Add(this.FourButton, 0, 1);
            this.NumericKeyboardPanel.Controls.Add(this.NineButton, 2, 0);
            this.NumericKeyboardPanel.Controls.Add(this.EightButton, 1, 0);
            this.NumericKeyboardPanel.Controls.Add(this.SevenButton, 0, 0);
            this.NumericKeyboardPanel.Controls.Add(this.ClearButton, 3, 1);
            this.NumericKeyboardPanel.Controls.Add(this.BackSpaceButton, 3, 0);
            this.NumericKeyboardPanel.Controls.Add(this.ZeroButton, 0, 3);
            this.NumericKeyboardPanel.Controls.Add(this.DoneButton, 3, 2);
            this.NumericKeyboardPanel.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumericKeyboardPanel.Location = new System.Drawing.Point(154, 145);
            this.NumericKeyboardPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NumericKeyboardPanel.Name = "NumericKeyboardPanel";
            this.NumericKeyboardPanel.RowCount = 4;
            this.NumericKeyboardPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.NumericKeyboardPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.NumericKeyboardPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.NumericKeyboardPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.NumericKeyboardPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.NumericKeyboardPanel.Size = new System.Drawing.Size(277, 197);
            this.NumericKeyboardPanel.TabIndex = 11;
            // 
            // ThreeButton
            // 
            this.ThreeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ThreeButton.BackColor = System.Drawing.Color.SteelBlue;
            this.ThreeButton.ForeColor = System.Drawing.Color.White;
            this.ThreeButton.Location = new System.Drawing.Point(142, 101);
            this.ThreeButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ThreeButton.Name = "ThreeButton";
            this.ThreeButton.Size = new System.Drawing.Size(61, 43);
            this.ThreeButton.TabIndex = 8;
            this.ThreeButton.Tag = "3";
            this.ThreeButton.Text = "3";
            this.ThreeButton.UseVisualStyleBackColor = false;
            // 
            // TwoButton
            // 
            this.TwoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TwoButton.BackColor = System.Drawing.Color.SteelBlue;
            this.TwoButton.ForeColor = System.Drawing.Color.White;
            this.TwoButton.Location = new System.Drawing.Point(73, 101);
            this.TwoButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TwoButton.Name = "TwoButton";
            this.TwoButton.Size = new System.Drawing.Size(61, 43);
            this.TwoButton.TabIndex = 7;
            this.TwoButton.Tag = "2";
            this.TwoButton.Text = "2";
            this.TwoButton.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button10.BackColor = System.Drawing.Color.SteelBlue;
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(4, 101);
            this.button10.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(61, 43);
            this.button10.TabIndex = 6;
            this.button10.Tag = "1";
            this.button10.Text = "1";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // SixButton
            // 
            this.SixButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SixButton.BackColor = System.Drawing.Color.SteelBlue;
            this.SixButton.ForeColor = System.Drawing.Color.White;
            this.SixButton.Location = new System.Drawing.Point(142, 52);
            this.SixButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SixButton.Name = "SixButton";
            this.SixButton.Size = new System.Drawing.Size(61, 43);
            this.SixButton.TabIndex = 5;
            this.SixButton.Tag = "6";
            this.SixButton.Text = "6";
            this.SixButton.UseVisualStyleBackColor = false;
            // 
            // FiveButton
            // 
            this.FiveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FiveButton.BackColor = System.Drawing.Color.SteelBlue;
            this.FiveButton.ForeColor = System.Drawing.Color.White;
            this.FiveButton.Location = new System.Drawing.Point(73, 52);
            this.FiveButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FiveButton.Name = "FiveButton";
            this.FiveButton.Size = new System.Drawing.Size(61, 43);
            this.FiveButton.TabIndex = 4;
            this.FiveButton.Tag = "5";
            this.FiveButton.Text = "5";
            this.FiveButton.UseVisualStyleBackColor = false;
            // 
            // FourButton
            // 
            this.FourButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FourButton.BackColor = System.Drawing.Color.SteelBlue;
            this.FourButton.ForeColor = System.Drawing.Color.White;
            this.FourButton.Location = new System.Drawing.Point(4, 52);
            this.FourButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FourButton.Name = "FourButton";
            this.FourButton.Size = new System.Drawing.Size(61, 43);
            this.FourButton.TabIndex = 3;
            this.FourButton.Tag = "4";
            this.FourButton.Text = "4";
            this.FourButton.UseVisualStyleBackColor = false;
            // 
            // NineButton
            // 
            this.NineButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NineButton.BackColor = System.Drawing.Color.SteelBlue;
            this.NineButton.ForeColor = System.Drawing.Color.White;
            this.NineButton.Location = new System.Drawing.Point(142, 3);
            this.NineButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NineButton.Name = "NineButton";
            this.NineButton.Size = new System.Drawing.Size(61, 43);
            this.NineButton.TabIndex = 2;
            this.NineButton.Tag = "9";
            this.NineButton.Text = "9";
            this.NineButton.UseVisualStyleBackColor = false;
            // 
            // EightButton
            // 
            this.EightButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EightButton.BackColor = System.Drawing.Color.SteelBlue;
            this.EightButton.ForeColor = System.Drawing.Color.White;
            this.EightButton.Location = new System.Drawing.Point(73, 3);
            this.EightButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EightButton.Name = "EightButton";
            this.EightButton.Size = new System.Drawing.Size(61, 43);
            this.EightButton.TabIndex = 1;
            this.EightButton.Tag = "8";
            this.EightButton.Text = "8";
            this.EightButton.UseVisualStyleBackColor = false;
            // 
            // SevenButton
            // 
            this.SevenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SevenButton.BackColor = System.Drawing.Color.SteelBlue;
            this.SevenButton.ForeColor = System.Drawing.Color.White;
            this.SevenButton.Location = new System.Drawing.Point(4, 3);
            this.SevenButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SevenButton.Name = "SevenButton";
            this.SevenButton.Size = new System.Drawing.Size(61, 43);
            this.SevenButton.TabIndex = 0;
            this.SevenButton.Tag = "7";
            this.SevenButton.Text = "7";
            this.SevenButton.UseVisualStyleBackColor = false;
            // 
            // ClearButton
            // 
            this.ClearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearButton.BackColor = System.Drawing.Color.DarkOrange;
            this.ClearButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.ForeColor = System.Drawing.Color.White;
            this.ClearButton.Location = new System.Drawing.Point(211, 52);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(62, 43);
            this.ClearButton.TabIndex = 13;
            this.ClearButton.Tag = "clear";
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            // 
            // BackSpaceButton
            // 
            this.BackSpaceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BackSpaceButton.BackColor = System.Drawing.Color.SteelBlue;
            this.BackSpaceButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BackSpaceButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackSpaceButton.ForeColor = System.Drawing.Color.White;
            this.BackSpaceButton.Location = new System.Drawing.Point(211, 3);
            this.BackSpaceButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BackSpaceButton.Name = "BackSpaceButton";
            this.BackSpaceButton.Size = new System.Drawing.Size(62, 43);
            this.BackSpaceButton.TabIndex = 14;
            this.BackSpaceButton.Tag = "back";
            this.BackSpaceButton.Text = "Delete";
            this.BackSpaceButton.UseVisualStyleBackColor = false;
            // 
            // ZeroButton
            // 
            this.ZeroButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ZeroButton.BackColor = System.Drawing.Color.SteelBlue;
            this.NumericKeyboardPanel.SetColumnSpan(this.ZeroButton, 2);
            this.ZeroButton.ForeColor = System.Drawing.Color.White;
            this.ZeroButton.Location = new System.Drawing.Point(4, 150);
            this.ZeroButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ZeroButton.Name = "ZeroButton";
            this.ZeroButton.Size = new System.Drawing.Size(130, 44);
            this.ZeroButton.TabIndex = 10;
            this.ZeroButton.Tag = "0";
            this.ZeroButton.Text = "0";
            this.ZeroButton.UseVisualStyleBackColor = false;
            // 
            // DoneButton
            // 
            this.DoneButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DoneButton.BackColor = System.Drawing.Color.SeaGreen;
            this.DoneButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoneButton.ForeColor = System.Drawing.Color.White;
            this.DoneButton.Location = new System.Drawing.Point(211, 101);
            this.DoneButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DoneButton.Name = "DoneButton";
            this.NumericKeyboardPanel.SetRowSpan(this.DoneButton, 2);
            this.DoneButton.Size = new System.Drawing.Size(62, 93);
            this.DoneButton.TabIndex = 11;
            this.DoneButton.Tag = "done";
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = false;
            // 
            // BMICalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 433);
            this.Controls.Add(this.NumericKeyboardPanel);
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
            this.Load += new System.EventHandler(this.BMICalculator_Load);
            this.BMITableLayoutPanel.ResumeLayout(false);
            this.BMITableLayoutPanel.PerformLayout();
            this.NumericKeyboardPanel.ResumeLayout(false);
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
        private System.Windows.Forms.TableLayoutPanel NumericKeyboardPanel;
        private System.Windows.Forms.Button ThreeButton;
        private System.Windows.Forms.Button TwoButton;
        private System.Windows.Forms.Button SixButton;
        private System.Windows.Forms.Button FiveButton;
        private System.Windows.Forms.Button NineButton;
        private System.Windows.Forms.Button EightButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button BackSpaceButton;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button FourButton;
        private System.Windows.Forms.Button SevenButton;
        private System.Windows.Forms.Button ZeroButton;
    }
}

