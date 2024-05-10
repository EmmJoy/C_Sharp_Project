namespace login
{
    partial class admin_p_info
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
            cmb1 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.OrangeRed;
            label1.Location = new Point(-1, 7);
            label1.Name = "label1";
            label1.Size = new Size(544, 26);
            label1.TabIndex = 2;
            label1.Text = "Which Courier Service Information Do You Wana See?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.OrangeRed;
            label2.Location = new Point(-1, 78);
            label2.Name = "label2";
            label2.Size = new Size(267, 36);
            label2.TabIndex = 3;
            label2.Text = "Select One Service";
            // 
            // cmb1
            // 
            cmb1.BackColor = SystemColors.InactiveCaption;
            cmb1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmb1.FormattingEnabled = true;
            cmb1.Items.AddRange(new object[] { "Sundarban Courier Service", "SA Paribahan", "Korotoa COurier Service" });
            cmb1.Location = new Point(10, 112);
            cmb1.Margin = new Padding(3, 2, 3, 2);
            cmb1.Name = "cmb1";
            cmb1.Size = new Size(546, 28);
            cmb1.TabIndex = 4;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.SaddleBrown;
            button1.Location = new Point(10, 158);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(108, 37);
            button1.TabIndex = 8;
            button1.Text = "Confirm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.SaddleBrown;
            button2.Location = new Point(579, 158);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(108, 37);
            button2.TabIndex = 9;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // admin_p_info
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSpringGreen;
            ClientSize = new Size(700, 338);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(cmb1);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "admin_p_info";
            Text = "admin_p_info";
            Load += admin_p_info_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cmb1;
        private Button button1;
        private Button button2;
    }
}