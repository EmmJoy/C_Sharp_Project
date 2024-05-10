namespace login
{
    partial class Registration_info
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
            dataGridView1 = new DataGridView();
            con = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(289, 9);
            label1.Name = "label1";
            label1.Size = new Size(494, 33);
            label1.TabIndex = 0;
            label1.Text = "Users Rgistration Information ";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 74);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1057, 330);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // con
            // 
            con.BackColor = Color.Thistle;
            con.Cursor = Cursors.Hand;
            con.Font = new Font("Stencil", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            con.ForeColor = Color.Maroon;
            con.Location = new Point(844, 432);
            con.Name = "con";
            con.Size = new Size(225, 49);
            con.TabIndex = 25;
            con.Text = "Back";
            con.UseVisualStyleBackColor = false;
            con.Click += con_Click;
            // 
            // Registration_info
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(1081, 493);
            Controls.Add(con);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            ForeColor = Color.DeepSkyBlue;
            Name = "Registration_info";
            Text = "Registration_info";
            Load += Registration_info_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Button con;
    }
}