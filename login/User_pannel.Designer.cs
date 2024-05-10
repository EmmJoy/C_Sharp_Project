namespace login
{
    partial class User_pannel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_pannel));
            label1 = new Label();
            label2 = new Label();
            cmb1 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(10, 71);
            label1.Name = "label1";
            label1.Size = new Size(246, 25);
            label1.TabIndex = 0;
            label1.Text = "Select Shipping Company";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Maroon;
            label2.Location = new Point(67, 7);
            label2.Name = "label2";
            label2.Size = new Size(560, 44);
            label2.TabIndex = 1;
            label2.Text = "welcome to our shipping company";
            // 
            // cmb1
            // 
            cmb1.BackColor = Color.PeachPuff;
            cmb1.Cursor = Cursors.SizeNS;
            cmb1.ForeColor = Color.Red;
            cmb1.FormattingEnabled = true;
            cmb1.Items.AddRange(new object[] { "Sundarban Courier Service", "SA Paribahan", "Korotoa Courier Service" });
            cmb1.Location = new Point(323, 76);
            cmb1.Margin = new Padding(3, 2, 3, 2);
            cmb1.Name = "cmb1";
            cmb1.Size = new Size(385, 23);
            cmb1.TabIndex = 2;
            cmb1.SelectedIndexChanged += cmb1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.SaddleBrown;
            button1.Location = new Point(31, 125);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(145, 44);
            button1.TabIndex = 7;
            button1.Text = "Confirm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.SaddleBrown;
            button2.Location = new Point(561, 125);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(147, 44);
            button2.TabIndex = 8;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Red;
            button3.Location = new Point(288, 324);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(158, 38);
            button3.TabIndex = 9;
            button3.Text = "Feedback";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.PeachPuff;
            textBox1.Cursor = Cursors.WaitCursor;
            textBox1.Font = new Font("Segoe Script", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.Maroon;
            textBox1.Location = new Point(6, 229);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(817, 80);
            textBox1.TabIndex = 10;
            textBox1.Text = resources.GetString("textBox1.Text");
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // User_pannel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SandyBrown;
            ClientSize = new Size(835, 407);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(cmb1);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "User_pannel";
            Text = "User_pannel";
            Load += User_pannel_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cmb1;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
    }
}