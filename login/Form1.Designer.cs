namespace login
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            em = new TextBox();
            pass = new TextBox();
            login = new Button();
            forg = new Button();
            clr = new Button();
            button1 = new Button();
            picbx = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            wel = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)picbx).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.InactiveCaptionText;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(37, 286);
            label1.Name = "label1";
            label1.Size = new Size(85, 32);
            label1.TabIndex = 0;
            label1.Text = "Email";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.InactiveCaptionText;
            label2.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Maroon;
            label2.Location = new Point(37, 334);
            label2.Name = "label2";
            label2.Size = new Size(129, 32);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // em
            // 
            em.BackColor = Color.Bisque;
            em.Cursor = Cursors.IBeam;
            em.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            em.ForeColor = SystemColors.ActiveCaptionText;
            em.Location = new Point(190, 291);
            em.Name = "em";
            em.Size = new Size(264, 30);
            em.TabIndex = 2;
            // 
            // pass
            // 
            pass.BackColor = Color.Bisque;
            pass.Cursor = Cursors.IBeam;
            pass.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pass.ForeColor = SystemColors.ActiveCaptionText;
            pass.Location = new Point(190, 334);
            pass.Name = "pass";
            pass.Size = new Size(264, 30);
            pass.TabIndex = 3;
            // 
            // login
            // 
            login.BackColor = Color.DarkSalmon;
            login.Cursor = Cursors.Hand;
            login.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login.ForeColor = Color.Maroon;
            login.Location = new Point(229, 371);
            login.Name = "login";
            login.Size = new Size(184, 48);
            login.TabIndex = 4;
            login.Text = "Log in";
            login.UseVisualStyleBackColor = false;
            login.Click += login_Click;
            // 
            // forg
            // 
            forg.BackColor = Color.Coral;
            forg.Cursor = Cursors.Hand;
            forg.Font = new Font("Segoe Print", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            forg.ForeColor = Color.Maroon;
            forg.Location = new Point(550, 402);
            forg.Name = "forg";
            forg.Size = new Size(135, 48);
            forg.TabIndex = 5;
            forg.Text = "About US";
            forg.UseVisualStyleBackColor = false;
            forg.Click += forg_Click;
            // 
            // clr
            // 
            clr.BackColor = Color.Coral;
            clr.Cursor = Cursors.Hand;
            clr.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clr.ForeColor = Color.Maroon;
            clr.Location = new Point(469, 306);
            clr.Name = "clr";
            clr.Size = new Size(150, 43);
            clr.TabIndex = 7;
            clr.Text = "Clear All";
            clr.UseVisualStyleBackColor = false;
            clr.Click += button1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSalmon;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe Print", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Maroon;
            button1.Location = new Point(12, 402);
            button1.Name = "button1";
            button1.Size = new Size(198, 48);
            button1.TabIndex = 8;
            button1.Text = "REGISTRATION";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // picbx
            // 
            picbx.Cursor = Cursors.No;
            picbx.Image = (Image)resources.GetObject("picbx.Image");
            picbx.Location = new Point(152, 12);
            picbx.Name = "picbx";
            picbx.Size = new Size(549, 208);
            picbx.SizeMode = PictureBoxSizeMode.StretchImage;
            picbx.TabIndex = 9;
            picbx.TabStop = false;
            picbx.Click += picbx_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // wel
            // 
            wel.AutoSize = true;
            wel.BackColor = SystemColors.InactiveCaptionText;
            wel.Cursor = Cursors.WaitCursor;
            wel.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            wel.ForeColor = Color.Tomato;
            wel.Location = new Point(109, 235);
            wel.Name = "wel";
            wel.Size = new Size(625, 32);
            wel.TabIndex = 10;
            wel.Text = "Welcome To Our Shipping And Parcel Log in Form";
            // 
            // button2
            // 
            button2.BackColor = Color.DarkSalmon;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Maroon;
            button2.Location = new Point(691, 402);
            button2.Name = "button2";
            button2.Size = new Size(107, 48);
            button2.TabIndex = 11;
            button2.Text = "EXIT";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(wel);
            Controls.Add(picbx);
            Controls.Add(button1);
            Controls.Add(clr);
            Controls.Add(forg);
            Controls.Add(login);
            Controls.Add(pass);
            Controls.Add(em);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ActiveCaption;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)picbx).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox em;
        private TextBox pass;
        private Button login;
        private Button forg;
        private Button clr;
        private Button button1;
        private PictureBox picbx;
        private System.Windows.Forms.Timer timer1;
        private Label wel;
        private Button button2;
    }
}
