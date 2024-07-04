namespace lms.Admin.Controls
{
    partial class AddBook
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            titleTextBox = new TextBox();
            authorTextBox = new TextBox();
            label3 = new Label();
            isbnTextBox = new TextBox();
            label4 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 25);
            label1.Name = "label1";
            label1.Size = new Size(137, 37);
            label1.TabIndex = 0;
            label1.Text = "Add Book";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(34, 107);
            label2.Name = "label2";
            label2.Size = new Size(42, 22);
            label2.TabIndex = 1;
            label2.Text = "Title";
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new Point(34, 138);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(388, 27);
            titleTextBox.TabIndex = 2;
            // 
            // authorTextBox
            // 
            authorTextBox.Location = new Point(34, 218);
            authorTextBox.Name = "authorTextBox";
            authorTextBox.Size = new Size(388, 27);
            authorTextBox.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(34, 187);
            label3.Name = "label3";
            label3.Size = new Size(63, 22);
            label3.TabIndex = 3;
            label3.Text = "Author";
            // 
            // isbnTextBox
            // 
            isbnTextBox.Location = new Point(34, 298);
            isbnTextBox.Name = "isbnTextBox";
            isbnTextBox.Size = new Size(388, 27);
            isbnTextBox.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(34, 267);
            label4.Name = "label4";
            label4.Size = new Size(46, 22);
            label4.TabIndex = 5;
            label4.Text = "ISBN";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.Font = new Font("Calibri", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(34, 355);
            button1.Name = "button1";
            button1.Size = new Size(128, 40);
            button1.TabIndex = 7;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // AddBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(isbnTextBox);
            Controls.Add(label4);
            Controls.Add(authorTextBox);
            Controls.Add(label3);
            Controls.Add(titleTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddBook";
            Size = new Size(557, 482);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox titleTextBox;
        private TextBox authorTextBox;
        private Label label3;
        private TextBox isbnTextBox;
        private Label label4;
        private Button button1;
    }
}
