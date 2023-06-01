namespace Reg_Sign
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            textBox3 = new TextBox();
            button1 = new Button();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(314, 42);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 0;
            label1.Text = "Registration";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(170, 99);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 1;
            label2.Text = "UserName";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(272, 92);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(283, 27);
            textBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(170, 191);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(272, 184);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(283, 27);
            textBox2.TabIndex = 4;
            textBox2.UseSystemPasswordChar = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(272, 138);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(283, 27);
            dateTimePicker1.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(170, 145);
            label4.Name = "label4";
            label4.Size = new Size(40, 20);
            label4.TabIndex = 6;
            label4.Text = "Birth";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(139, 231);
            label5.Name = "label5";
            label5.Size = new Size(127, 20);
            label5.TabIndex = 3;
            label5.Text = "Confirm Password";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(272, 228);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(283, 27);
            textBox3.TabIndex = 4;
            textBox3.UseSystemPasswordChar = true;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(314, 316);
            button1.Name = "button1";
            button1.Size = new Size(157, 54);
            button1.TabIndex = 7;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(579, 184);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(67, 24);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Show";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private Label label5;
        private TextBox textBox3;
        private Button button1;
        private CheckBox checkBox1;
    }
}