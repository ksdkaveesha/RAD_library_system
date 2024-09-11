namespace Library
{
    partial class return_book
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
            btnclose = new PictureBox();
            BookId = new Label();
            txtbookid = new TextBox();
            lblbookid = new Label();
            txtmemberid = new TextBox();
            lblreturndate = new Label();
            txtlatefee = new TextBox();
            lbllatefee = new Label();
            dataGridView1 = new DataGridView();
            btnsearch = new Button();
            btnreturn = new Button();
            btnrefresh = new Button();
            btncalculate = new Button();
            txtreturndate = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnclose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveBorder;
            pictureBox1.Image = Properties.Resources.icons8_book;
            pictureBox1.Location = new Point(12, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(62, 58);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Script MT Bold", 30F, FontStyle.Bold);
            label1.Location = new Point(81, 21);
            label1.Name = "label1";
            label1.Size = new Size(223, 48);
            label1.TabIndex = 20;
            label1.Text = "Book Haven";
            // 
            // btnclose
            // 
            btnclose.BackgroundImageLayout = ImageLayout.Center;
            btnclose.Cursor = Cursors.Hand;
            btnclose.Image = Properties.Resources.cross_14875490;
            btnclose.Location = new Point(750, 12);
            btnclose.Name = "btnclose";
            btnclose.Size = new Size(38, 41);
            btnclose.SizeMode = PictureBoxSizeMode.StretchImage;
            btnclose.TabIndex = 19;
            btnclose.TabStop = false;
            btnclose.Click += close_Click;
            // 
            // BookId
            // 
            BookId.AutoSize = true;
            BookId.Font = new Font("Segoe UI", 12F);
            BookId.Location = new Point(65, 147);
            BookId.Name = "BookId";
            BookId.Size = new Size(187, 21);
            BookId.TabIndex = 22;
            BookId.Text = "Member ID Card Number";
            // 
            // txtbookid
            // 
            txtbookid.Location = new Point(278, 373);
            txtbookid.Name = "txtbookid";
            txtbookid.Size = new Size(215, 23);
            txtbookid.TabIndex = 25;
            // 
            // lblbookid
            // 
            lblbookid.AutoSize = true;
            lblbookid.Font = new Font("Segoe UI", 12F);
            lblbookid.Location = new Point(65, 373);
            lblbookid.Name = "lblbookid";
            lblbookid.Size = new Size(64, 21);
            lblbookid.TabIndex = 24;
            lblbookid.Text = "Book ID";
            // 
            // txtmemberid
            // 
            txtmemberid.Location = new Point(278, 149);
            txtmemberid.Name = "txtmemberid";
            txtmemberid.Size = new Size(215, 23);
            txtmemberid.TabIndex = 27;
            // 
            // lblreturndate
            // 
            lblreturndate.AutoSize = true;
            lblreturndate.Font = new Font("Segoe UI", 12F);
            lblreturndate.Location = new Point(65, 418);
            lblreturndate.Name = "lblreturndate";
            lblreturndate.Size = new Size(205, 21);
            lblreturndate.TabIndex = 26;
            lblreturndate.Text = "Return Date (MM/DD/YYYY)";
            // 
            // txtlatefee
            // 
            txtlatefee.Location = new Point(278, 464);
            txtlatefee.Name = "txtlatefee";
            txtlatefee.ReadOnly = true;
            txtlatefee.Size = new Size(215, 23);
            txtlatefee.TabIndex = 29;
            // 
            // lbllatefee
            // 
            lbllatefee.AutoSize = true;
            lbllatefee.Font = new Font("Segoe UI", 12F);
            lbllatefee.Location = new Point(65, 464);
            lbllatefee.Name = "lbllatefee";
            lbllatefee.Size = new Size(67, 21);
            lbllatefee.TabIndex = 28;
            lbllatefee.Text = "Late Fee";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(65, 208);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridView1.Size = new Size(674, 150);
            dataGridView1.TabIndex = 30;
            // 
            // btnsearch
            // 
            btnsearch.Location = new Point(513, 149);
            btnsearch.Name = "btnsearch";
            btnsearch.Size = new Size(105, 23);
            btnsearch.TabIndex = 31;
            btnsearch.Text = "Search";
            btnsearch.UseVisualStyleBackColor = true;
            btnsearch.Click += btnsearch_Click;
            // 
            // btnreturn
            // 
            btnreturn.Location = new Point(513, 443);
            btnreturn.Name = "btnreturn";
            btnreturn.Size = new Size(226, 44);
            btnreturn.TabIndex = 32;
            btnreturn.Text = "Return Book";
            btnreturn.UseVisualStyleBackColor = true;
            // 
            // btnrefresh
            // 
            btnrefresh.Location = new Point(634, 373);
            btnrefresh.Name = "btnrefresh";
            btnrefresh.Size = new Size(105, 46);
            btnrefresh.TabIndex = 33;
            btnrefresh.Text = "Refresh";
            btnrefresh.UseVisualStyleBackColor = true;
            btnrefresh.Click += btnrefresh_Click;
            // 
            // btncalculate
            // 
            btncalculate.Location = new Point(513, 373);
            btncalculate.Name = "btncalculate";
            btncalculate.Size = new Size(105, 46);
            btncalculate.TabIndex = 34;
            btncalculate.Text = "Calculate Fee";
            btncalculate.UseVisualStyleBackColor = true;
            btncalculate.Click += btncalculate_Click;
            // 
            // txtreturndate
            // 
            txtreturndate.Location = new Point(278, 420);
            txtreturndate.Name = "txtreturndate";
            txtreturndate.Size = new Size(215, 23);
            txtreturndate.TabIndex = 35;
            // 
            // return_book
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 528);
            Controls.Add(txtreturndate);
            Controls.Add(btncalculate);
            Controls.Add(btnrefresh);
            Controls.Add(btnreturn);
            Controls.Add(btnsearch);
            Controls.Add(dataGridView1);
            Controls.Add(txtlatefee);
            Controls.Add(lbllatefee);
            Controls.Add(txtmemberid);
            Controls.Add(lblreturndate);
            Controls.Add(txtbookid);
            Controls.Add(lblbookid);
            Controls.Add(BookId);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(btnclose);
            FormBorderStyle = FormBorderStyle.None;
            Name = "return_book";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Return Book";
            Load += return_book_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnclose).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox btnclose;
        private Label BookId;
        private TextBox txtbookid;
        private Label lblbookid;
        private TextBox txtmemberid;
        private Label lblreturndate;
        private TextBox txtlatefee;
        private Label lbllatefee;
        private DataGridView dataGridView1;
        private Button btnsearch;
        private Button btnreturn;
        private Button btnrefresh;
        private Button btncalculate;
        private MaskedTextBox txtreturndate;
    }
}