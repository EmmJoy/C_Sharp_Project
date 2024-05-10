namespace login
{
    partial class adminkorotoa
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
            dda = new DataGridView();
            bk = new Button();
            ((System.ComponentModel.ISupportInitialize)dda).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(170, 9);
            label1.Name = "label1";
            label1.Size = new Size(574, 39);
            label1.TabIndex = 2;
            label1.Text = "Korotoa Courier Service Parcel Information";
            // 
            // dda
            // 
            dda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dda.Location = new Point(12, 76);
            dda.Name = "dda";
            dda.RowHeadersWidth = 51;
            dda.Size = new Size(879, 400);
            dda.TabIndex = 3;
            // 
            // bk
            // 
            bk.BackColor = Color.Orchid;
            bk.Cursor = Cursors.Hand;
            bk.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bk.Location = new Point(749, 482);
            bk.Name = "bk";
            bk.Size = new Size(142, 49);
            bk.TabIndex = 33;
            bk.Text = "Back";
            bk.UseVisualStyleBackColor = false;
            bk.Click += bk_Click;
            // 
            // adminkorotoa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumPurple;
            ClientSize = new Size(903, 536);
            Controls.Add(bk);
            Controls.Add(dda);
            Controls.Add(label1);
            Name = "adminkorotoa";
            Text = "adminkorotoa";
            Load += adminkorotoa_Load;
            ((System.ComponentModel.ISupportInitialize)dda).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dda;
        private Button bk;
    }
}