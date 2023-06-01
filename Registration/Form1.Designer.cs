namespace Registration
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label7 = new Label();
            textBox6 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(300, 19);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 0;
            label1.Text = "Registration";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(151, 73);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(151, 110);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 1;
            label3.Text = "Surname";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(151, 143);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 1;
            label4.Text = "Phone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(151, 177);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 1;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(151, 208);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 2;
            label6.Text = "Password";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(247, 69);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(215, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(247, 106);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(215, 27);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(247, 143);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(215, 27);
            textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(247, 177);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(215, 27);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(247, 208);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(215, 27);
            textBox5.TabIndex = 3;
            textBox5.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(114, 244);
            label7.Name = "label7";
            label7.Size = new Size(127, 20);
            label7.TabIndex = 2;
            label7.Text = "Confirm Password";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(247, 241);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(215, 27);
            textBox6.TabIndex = 3;
            textBox6.UseSystemPasswordChar = true;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(300, 288);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label7);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label7;
        private TextBox textBox6;
        private Button button1;
    }
}