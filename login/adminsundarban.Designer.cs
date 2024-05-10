namespace login
{
    partial class adminsundarban
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
            ds = new DataGridView();
            bk = new Button();
            ((System.ComponentModel.ISupportInitialize)ds).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightSkyBlue;
            label1.Location = new Point(180, 9);
            label1.Name = "label1";
            label1.Size = new Size(573, 33);
            label1.TabIndex = 0;
            label1.Text = "Sundarban Courier Service Registration Information";
            // 
            // ds
            // 
            ds.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ds.Location = new Point(12, 53);
            ds.Name = "ds";
            ds.RowHeadersWidth = 51;
            ds.Size = new Size(878, 389);
            ds.TabIndex = 1;
            // 
            // bk
            // 
            bk.BackColor = Color.DarkSalmon;
            bk.Cursor = Cursors.Hand;
            bk.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bk.Location = new Point(748, 448);
            bk.Name = "bk";
            bk.Size = new Size(142, 49);
            bk.TabIndex = 31;
            bk.Text = "Back";
            bk.UseVisualStyleBackColor = false;
            bk.Click += bk_Click;
            // 
            // adminsundarban
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(902, 501);
            Controls.Add(bk);
            Controls.Add(ds);
            Controls.Add(label1);
            Name = "adminsundarban";
            Text = "adminsundarban";
            Load += adminsundarban_Load;
            ((System.ComponentModel.ISupportInitialize)ds).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView ds;
        private Button bk;
    }
}