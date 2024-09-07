namespace Library
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
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            username = new TextBox();
            label2 = new Label();
            label3 = new Label();
            password = new TextBox();
            panel3 = new Panel();
            panel4 = new Panel();
            btnlogin = new Button();
            label4 = new Label();
            linkLabel1 = new LinkLabel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources._3d_cartoon_scene_depicting_variety_people_multitasking;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(-7, -39);
            panel1.Name = "panel1";
            panel1.Size = new Size(411, 623);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.books_with_graduation_cap_digital_art_style_education_day;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(458, 36);
            panel2.Name = "panel2";
            panel2.Size = new Size(65, 72);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Script MT Bold", 30F, FontStyle.Bold);
            label1.Location = new Point(526, 40);
            label1.Name = "label1";
            label1.Size = new Size(223, 48);
            label1.TabIndex = 2;
            label1.Text = "Book Haven";
            // 
            // username
            // 
            username.BackColor = SystemColors.Control;
            username.BorderStyle = BorderStyle.None;
            username.Cursor = Cursors.IBeam;
            username.Font = new Font("Segoe UI", 12F);
            username.ForeColor = SystemColors.ControlDark;
            username.Location = new Point(461, 183);
            username.Name = "username";
            username.Size = new Size(275, 22);
            username.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(457, 159);
            label2.Name = "label2";
            label2.Size = new Size(92, 21);
            label2.TabIndex = 4;
            label2.Text = "User Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(457, 231);
            label3.Name = "label3";
            label3.Size = new Size(80, 21);
            label3.TabIndex = 6;
            label3.Text = "Password";
            // 
            // password
            // 
            password.BackColor = SystemColors.Control;
            password.BorderStyle = BorderStyle.None;
            password.Cursor = Cursors.IBeam;
            password.Font = new Font("Segoe UI", 12F);
            password.ForeColor = SystemColors.ControlDark;
            password.Location = new Point(461, 255);
            password.Name = "password";
            password.Size = new Size(275, 22);
            password.TabIndex = 5;
            password.UseSystemPasswordChar = true;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaptionText;
            panel3.Location = new Point(462, 209);
            panel3.Name = "panel3";
            panel3.Size = new Size(275, 1);
            panel3.TabIndex = 7;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaptionText;
            panel4.Location = new Point(461, 281);
            panel4.Name = "panel4";
            panel4.Size = new Size(275, 1);
            panel4.TabIndex = 8;
            // 
            // btnlogin
            // 
            btnlogin.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnlogin.Location = new Point(513, 306);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(181, 40);
            btnlogin.TabIndex = 9;
            btnlogin.Text = "Log In";
            btnlogin.UseVisualStyleBackColor = true;
            btnlogin.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(475, 389);
            label4.Name = "label4";
            label4.Size = new Size(163, 15);
            label4.TabIndex = 10;
            label4.Text = "If you don't have an account?";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(635, 389);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(91, 15);
            linkLabel1.TabIndex = 11;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Sign Up for Free";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Animation___1725460452380;
            pictureBox1.Location = new Point(564, 54);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(144, 71);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Properties.Resources.cross_14875490;
            pictureBox2.Location = new Point(750, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(38, 41);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox2);
            Controls.Add(linkLabel1);
            Controls.Add(label4);
            Controls.Add(btnlogin);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(label3);
            Controls.Add(password);
            Controls.Add(label2);
            Controls.Add(username);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Book Haven Library";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private TextBox username;
        private Label label2;
        private Label label3;
        private TextBox password;
        private Panel panel3;
        private Panel panel4;
        private Button btnlogin;
        private Label label4;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
