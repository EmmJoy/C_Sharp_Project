namespace login
{
    partial class Showfeedback
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
            userbut = new Button();
            sdd = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)sdd).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(443, 9);
            label1.Name = "label1";
            label1.Size = new Size(178, 31);
            label1.TabIndex = 1;
            label1.Text = "Users Feedback";
            // 
            // userbut
            // 
            userbut.BackColor = Color.DarkTurquoise;
            userbut.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userbut.ForeColor = Color.Maroon;
            userbut.Location = new Point(925, 444);
            userbut.Name = "userbut";
            userbut.Size = new Size(86, 36);
            userbut.TabIndex = 17;
            userbut.Text = "Exit";
            userbut.UseVisualStyleBackColor = false;
            userbut.Click += userbut_Click;
            // 
            // sdd
            // 
            sdd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            sdd.Location = new Point(6, 58);
            sdd.Name = "sdd";
            sdd.RowHeadersWidth = 51;
            sdd.Size = new Size(1005, 368);
            sdd.TabIndex = 18;
            sdd.CellContentClick += sdd_CellContentClick;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkTurquoise;
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Maroon;
            button1.Location = new Point(6, 444);
            button1.Name = "button1";
            button1.Size = new Size(242, 36);
            button1.TabIndex = 19;
            button1.Text = "Tap For Auto Recize";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkTurquoise;
            button2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Maroon;
            button2.Location = new Point(725, 444);
            button2.Name = "button2";
            button2.Size = new Size(185, 36);
            button2.TabIndex = 20;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Showfeedback
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGreen;
            ClientSize = new Size(1039, 492);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(sdd);
            Controls.Add(userbut);
            Controls.Add(label1);
            Name = "Showfeedback";
            Text = "Showfeedback";
            Load += Showfeedback_Load;
            ((System.ComponentModel.ISupportInitialize)sdd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button userbut;
        private DataGridView sdd;
        private Button button1;
        private Button button2;
    }
}