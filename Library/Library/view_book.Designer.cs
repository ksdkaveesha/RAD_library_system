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
            txtavailablecopies = new TextBox();
            Author = new Label();
            txtauthor = new TextBox();
            AvailableCopies = new Label();
            txttitle = new TextBox();
            Title = new Label();
            txtbookid = new TextBox();
            BookId = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            txtsearch = new TextBox();
            search = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)label5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // txtavailablecopies
            // 
            txtavailablecopies.Location = new Point(224, 318);
            txtavailablecopies.Name = "txtavailablecopies";
            txtavailablecopies.Size = new Size(198, 23);
            txtavailablecopies.TabIndex = 41;
            // 
            // Author
            // 
            Author.AutoSize = true;
            Author.Font = new Font("Segoe UI", 12F);
            Author.Location = new Point(63, 260);
            Author.Name = "Author";
            Author.Size = new Size(58, 21);
            Author.TabIndex = 40;
            Author.Text = "Author";
            // 
            // txtauthor
            // 
            txtauthor.Location = new Point(224, 260);
            txtauthor.Name = "txtauthor";
            txtauthor.Size = new Size(198, 23);
            txtauthor.TabIndex = 39;
            // 
            // AvailableCopies
            // 
            AvailableCopies.AutoSize = true;
            AvailableCopies.Font = new Font("Segoe UI", 12F);
            AvailableCopies.Location = new Point(63, 318);
            AvailableCopies.Name = "AvailableCopies";
            AvailableCopies.Size = new Size(124, 21);
            AvailableCopies.TabIndex = 38;
            AvailableCopies.Text = "Available Copies";
            // 
            // txttitle
            // 
            txttitle.Location = new Point(224, 201);
            txttitle.Name = "txttitle";
            txttitle.Size = new Size(198, 23);
            txttitle.TabIndex = 37;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 12F);
            Title.Location = new Point(63, 201);
            Title.Name = "Title";
            Title.Size = new Size(39, 21);
            Title.TabIndex = 36;
            Title.Text = "Title";
            // 
            // txtbookid
            // 
            txtbookid.Location = new Point(224, 143);
            txtbookid.Name = "txtbookid";
            txtbookid.Size = new Size(198, 23);
            txtbookid.TabIndex = 35;
            // 
            // BookId
            // 
            BookId.AutoSize = true;
            BookId.Font = new Font("Segoe UI", 12F);
            BookId.Location = new Point(63, 143);
            BookId.Name = "BookId";
            BookId.Size = new Size(62, 21);
            BookId.TabIndex = 34;
            BookId.Text = "Book Id";
            // 
            // button1
            // 
            button1.Location = new Point(460, 143);
            button1.Name = "button1";
            button1.Size = new Size(118, 81);
            button1.TabIndex = 42;
            button1.Text = "Update Book";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(598, 143);
            button2.Name = "button2";
            button2.Size = new Size(118, 81);
            button2.TabIndex = 43;
            button2.Text = "Delete Book";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(598, 260);
            button3.Name = "button3";
            button3.Size = new Size(118, 81);
            button3.TabIndex = 45;
            button3.Text = "Next >>";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(460, 260);
            button4.Name = "button4";
            button4.Size = new Size(118, 81);
            button4.TabIndex = 44;
            button4.Text = "<< Previous";
            button4.UseVisualStyleBackColor = true;
            // 
            // txtsearch
            // 
            txtsearch.Location = new Point(460, 98);
            txtsearch.Name = "txtsearch";
            txtsearch.PlaceholderText = "Enter Book Id";
            txtsearch.Size = new Size(163, 23);
            txtsearch.TabIndex = 47;
            // 
            // search
            // 
            search.Location = new Point(640, 98);
            search.Name = "search";
            search.Size = new Size(76, 23);
            search.TabIndex = 48;
            search.Text = "Search";
            search.UseVisualStyleBackColor = true;
            search.Click += button5_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ActiveBorder;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(63, 381);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(653, 245);
            dataGridView1.TabIndex = 49;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // view_book
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 638);
            Controls.Add(dataGridView1);
            Controls.Add(search);
            Controls.Add(txtsearch);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtavailablecopies);
            Controls.Add(Author);
            Controls.Add(txtauthor);
            Controls.Add(AvailableCopies);
            Controls.Add(txttitle);
            Controls.Add(Title);
            Controls.Add(txtbookid);
            Controls.Add(BookId);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(label5);
            FormBorderStyle = FormBorderStyle.None;
            Name = "view_book";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Display Books";
            Load += view_book_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)label5).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox label5;
        private TextBox txtavailablecopies;
        private Label Author;
        private TextBox txtauthor;
        private Label AvailableCopies;
        private TextBox txttitle;
        private Label Title;
        private TextBox txtbookid;
        private Label BookId;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox txtsearch;
        private Button search;
        private DataGridView dataGridView1;
    }
}