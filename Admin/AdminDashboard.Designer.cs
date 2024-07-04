namespace lms.Admin
{
    partial class AdminDashboard
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
            splitContainer1 = new SplitContainer();
            groupBox2 = new GroupBox();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            groupBox1 = new GroupBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            removeUser1 = new Controls.Users.RemoveUser();
            addUser1 = new Controls.Users.AddUser();
            allUsers1 = new Controls.Users.AllUsers();
            allBooks1 = new Controls.AllBooks();
            addBook1 = new Controls.AddBook();
            removeBook1 = new Controls.RemoveBook();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBox2);
            splitContainer1.Panel1.Controls.Add(groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(removeBook1);
            splitContainer1.Panel2.Controls.Add(removeUser1);
            splitContainer1.Panel2.Controls.Add(addUser1);
            splitContainer1.Panel2.Controls.Add(allUsers1);
            splitContainer1.Panel2.Controls.Add(allBooks1);
            splitContainer1.Panel2.Controls.Add(addBook1);
            splitContainer1.Size = new Size(1083, 521);
            splitContainer1.SplitterDistance = 360;
            splitContainer1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(button6);
            groupBox2.Location = new Point(16, 287);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(345, 170);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "User Actions";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // button4
            // 
            button4.BackColor = Color.OliveDrab;
            button4.Font = new Font("Calibri", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(0, 123);
            button4.Name = "button4";
            button4.Size = new Size(339, 37);
            button4.TabIndex = 2;
            button4.Text = "Remove User";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.OliveDrab;
            button5.Font = new Font("Calibri", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Location = new Point(0, 80);
            button5.Name = "button5";
            button5.Size = new Size(339, 37);
            button5.TabIndex = 1;
            button5.Text = "Add User";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.OliveDrab;
            button6.Font = new Font("Calibri", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.White;
            button6.Location = new Point(0, 37);
            button6.Name = "button6";
            button6.Size = new Size(339, 37);
            button6.TabIndex = 0;
            button6.Text = "All Users";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(12, 78);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(345, 171);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Book Actions";
            // 
            // button3
            // 
            button3.BackColor = Color.OliveDrab;
            button3.Font = new Font("Calibri", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(0, 131);
            button3.Name = "button3";
            button3.Size = new Size(339, 37);
            button3.TabIndex = 2;
            button3.Text = "Remove Book";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.OliveDrab;
            button2.Font = new Font("Calibri", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(0, 88);
            button2.Name = "button2";
            button2.Size = new Size(339, 37);
            button2.TabIndex = 1;
            button2.Text = "Add Book";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.OliveDrab;
            button1.Font = new Font("Calibri", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(0, 45);
            button1.Name = "button1";
            button1.Size = new Size(339, 37);
            button1.TabIndex = 0;
            button1.Text = "All Books";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // removeUser1
            // 
            removeUser1.Location = new Point(-1, 0);
            removeUser1.Name = "removeUser1";
            removeUser1.Size = new Size(720, 522);
            removeUser1.TabIndex = 5;
            // 
            // addUser1
            // 
            addUser1.Location = new Point(-1, 3);
            addUser1.Name = "addUser1";
            addUser1.Size = new Size(720, 519);
            addUser1.TabIndex = 4;
            // 
            // allUsers1
            // 
            allUsers1.Location = new Point(3, 0);
            allUsers1.Name = "allUsers1";
            allUsers1.Size = new Size(716, 521);
            allUsers1.TabIndex = 3;
            // 
            // allBooks1
            // 
            allBooks1.Location = new Point(3, 3);
            allBooks1.Name = "allBooks1";
            allBooks1.Size = new Size(735, 515);
            allBooks1.TabIndex = 1;
            // 
            // addBook1
            // 
            addBook1.Location = new Point(3, 3);
            addBook1.Name = "addBook1";
            addBook1.Size = new Size(682, 482);
            addBook1.TabIndex = 2;
            // 
            // removeBook1
            // 
            removeBook1.Location = new Point(-1, 12);
            removeBook1.Name = "removeBook1";
            removeBook1.Size = new Size(720, 482);
            removeBook1.TabIndex = 6;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1083, 521);
            Controls.Add(splitContainer1);
            Name = "AdminDashboard";
            Text = "AdminDashboard";
            Load += AdminDashboard_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private GroupBox groupBox2;
        private Button button4;
        private Button button5;
        private Button button6;
        private GroupBox groupBox1;
        private Button button2;
        private Button button1;
        private Controls.AllBooks allBooks1;
        private Controls.AddBook addBook1;
        private Controls.Users.AllUsers allUsers1;
        private Controls.Users.AddUser addUser1;
        private Controls.Users.RemoveUser removeUser1;
        private Button button3;
        private Controls.RemoveBook removeBook1;
    }
}