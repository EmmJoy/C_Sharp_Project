namespace login
{
    partial class Sundaraban_Paribahan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sundaraban_Paribahan));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            sc = new ComboBox();
            label6 = new Label();
            spw = new TextBox();
            sa = new TextBox();
            se = new TextBox();
            sp = new TextBox();
            sn = new TextBox();
            scon = new Button();
            scl = new Button();
            sbac = new Button();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            sdg = new DataGridView();
            upd = new Button();
            sdel = new Button();
            cost = new Button();
            cos = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sdg).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SandyBrown;
            label1.Font = new Font("Wide Latin", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(29, 161);
            label1.Name = "label1";
            label1.Size = new Size(114, 24);
            label1.TabIndex = 0;
            label1.Text = "Name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.SandyBrown;
            label2.Font = new Font("Wide Latin", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Maroon;
            label2.Location = new Point(29, 206);
            label2.Name = "label2";
            label2.Size = new Size(279, 24);
            label2.TabIndex = 1;
            label2.Text = "Phone Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.SandyBrown;
            label3.Font = new Font("Wide Latin", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Maroon;
            label3.Location = new Point(29, 242);
            label3.Name = "label3";
            label3.Size = new Size(121, 24);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.SandyBrown;
            label4.Font = new Font("Wide Latin", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Maroon;
            label4.Location = new Point(29, 277);
            label4.Name = "label4";
            label4.Size = new Size(210, 24);
            label4.TabIndex = 3;
            label4.Text = "ADDRESS";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.SandyBrown;
            label5.Font = new Font("Wide Latin", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Maroon;
            label5.Location = new Point(29, 317);
            label5.Name = "label5";
            label5.Size = new Size(294, 24);
            label5.TabIndex = 4;
            label5.Text = "Type Of product";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // sc
            // 
            sc.BackColor = SystemColors.Info;
            sc.Cursor = Cursors.Hand;
            sc.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            sc.ForeColor = Color.Red;
            sc.FormattingEnabled = true;
            sc.Items.AddRange(new object[] { "Glass", "Fruits", "Electronics", "Others" });
            sc.Location = new Point(384, 310);
            sc.Name = "sc";
            sc.Size = new Size(412, 31);
            sc.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.SandyBrown;
            label6.Font = new Font("Wide Latin", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Maroon;
            label6.Location = new Point(29, 354);
            label6.Name = "label6";
            label6.Size = new Size(284, 24);
            label6.TabIndex = 6;
            label6.Text = "Product weight";
            // 
            // spw
            // 
            spw.BackColor = SystemColors.Info;
            spw.Cursor = Cursors.IBeam;
            spw.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            spw.ForeColor = Color.Red;
            spw.Location = new Point(384, 348);
            spw.Name = "spw";
            spw.Size = new Size(412, 30);
            spw.TabIndex = 7;
            // 
            // sa
            // 
            sa.BackColor = SystemColors.Info;
            sa.Cursor = Cursors.IBeam;
            sa.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sa.ForeColor = Color.Red;
            sa.Location = new Point(384, 271);
            sa.Name = "sa";
            sa.Size = new Size(412, 30);
            sa.TabIndex = 8;
            // 
            // se
            // 
            se.BackColor = SystemColors.Info;
            se.Cursor = Cursors.IBeam;
            se.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            se.ForeColor = Color.Red;
            se.Location = new Point(384, 236);
            se.Name = "se";
            se.Size = new Size(412, 30);
            se.TabIndex = 9;
            // 
            // sp
            // 
            sp.BackColor = SystemColors.Info;
            sp.Cursor = Cursors.IBeam;
            sp.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sp.ForeColor = Color.Red;
            sp.Location = new Point(384, 200);
            sp.Name = "sp";
            sp.Size = new Size(412, 30);
            sp.TabIndex = 10;
            // 
            // sn
            // 
            sn.BackColor = SystemColors.Info;
            sn.Cursor = Cursors.IBeam;
            sn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sn.ForeColor = Color.Red;
            sn.Location = new Point(384, 159);
            sn.Name = "sn";
            sn.Size = new Size(412, 30);
            sn.TabIndex = 11;
            sn.TextChanged += textBox5_TextChanged;
            // 
            // scon
            // 
            scon.BackColor = Color.DarkSalmon;
            scon.Cursor = Cursors.Hand;
            scon.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            scon.Location = new Point(802, 161);
            scon.Name = "scon";
            scon.Size = new Size(161, 49);
            scon.TabIndex = 12;
            scon.Text = "Confirm";
            scon.UseVisualStyleBackColor = false;
            scon.Click += button1_Click;
            // 
            // scl
            // 
            scl.BackColor = Color.DarkSalmon;
            scl.Cursor = Cursors.Hand;
            scl.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            scl.Location = new Point(802, 236);
            scl.Name = "scl";
            scl.Size = new Size(161, 49);
            scl.TabIndex = 13;
            scl.Text = "Reset";
            scl.UseVisualStyleBackColor = false;
            scl.Click += scl_Click;
            // 
            // sbac
            // 
            sbac.BackColor = Color.DarkSalmon;
            sbac.Cursor = Cursors.Hand;
            sbac.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sbac.Location = new Point(802, 310);
            sbac.Name = "sbac";
            sbac.Size = new Size(161, 49);
            sbac.TabIndex = 14;
            sbac.Text = "Back";
            sbac.UseVisualStyleBackColor = false;
            sbac.Click += button3_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.SandyBrown;
            label7.Cursor = Cursors.WaitCursor;
            label7.Font = new Font("Wide Latin", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Green;
            label7.Location = new Point(230, 93);
            label7.Name = "label7";
            label7.Size = new Size(689, 34);
            label7.TabIndex = 15;
            label7.Text = "Sundarban Courier Service";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Cursor = Cursors.No;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(225, 128);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // sdg
            // 
            sdg.BackgroundColor = Color.OldLace;
            sdg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            sdg.Cursor = Cursors.Cross;
            sdg.Location = new Point(3, 504);
            sdg.Name = "sdg";
            sdg.RowHeadersWidth = 51;
            sdg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            sdg.Size = new Size(949, 188);
            sdg.TabIndex = 17;
            sdg.CellClick += sdg_CellClick;
            sdg.CellContentClick += sdg_CellContentClick;
            // 
            // upd
            // 
            upd.BackColor = Color.DarkSalmon;
            upd.Cursor = Cursors.Hand;
            upd.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            upd.Location = new Point(12, 449);
            upd.Name = "upd";
            upd.Size = new Size(138, 49);
            upd.TabIndex = 18;
            upd.Text = "Update";
            upd.UseVisualStyleBackColor = false;
            upd.Click += button4_Click;
            // 
            // sdel
            // 
            sdel.BackColor = Color.DarkSalmon;
            sdel.Cursor = Cursors.Hand;
            sdel.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sdel.Location = new Point(156, 449);
            sdel.Name = "sdel";
            sdel.Size = new Size(111, 49);
            sdel.TabIndex = 35;
            sdel.Text = "Delete";
            sdel.UseVisualStyleBackColor = false;
            sdel.Click += sdel_Click;
            // 
            // cost
            // 
            cost.BackColor = Color.DarkSalmon;
            cost.Cursor = Cursors.Hand;
            cost.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cost.Location = new Point(273, 449);
            cost.Name = "cost";
            cost.Size = new Size(296, 49);
            cost.TabIndex = 36;
            cost.Text = "Cost";
            cost.UseVisualStyleBackColor = false;
            cost.Click += cost_Click;
            // 
            // cos
            // 
            cos.BackColor = SystemColors.Info;
            cos.Cursor = Cursors.No;
            cos.Font = new Font("Engravers MT", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cos.ForeColor = Color.Red;
            cos.Location = new Point(575, 460);
            cos.Name = "cos";
            cos.Size = new Size(365, 34);
            cos.TabIndex = 37;
            // 
            // Sundaraban_Paribahan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SandyBrown;
            ClientSize = new Size(964, 704);
            Controls.Add(cos);
            Controls.Add(cost);
            Controls.Add(sdel);
            Controls.Add(upd);
            Controls.Add(sdg);
            Controls.Add(pictureBox1);
            Controls.Add(label7);
            Controls.Add(sbac);
            Controls.Add(scl);
            Controls.Add(scon);
            Controls.Add(sn);
            Controls.Add(sp);
            Controls.Add(se);
            Controls.Add(sa);
            Controls.Add(spw);
            Controls.Add(label6);
            Controls.Add(sc);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Sundaraban_Paribahan";
            Text = "Sundaraban_Paribahan";
            Load += Sundaraban_Paribahan_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)sdg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private ComboBox sc;
        private Label label6;
        private TextBox spw;
        private TextBox sa;
        private TextBox se;
        private TextBox sp;
        private TextBox sn;
        private Button scon;
        private Button scl;
        private Button sbac;
        private Label label7;
        private PictureBox pictureBox1;
        private DataGridView sdg;
        private Button upd;
        private Button sdel;
        private Button cost;
        private TextBox cos;
    }
}