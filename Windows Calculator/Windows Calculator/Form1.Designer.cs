namespace Windows_Calculator
{
    partial class Calculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            screenLabel = new Label();
            commaButton = new Button();
            number0Button = new Button();
            equalsButton = new Button();
            button4 = new Button();
            button5 = new Button();
            multip = new Button();
            backSpaceButton = new Button();
            number5Button = new Button();
            number4Button = new Button();
            number6Button = new Button();
            number7Button = new Button();
            number8button = new Button();
            number9Button = new Button();
            clearButton = new Button();
            button1 = new Button();
            number1Button = new Button();
            number2Button = new Button();
            number3Button = new Button();
            minus = new Button();
            info = new Label();
            SuspendLayout();
            // 
            // screenLabel
            // 
            screenLabel.BackColor = Color.White;
            screenLabel.Font = new Font("Segoe UI", 25F);
            screenLabel.Location = new Point(9, 14);
            screenLabel.Name = "screenLabel";
            screenLabel.Size = new Size(313, 64);
            screenLabel.TabIndex = 0;
            screenLabel.Text = "0";
            screenLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // commaButton
            // 
            commaButton.BackColor = Color.Gray;
            commaButton.Font = new Font("Impact", 25F);
            commaButton.Location = new Point(12, 406);
            commaButton.Name = "commaButton";
            commaButton.Size = new Size(73, 72);
            commaButton.TabIndex = 1;
            commaButton.Text = ",";
            commaButton.UseVisualStyleBackColor = false;
            commaButton.Click += commaButton_Click;
            // 
            // number0Button
            // 
            number0Button.Font = new Font("Impact", 25F);
            number0Button.Location = new Point(91, 406);
            number0Button.Name = "number0Button";
            number0Button.Size = new Size(73, 72);
            number0Button.TabIndex = 2;
            number0Button.Text = "0";
            number0Button.UseVisualStyleBackColor = true;
            number0Button.Click += numberButton_Click;
            // 
            // equalsButton
            // 
            equalsButton.BackColor = Color.Gray;
            equalsButton.Font = new Font("Impact", 25F);
            equalsButton.ForeColor = Color.Black;
            equalsButton.Location = new Point(249, 407);
            equalsButton.Name = "equalsButton";
            equalsButton.Size = new Size(73, 72);
            equalsButton.TabIndex = 3;
            equalsButton.Text = "=";
            equalsButton.UseVisualStyleBackColor = false;
            equalsButton.Click += equalsButton_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 128, 0);
            button4.Font = new Font("Impact", 25F);
            button4.Location = new Point(249, 250);
            button4.Name = "button4";
            button4.Size = new Size(73, 72);
            button4.TabIndex = 4;
            button4.Text = "x";
            button4.UseVisualStyleBackColor = false;
            button4.Click += operationButton_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(255, 128, 0);
            button5.Font = new Font("Impact", 25F);
            button5.Location = new Point(249, 173);
            button5.Name = "button5";
            button5.Size = new Size(73, 72);
            button5.TabIndex = 5;
            button5.Text = "-";
            button5.UseVisualStyleBackColor = false;
            button5.Click += operationButton_Click;
            // 
            // multip
            // 
            multip.BackColor = Color.FromArgb(255, 128, 0);
            multip.Font = new Font("Impact", 25F);
            multip.Location = new Point(249, 95);
            multip.Name = "multip";
            multip.Size = new Size(73, 72);
            multip.TabIndex = 6;
            multip.Text = "+";
            multip.UseVisualStyleBackColor = false;
            multip.Click += operationButton_Click;
            // 
            // backSpaceButton
            // 
            backSpaceButton.BackColor = Color.FromArgb(255, 128, 0);
            backSpaceButton.BackgroundImage = Properties.Resources.Arturo_Wibawa_Akar_Backspace;
            backSpaceButton.BackgroundImageLayout = ImageLayout.Stretch;
            backSpaceButton.Font = new Font("Segoe UI", 25F);
            backSpaceButton.Location = new Point(170, 94);
            backSpaceButton.Name = "backSpaceButton";
            backSpaceButton.Size = new Size(73, 72);
            backSpaceButton.TabIndex = 7;
            backSpaceButton.UseVisualStyleBackColor = false;
            backSpaceButton.Click += backSpaceButton_Click;
            // 
            // number5Button
            // 
            number5Button.Font = new Font("Impact", 25F);
            number5Button.Location = new Point(91, 250);
            number5Button.Name = "number5Button";
            number5Button.Size = new Size(73, 72);
            number5Button.TabIndex = 8;
            number5Button.Text = "5";
            number5Button.UseVisualStyleBackColor = true;
            number5Button.Click += numberButton_Click;
            // 
            // number4Button
            // 
            number4Button.Font = new Font("Impact", 25F);
            number4Button.Location = new Point(12, 250);
            number4Button.Name = "number4Button";
            number4Button.Size = new Size(73, 72);
            number4Button.TabIndex = 9;
            number4Button.Text = "4";
            number4Button.UseVisualStyleBackColor = true;
            number4Button.Click += numberButton_Click;
            // 
            // number6Button
            // 
            number6Button.Font = new Font("Impact", 25F);
            number6Button.Location = new Point(170, 250);
            number6Button.Name = "number6Button";
            number6Button.Size = new Size(73, 72);
            number6Button.TabIndex = 10;
            number6Button.Text = "6";
            number6Button.UseVisualStyleBackColor = true;
            number6Button.Click += numberButton_Click;
            // 
            // number7Button
            // 
            number7Button.Font = new Font("Impact", 25F);
            number7Button.Location = new Point(12, 172);
            number7Button.Name = "number7Button";
            number7Button.Size = new Size(73, 72);
            number7Button.TabIndex = 11;
            number7Button.Text = "7";
            number7Button.UseVisualStyleBackColor = true;
            number7Button.Click += numberButton_Click;
            // 
            // number8button
            // 
            number8button.Font = new Font("Impact", 25F);
            number8button.Location = new Point(91, 172);
            number8button.Name = "number8button";
            number8button.Size = new Size(73, 72);
            number8button.TabIndex = 12;
            number8button.Text = "8";
            number8button.UseVisualStyleBackColor = true;
            number8button.Click += numberButton_Click;
            // 
            // number9Button
            // 
            number9Button.Font = new Font("Impact", 25F);
            number9Button.Location = new Point(170, 172);
            number9Button.Name = "number9Button";
            number9Button.Size = new Size(73, 72);
            number9Button.TabIndex = 13;
            number9Button.Text = "9";
            number9Button.UseVisualStyleBackColor = true;
            number9Button.Click += numberButton_Click;
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.Silver;
            clearButton.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            clearButton.Location = new Point(9, 94);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(73, 72);
            clearButton.TabIndex = 14;
            clearButton.Text = "AC";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += clearButton_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 0);
            button1.Font = new Font("Impact", 25F);
            button1.Location = new Point(249, 329);
            button1.Name = "button1";
            button1.Size = new Size(73, 72);
            button1.TabIndex = 15;
            button1.Text = "/";
            button1.UseVisualStyleBackColor = false;
            button1.Click += operationButton_Click;
            // 
            // number1Button
            // 
            number1Button.Font = new Font("Impact", 25F);
            number1Button.Location = new Point(12, 328);
            number1Button.Name = "number1Button";
            number1Button.Size = new Size(73, 72);
            number1Button.TabIndex = 16;
            number1Button.Text = "1";
            number1Button.UseVisualStyleBackColor = true;
            number1Button.Click += numberButton_Click;
            // 
            // number2Button
            // 
            number2Button.Font = new Font("Impact", 25F);
            number2Button.Location = new Point(91, 328);
            number2Button.Name = "number2Button";
            number2Button.Size = new Size(73, 72);
            number2Button.TabIndex = 17;
            number2Button.Text = "2";
            number2Button.UseVisualStyleBackColor = true;
            number2Button.Click += numberButton_Click;
            // 
            // number3Button
            // 
            number3Button.Font = new Font("Impact", 25F);
            number3Button.Location = new Point(170, 328);
            number3Button.Name = "number3Button";
            number3Button.Size = new Size(73, 72);
            number3Button.TabIndex = 18;
            number3Button.Text = "3";
            number3Button.UseVisualStyleBackColor = true;
            number3Button.Click += numberButton_Click;
            // 
            // minus
            // 
            minus.BackColor = Color.Gray;
            minus.Font = new Font("Impact", 25F);
            minus.Location = new Point(170, 407);
            minus.Name = "minus";
            minus.Size = new Size(73, 72);
            minus.TabIndex = 19;
            minus.Text = "-";
            minus.UseVisualStyleBackColor = false;
            minus.Click += minus_Click;
            // 
            // info
            // 
            info.AutoSize = true;
            info.BackColor = Color.White;
            info.Font = new Font("Segoe UI", 11F);
            info.Location = new Point(9, 14);
            info.Name = "info";
            info.Size = new Size(0, 25);
            info.TabIndex = 20;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(331, 489);
            Controls.Add(info);
            Controls.Add(minus);
            Controls.Add(number3Button);
            Controls.Add(number2Button);
            Controls.Add(number1Button);
            Controls.Add(button1);
            Controls.Add(clearButton);
            Controls.Add(number9Button);
            Controls.Add(number8button);
            Controls.Add(number7Button);
            Controls.Add(number6Button);
            Controls.Add(number4Button);
            Controls.Add(number5Button);
            Controls.Add(backSpaceButton);
            Controls.Add(multip);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(equalsButton);
            Controls.Add(number0Button);
            Controls.Add(commaButton);
            Controls.Add(screenLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Calculator";
            Text = "Hesap Makinesi 1.1.0";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label screenLabel;
        private Button commaButton;
        private Button number0Button;
        private Button equalsButton;
        private Button button4;
        private Button button5;
        private Button multip;
        private Button backSpaceButton;
        private Button number5Button;
        private Button number4Button;
        private Button number6Button;
        private Button number7Button;
        private Button number8button;
        private Button number9Button;
        private Button clearButton;
        private Button button1;
        private Button number1Button;
        private Button number2Button;
        private Button number3Button;
        private Button minus;
        private Label info;
    }
}
