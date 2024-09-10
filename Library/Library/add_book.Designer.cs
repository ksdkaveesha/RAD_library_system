namespace Library
{
    partial class add_book
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
            BookId = new Label();
            txtbookid = new TextBox();
            addbook = new Button();
            Title = new Label();
            txttitle = new TextBox();
            AvailableCopies = new Label();
            txtauthor = new TextBox();
            Author = new Label();
            txtavailablecopies = new TextBox();
            reset = new Button();
            groupBox1 = new GroupBox();
            label5 = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)label5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BookId
            // 
            BookId.AutoSize = true;
            BookId.Font = new Font("Segoe UI", 12F);
            BookId.Location = new Point(51, 85);
            BookId.Name = "BookId";
            BookId.Size = new Size(62, 21);
            BookId.TabIndex = 0;
            BookId.Text = "Book Id";
            // 
            // txtbookid
            // 
            txtbookid.Location = new Point(212, 85);
            txtbookid.Name = "txtbookid";
            txtbookid.PlaceholderText = "Enter Book Id";
            txtbookid.Size = new Size(198, 29);
            txtbookid.TabIndex = 1;
            // 
            // addbook
            // 
            addbook.Location = new Point(490, 85);
            addbook.Name = "addbook";
            addbook.Size = new Size(167, 87);
            addbook.TabIndex = 2;
            addbook.Text = "Add Book";
            addbook.UseVisualStyleBackColor = true;
            addbook.Click += addbook_Click;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 12F);
            Title.Location = new Point(51, 143);
            Title.Name = "Title";
            Title.Size = new Size(39, 21);
            Title.TabIndex = 3;
            Title.Text = "Title";
            // 
            // txttitle
            // 
            txttitle.Location = new Point(212, 143);
            txttitle.Name = "txttitle";
            txttitle.PlaceholderText = "Enter Title of the Book";
            txttitle.Size = new Size(198, 29);
            txttitle.TabIndex = 4;
            // 
            // AvailableCopies
            // 
            AvailableCopies.AutoSize = true;
            AvailableCopies.Font = new Font("Segoe UI", 12F);
            AvailableCopies.Location = new Point(51, 260);
            AvailableCopies.Name = "AvailableCopies";
            AvailableCopies.Size = new Size(124, 21);
            AvailableCopies.TabIndex = 5;
            AvailableCopies.Text = "Available Copies";
            // 
            // txtauthor
            // 
            txtauthor.Location = new Point(212, 202);
            txtauthor.Name = "txtauthor";
            txtauthor.PlaceholderText = "Enter Author of the Book";
            txtauthor.Size = new Size(198, 29);
            txtauthor.TabIndex = 6;
            // 
            // Author
            // 
            Author.AutoSize = true;
            Author.Font = new Font("Segoe UI", 12F);
            Author.Location = new Point(51, 202);
            Author.Name = "Author";
            Author.Size = new Size(58, 21);
            Author.TabIndex = 7;
            Author.Text = "Author";
            // 
            // txtavailablecopies
            // 
            txtavailablecopies.Location = new Point(212, 260);
            txtavailablecopies.Name = "txtavailablecopies";
            txtavailablecopies.PlaceholderText = "Number of Copies available";
            txtavailablecopies.Size = new Size(198, 29);
            txtavailablecopies.TabIndex = 8;
            // 
            // reset
            // 
            reset.Location = new Point(490, 202);
            reset.Name = "reset";
            reset.Size = new Size(167, 87);
            reset.TabIndex = 9;
            reset.Text = "Reset";
            reset.UseVisualStyleBackColor = true;
            reset.Click += reset_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(reset);
            groupBox1.Controls.Add(txtavailablecopies);
            groupBox1.Controls.Add(Author);
            groupBox1.Controls.Add(txtauthor);
            groupBox1.Controls.Add(AvailableCopies);
            groupBox1.Controls.Add(txttitle);
            groupBox1.Controls.Add(Title);
            groupBox1.Controls.Add(addbook);
            groupBox1.Controls.Add(txtbookid);
            groupBox1.Controls.Add(BookId);
            groupBox1.Font = new Font("Segoe UI", 12F);
            groupBox1.Location = new Point(30, 69);
            groupBox1.Margin = new Padding(5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5);
            groupBox1.Size = new Size(737, 367);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
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
            label5.TabIndex = 15;
            label5.TabStop = false;
            label5.Click += label5_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Script MT Bold", 30F, FontStyle.Bold);
            label1.Location = new Point(81, 21);
            label1.Name = "label1";
            label1.Size = new Size(223, 48);
            label1.TabIndex = 17;
            label1.Text = "Book Haven";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveBorder;
            pictureBox1.Image = Properties.Resources.icons8_book;
            pictureBox1.Location = new Point(12, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(62, 58);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // add_book
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "add_book";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Book";
            Load += add_book_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)label5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label BookId;
        private TextBox txtbookid;
        private Button addbook;
        private Label Title;
        private TextBox txttitle;
        private Label AvailableCopies;
        private TextBox txtauthor;
        private Label Author;
        private TextBox txtavailablecopies;
        private Button reset;
        private GroupBox groupBox1;
        private PictureBox label5;
        private Label label1;
        private PictureBox pictureBox1;
    }
}