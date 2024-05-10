namespace login
{
    partial class FeedbackUsers
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button3 = new Button();
            button4 = new Button();
            comboBox1 = new ComboBox();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton6 = new RadioButton();
            comboBox2 = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(292, 9);
            label1.Name = "label1";
            label1.Size = new Size(176, 31);
            label1.TabIndex = 0;
            label1.Text = "Feedback Form";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Maroon;
            label2.Location = new Point(12, 105);
            label2.Name = "label2";
            label2.Size = new Size(151, 28);
            label2.TabIndex = 1;
            label2.Text = "Feedback Type";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Info;
            textBox1.Font = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(12, 270);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(759, 191);
            textBox1.TabIndex = 2;
            textBox1.Text = "Enter Your Feedback..";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Maroon;
            label3.Location = new Point(12, 136);
            label3.Name = "label3";
            label3.Size = new Size(459, 28);
            label3.TabIndex = 5;
            label3.Text = "How satisfied you are with our courier service?";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Maroon;
            label4.Location = new Point(12, 222);
            label4.Name = "label4";
            label4.Size = new Size(330, 28);
            label4.TabIndex = 10;
            label4.Text = "How can we improve?any advice?";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Maroon;
            label5.Location = new Point(12, 40);
            label5.Name = "label5";
            label5.Size = new Size(219, 28);
            label5.TabIndex = 11;
            label5.Text = "Select Courier Service";
            // 
            // button3
            // 
            button3.Location = new Point(238, 467);
            button3.Name = "button3";
            button3.Size = new Size(196, 29);
            button3.TabIndex = 14;
            button3.Text = "Show All Feedback";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(463, 467);
            button4.Name = "button4";
            button4.Size = new Size(134, 29);
            button4.TabIndex = 15;
            button4.Text = "Submit";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.GradientInactiveCaption;
            comboBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox1.ForeColor = SystemColors.MenuHighlight;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Sundarban Courier Service", "Korotoa Courier Service", "SA Paribahan" });
            comboBox1.Location = new Point(272, 42);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(374, 33);
            comboBox1.TabIndex = 17;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(158, 184);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(117, 24);
            radioButton3.TabIndex = 21;
            radioButton3.TabStop = true;
            radioButton3.Text = "Very satisfied";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.Click += level;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(12, 184);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(87, 24);
            radioButton4.TabIndex = 20;
            radioButton4.TabStop = true;
            radioButton4.Text = "Satisfied";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.Click += level;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(503, 184);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(133, 24);
            radioButton5.TabIndex = 23;
            radioButton5.TabStop = true;
            radioButton5.Text = "Very unsatisfied";
            radioButton5.UseVisualStyleBackColor = true;
            radioButton5.Click += level;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(357, 184);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(103, 24);
            radioButton6.TabIndex = 22;
            radioButton6.TabStop = true;
            radioButton6.Text = "Unsatisfied";
            radioButton6.UseVisualStyleBackColor = true;
            radioButton6.Click += level;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = SystemColors.GradientInactiveCaption;
            comboBox2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox2.ForeColor = SystemColors.MenuHighlight;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Comment", "Report" });
            comboBox2.Location = new Point(272, 94);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(374, 33);
            comboBox2.TabIndex = 24;
            // 
            // button1
            // 
            button1.Location = new Point(637, 467);
            button1.Name = "button1";
            button1.Size = new Size(134, 29);
            button1.TabIndex = 25;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FeedbackUsers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(800, 544);
            Controls.Add(button1);
            Controls.Add(comboBox2);
            Controls.Add(radioButton5);
            Controls.Add(radioButton6);
            Controls.Add(radioButton3);
            Controls.Add(radioButton4);
            Controls.Add(comboBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.Maroon;
            Name = "FeedbackUsers";
            Text = "FeedbackUsers";
            Load += FeedbackUsers_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button3;
        private Button button4;
        private ComboBox comboBox1;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
        private RadioButton radioButton6;
        private ComboBox comboBox2;
        private Button button1;
    }
}