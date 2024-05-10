namespace login
{
    partial class adminSA
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
            dds = new DataGridView();
            bk = new Button();
            ((System.ComponentModel.ISupportInitialize)dds).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(269, 9);
            label1.Name = "label1";
            label1.Size = new Size(436, 39);
            label1.TabIndex = 1;
            label1.Text = "SA Paribahan Parcel Information";
            // 
            // dds
            // 
            dds.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dds.Location = new Point(2, 60);
            dds.Name = "dds";
            dds.RowHeadersWidth = 51;
            dds.Size = new Size(904, 426);
            dds.TabIndex = 2;
            // 
            // bk
            // 
            bk.BackColor = Color.DarkSalmon;
            bk.Cursor = Cursors.Hand;
            bk.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bk.Location = new Point(744, 499);
            bk.Name = "bk";
            bk.Size = new Size(142, 49);
            bk.TabIndex = 32;
            bk.Text = "Back";
            bk.UseVisualStyleBackColor = false;
            bk.Click += bk_Click;
            // 
            // adminSA
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            ClientSize = new Size(918, 560);
            Controls.Add(bk);
            Controls.Add(dds);
            Controls.Add(label1);
            Name = "adminSA";
            Text = "adminSA";
            Load += adminSA_Load;
            ((System.ComponentModel.ISupportInitialize)dds).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dds;
        private Button bk;
    }
}