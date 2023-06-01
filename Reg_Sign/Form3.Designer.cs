namespace Reg_Sign
{
    partial class Form3
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
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            checkBox1 = new CheckBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(357, 41);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 0;
            label1.Text = "Sign in";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(200, 102);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 0;
            label2.Text = "UserName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(200, 153);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 0;
            label3.Text = "Password";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(304, 95);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(237, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(304, 146);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(237, 27);
            textBox2.TabIndex = 1;
            textBox2.UseSystemPasswordChar = true;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(547, 146);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(67, 24);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "Show";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(345, 225);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private CheckBox checkBox1;
        private Button button1;
    }
}