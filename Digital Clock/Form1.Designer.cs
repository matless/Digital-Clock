namespace Digital_Clock
{
    partial class DigitalClock
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
            components = new System.ComponentModel.Container();
            clockLabel = new Label();
            clockTimer = new System.Windows.Forms.Timer(components);
            redButton = new Button();
            blueButton = new Button();
            greenButton = new Button();
            pinkButton = new Button();
            yellowButton = new Button();
            styleButton1 = new Button();
            stylebutton2 = new Button();
            stylebutton3 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // clockLabel
            // 
            clockLabel.Font = new Font("Ink Free", 72F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            clockLabel.ForeColor = SystemColors.WindowFrame;
            clockLabel.ImageAlign = ContentAlignment.TopCenter;
            clockLabel.Location = new Point(12, -3);
            clockLabel.Name = "clockLabel";
            clockLabel.Size = new Size(953, 485);
            clockLabel.TabIndex = 0;
            clockLabel.Text = "Loading...";
            clockLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // clockTimer
            // 
            clockTimer.Interval = 1000;
            clockTimer.Tick += clockTimer_Tick;
            // 
            // redButton
            // 
            redButton.BackColor = Color.Red;
            redButton.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            redButton.ForeColor = SystemColors.ControlText;
            redButton.Location = new Point(12, 471);
            redButton.Name = "redButton";
            redButton.Size = new Size(28, 22);
            redButton.TabIndex = 1;
            redButton.UseVisualStyleBackColor = false;
            redButton.Click += redButton_Click;
            // 
            // blueButton
            // 
            blueButton.BackColor = Color.Blue;
            blueButton.ForeColor = SystemColors.ControlText;
            blueButton.Location = new Point(46, 471);
            blueButton.Name = "blueButton";
            blueButton.Size = new Size(28, 22);
            blueButton.TabIndex = 2;
            blueButton.UseVisualStyleBackColor = false;
            blueButton.Click += blueButton_Click;
            // 
            // greenButton
            // 
            greenButton.BackColor = Color.Lime;
            greenButton.ForeColor = SystemColors.ControlText;
            greenButton.Location = new Point(80, 471);
            greenButton.Name = "greenButton";
            greenButton.Size = new Size(28, 22);
            greenButton.TabIndex = 3;
            greenButton.UseVisualStyleBackColor = false;
            greenButton.Click += greenButton_Click;
            // 
            // pinkButton
            // 
            pinkButton.BackColor = Color.DeepPink;
            pinkButton.ForeColor = SystemColors.ControlText;
            pinkButton.Location = new Point(148, 471);
            pinkButton.Name = "pinkButton";
            pinkButton.Size = new Size(28, 22);
            pinkButton.TabIndex = 4;
            pinkButton.UseVisualStyleBackColor = false;
            pinkButton.Click += pinkButton_Click;
            // 
            // yellowButton
            // 
            yellowButton.BackColor = Color.Yellow;
            yellowButton.ForeColor = SystemColors.ControlText;
            yellowButton.Location = new Point(114, 471);
            yellowButton.Name = "yellowButton";
            yellowButton.Size = new Size(28, 22);
            yellowButton.TabIndex = 5;
            yellowButton.UseVisualStyleBackColor = false;
            yellowButton.Click += yellowButton_Click;
            // 
            // styleButton1
            // 
            styleButton1.BackColor = SystemColors.ButtonFace;
            styleButton1.Font = new Font("SimSun", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            styleButton1.ForeColor = SystemColors.ControlText;
            styleButton1.Location = new Point(182, 471);
            styleButton1.Name = "styleButton1";
            styleButton1.Size = new Size(75, 23);
            styleButton1.TabIndex = 6;
            styleButton1.Text = "Style1";
            styleButton1.UseVisualStyleBackColor = false;
            styleButton1.Click += styleButton1_Click;
            // 
            // stylebutton2
            // 
            stylebutton2.BackColor = SystemColors.ButtonFace;
            stylebutton2.Font = new Font("Ink Free", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            stylebutton2.ForeColor = SystemColors.ControlText;
            stylebutton2.Location = new Point(263, 470);
            stylebutton2.Name = "stylebutton2";
            stylebutton2.Size = new Size(75, 23);
            stylebutton2.TabIndex = 7;
            stylebutton2.Text = "style2";
            stylebutton2.UseVisualStyleBackColor = false;
            stylebutton2.Click += stylebutton2_Click;
            // 
            // stylebutton3
            // 
            stylebutton3.BackColor = SystemColors.ButtonFace;
            stylebutton3.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            stylebutton3.ForeColor = SystemColors.ControlText;
            stylebutton3.Location = new Point(344, 470);
            stylebutton3.Name = "stylebutton3";
            stylebutton3.Size = new Size(75, 23);
            stylebutton3.TabIndex = 8;
            stylebutton3.Text = "style3";
            stylebutton3.UseVisualStyleBackColor = false;
            stylebutton3.Click += stylebutton3_Click;
            // 
            // DigitalClock
            // 
            AutoScaleDimensions = new SizeF(53F, 128F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(969, 516);
            Controls.Add(stylebutton3);
            Controls.Add(stylebutton2);
            Controls.Add(styleButton1);
            Controls.Add(yellowButton);
            Controls.Add(pinkButton);
            Controls.Add(greenButton);
            Controls.Add(blueButton);
            Controls.Add(redButton);
            Controls.Add(clockLabel);
            Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Red;
            Margin = new Padding(23, 26, 23, 26);
            Name = "DigitalClock";
            Text = "Digital Clock";
            Load += DigitalClock_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label clockLabel;
        private System.Windows.Forms.Timer clockTimer;
        private Button redButton;
        private Button blueButton;
        private Button greenButton;
        private Button pinkButton;
        private Button yellowButton;
        private Button styleButton1;
        private Button stylebutton2;
        private Button stylebutton3;
        private System.Windows.Forms.Timer timer1;
    }
}