namespace Library
{
    partial class view_book
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)label5).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveBorder;
            pictureBox1.Image = Properties.Resources.icons8_book;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(62, 58);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 33;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Script MT Bold", 30F, FontStyle.Bold);
            label1.Location = new Point(80, 16);
            label1.Name = "label1";
            label1.Size = new Size(223, 48);
            label1.TabIndex = 32;
            label1.Text = "Book Haven";
            // 
            // label5
            // 
            label5.BackgroundImageLayout = ImageLayout.Center;
            label5.Cursor = Cursors.Hand;
            label5.Image = Properties.Resources.cross_14875490;
            label5.Location = new Point(750, 12);
            label5.Name = "label5";
            label5.Size = new Size(38, 41);
            label5.SizeMode = PictureBoxSizeMode.StretchImage;
            label5.TabIndex = 31;
            label5.TabStop = false;
            label5.Click += label5_Click;
            // 
            // view_book
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(label5);
            FormBorderStyle = FormBorderStyle.None;
            Name = "view_book";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Display Books";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)label5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox label5;
    }
}