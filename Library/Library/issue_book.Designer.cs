namespace Library
{
    partial class issue_book
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
            label5 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            reset = new Button();
            issuebook = new Button();
            txtbookid = new TextBox();
            BookId = new Label();
            txtmemberid = new TextBox();
            memberid = new Label();
            txtmembername = new TextBox();
            membername = new Label();
            txtmemberphone = new TextBox();
            memberphone = new Label();
            txtmemberaddress = new TextBox();
            memberaddress = new Label();
            ((System.ComponentModel.ISupportInitialize)label5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
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
            label5.TabIndex = 16;
            label5.TabStop = false;
            label5.Click += label5_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveBorder;
            pictureBox1.Image = Properties.Resources.icons8_book;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(62, 58);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Script MT Bold", 30F, FontStyle.Bold);
            label1.Location = new Point(80, 16);
            label1.Name = "label1";
            label1.Size = new Size(223, 48);
            label1.TabIndex = 29;
            label1.Text = "Book Haven";
            // 
            // reset
            // 
            reset.Location = new Point(529, 258);
            reset.Name = "reset";
            reset.Size = new Size(167, 87);
            reset.TabIndex = 28;
            reset.Text = "Reset";
            reset.UseVisualStyleBackColor = true;
            // 
            // issuebook
            // 
            issuebook.Location = new Point(529, 150);
            issuebook.Name = "issuebook";
            issuebook.Size = new Size(167, 87);
            issuebook.TabIndex = 21;
            issuebook.Text = "Issue Book";
            issuebook.UseVisualStyleBackColor = true;
            issuebook.Click += issuebook_Click;
            // 
            // txtbookid
            // 
            txtbookid.Location = new Point(286, 127);
            txtbookid.Name = "txtbookid";
            txtbookid.PlaceholderText = "Enter Book Id";
            txtbookid.Size = new Size(208, 23);
            txtbookid.TabIndex = 20;
            // 
            // BookId
            // 
            BookId.AutoSize = true;
            BookId.Font = new Font("Segoe UI", 12F);
            BookId.Location = new Point(90, 127);
            BookId.Name = "BookId";
            BookId.Size = new Size(62, 21);
            BookId.TabIndex = 19;
            BookId.Text = "Book Id";
            // 
            // txtmemberid
            // 
            txtmemberid.Location = new Point(286, 181);
            txtmemberid.Name = "txtmemberid";
            txtmemberid.PlaceholderText = "Enter Member's Id Number";
            txtmemberid.Size = new Size(208, 23);
            txtmemberid.TabIndex = 32;
            // 
            // memberid
            // 
            memberid.AutoSize = true;
            memberid.Font = new Font("Segoe UI", 12F);
            memberid.Location = new Point(90, 181);
            memberid.Name = "memberid";
            memberid.Size = new Size(148, 21);
            memberid.TabIndex = 31;
            memberid.Text = "Member Id Number";
            // 
            // txtmembername
            // 
            txtmembername.Location = new Point(286, 234);
            txtmembername.Name = "txtmembername";
            txtmembername.PlaceholderText = "Enter Member's Name";
            txtmembername.Size = new Size(208, 23);
            txtmembername.TabIndex = 40;
            // 
            // membername
            // 
            membername.AutoSize = true;
            membername.Font = new Font("Segoe UI", 12F);
            membername.Location = new Point(90, 234);
            membername.Name = "membername";
            membername.Size = new Size(115, 21);
            membername.TabIndex = 39;
            membername.Text = "Member Name";
            // 
            // txtmemberphone
            // 
            txtmemberphone.Location = new Point(286, 289);
            txtmemberphone.Name = "txtmemberphone";
            txtmemberphone.PlaceholderText = "Enter Member's Telephone Number";
            txtmemberphone.Size = new Size(208, 23);
            txtmemberphone.TabIndex = 42;
            // 
            // memberphone
            // 
            memberphone.AutoSize = true;
            memberphone.Font = new Font("Segoe UI", 12F);
            memberphone.Location = new Point(90, 289);
            memberphone.Name = "memberphone";
            memberphone.Size = new Size(179, 21);
            memberphone.TabIndex = 41;
            memberphone.Text = "Member Phone Number";
            // 
            // txtmemberaddress
            // 
            txtmemberaddress.Location = new Point(286, 346);
            txtmemberaddress.Name = "txtmemberaddress";
            txtmemberaddress.PlaceholderText = "Enter Member's Address";
            txtmemberaddress.Size = new Size(208, 23);
            txtmemberaddress.TabIndex = 44;
            // 
            // memberaddress
            // 
            memberaddress.AutoSize = true;
            memberaddress.Font = new Font("Segoe UI", 12F);
            memberaddress.Location = new Point(90, 346);
            memberaddress.Name = "memberaddress";
            memberaddress.Size = new Size(129, 21);
            memberaddress.TabIndex = 43;
            memberaddress.Text = "Member Address";
            // 
            // issue_book
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(txtmemberaddress);
            Controls.Add(memberaddress);
            Controls.Add(txtmemberphone);
            Controls.Add(memberphone);
            Controls.Add(txtmembername);
            Controls.Add(membername);
            Controls.Add(txtmemberid);
            Controls.Add(memberid);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(reset);
            Controls.Add(issuebook);
            Controls.Add(txtbookid);
            Controls.Add(BookId);
            Controls.Add(label5);
            FormBorderStyle = FormBorderStyle.None;
            Name = "issue_book";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Issue Books";
            Load += issue_book_Load;
            ((System.ComponentModel.ISupportInitialize)label5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox label5;
        private PictureBox pictureBox1;
        private Label label1;
        private Button reset;
        private Button issuebook;
        private TextBox txtbookid;
        private Label BookId;
        private TextBox txtmemberid;
        private Label memberid;
        private TextBox txtmembername;
        private Label membername;
        private TextBox txtmemberphone;
        private Label memberphone;
        private TextBox txtmemberaddress;
        private Label memberaddress;
    }
}