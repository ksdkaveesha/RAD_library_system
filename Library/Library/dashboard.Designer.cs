namespace Library
{
    partial class dashboard
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
            panel1 = new Panel();
            welcomelbl = new Label();
            panel6 = new Panel();
            btnlogout = new Label();
            pictureBox6 = new PictureBox();
            panel4 = new Panel();
            btnreturnbook = new Label();
            pictureBox5 = new PictureBox();
            panel3 = new Panel();
            btnissuebook = new Label();
            pictureBox3 = new PictureBox();
            panel5 = new Panel();
            btnviewbook = new Label();
            pictureBox4 = new PictureBox();
            panel2 = new Panel();
            btnaddbook = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSalmon;
            panel1.Controls.Add(welcomelbl);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1263, 57);
            panel1.TabIndex = 0;
            // 
            // welcomelbl
            // 
            welcomelbl.AutoSize = true;
            welcomelbl.BackColor = Color.Transparent;
            welcomelbl.Font = new Font("Brush Script Std", 30F, FontStyle.Bold);
            welcomelbl.ForeColor = Color.FromArgb(255, 255, 192);
            welcomelbl.Location = new Point(857, 7);
            welcomelbl.Name = "welcomelbl";
            welcomelbl.Size = new Size(123, 46);
            welcomelbl.TabIndex = 1;
            welcomelbl.Text = "label1";
            welcomelbl.TextAlign = ContentAlignment.MiddleCenter;
            welcomelbl.Click += welcomelbl_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnlogout);
            panel6.Controls.Add(pictureBox6);
            panel6.Location = new Point(681, 1);
            panel6.Name = "panel6";
            panel6.Size = new Size(170, 55);
            panel6.TabIndex = 5;
            // 
            // btnlogout
            // 
            btnlogout.AutoSize = true;
            btnlogout.Cursor = Cursors.Hand;
            btnlogout.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnlogout.Location = new Point(55, 14);
            btnlogout.Name = "btnlogout";
            btnlogout.Size = new Size(80, 25);
            btnlogout.TabIndex = 5;
            btnlogout.Text = "Log Out";
            btnlogout.Click += btnlogout_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.emergency_exit_4009127;
            pictureBox6.Location = new Point(3, 2);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(46, 50);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 5;
            pictureBox6.TabStop = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnreturnbook);
            panel4.Controls.Add(pictureBox5);
            panel4.Location = new Point(511, 1);
            panel4.Name = "panel4";
            panel4.Size = new Size(170, 55);
            panel4.TabIndex = 4;
            // 
            // btnreturnbook
            // 
            btnreturnbook.AutoSize = true;
            btnreturnbook.Cursor = Cursors.Hand;
            btnreturnbook.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnreturnbook.Location = new Point(51, 14);
            btnreturnbook.Name = "btnreturnbook";
            btnreturnbook.Size = new Size(119, 25);
            btnreturnbook.TabIndex = 4;
            btnreturnbook.Text = "Return Book";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.recycle_9250855;
            pictureBox5.Location = new Point(3, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(46, 50);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnissuebook);
            panel3.Controls.Add(pictureBox3);
            panel3.Location = new Point(171, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(170, 55);
            panel3.TabIndex = 2;
            // 
            // btnissuebook
            // 
            btnissuebook.AutoSize = true;
            btnissuebook.Cursor = Cursors.Hand;
            btnissuebook.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnissuebook.Location = new Point(55, 14);
            btnissuebook.Name = "btnissuebook";
            btnissuebook.Size = new Size(104, 25);
            btnissuebook.TabIndex = 2;
            btnissuebook.Text = "Issue Book";
            btnissuebook.Click += btnissuebook_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.book_1773069;
            pictureBox3.Location = new Point(3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(46, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnviewbook);
            panel5.Controls.Add(pictureBox4);
            panel5.Location = new Point(341, 1);
            panel5.Name = "panel5";
            panel5.Size = new Size(170, 55);
            panel5.TabIndex = 3;
            // 
            // btnviewbook
            // 
            btnviewbook.AutoSize = true;
            btnviewbook.Cursor = Cursors.Hand;
            btnviewbook.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnviewbook.Location = new Point(55, 14);
            btnviewbook.Name = "btnviewbook";
            btnviewbook.Size = new Size(110, 25);
            btnviewbook.TabIndex = 3;
            btnviewbook.Text = "View Books";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.book_2599258;
            pictureBox4.Location = new Point(3, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(46, 50);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnaddbook);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(1, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(170, 55);
            panel2.TabIndex = 1;
            // 
            // btnaddbook
            // 
            btnaddbook.AutoSize = true;
            btnaddbook.Cursor = Cursors.Hand;
            btnaddbook.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnaddbook.Location = new Point(55, 14);
            btnaddbook.Name = "btnaddbook";
            btnaddbook.Size = new Size(96, 25);
            btnaddbook.TabIndex = 1;
            btnaddbook.Text = "Add Book";
            btnaddbook.Click += btnaddbook_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ebook_8661034;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(46, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Properties.Resources.cross_14875490;
            pictureBox2.Location = new Point(1216, 8);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(38, 41);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.ancient_books_adorn_library_carefully_arranged_with_classics_rare_gems;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1264, 681);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "dashboard";
            Load += dashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox2;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox1;
        private Label btnlogout;
        private Label btnreturnbook;
        private Label btnissuebook;
        private Label btnviewbook;
        private Label btnaddbook;
        private Label welcomelbl;
        public Panel panel2;
        public Panel panel3;
    }
}