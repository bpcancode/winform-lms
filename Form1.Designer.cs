﻿namespace lms
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
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(121, 38);
            label1.Name = "label1";
            label1.Size = new Size(548, 54);
            label1.TabIndex = 0;
            label1.Text = "Library Management System";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(178, 195);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(280, 27);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(178, 274);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(280, 27);
            textBox2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(178, 243);
            label3.Name = "label3";
            label3.Size = new Size(82, 22);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(178, 159);
            label2.Name = "label2";
            label2.Size = new Size(87, 22);
            label2.TabIndex = 5;
            label2.Text = "Username";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.Font = new Font("Calibri", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(178, 326);
            button1.Name = "button1";
            button1.Size = new Size(153, 44);
            button1.TabIndex = 6;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 10.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.HotTrack;
            label4.Location = new Point(272, 386);
            label4.Name = "label4";
            label4.Size = new Size(121, 22);
            label4.TabIndex = 7;
            label4.Text = "Register a User";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private Label label2;
        private Button button1;
        private Label label4;
    }
}