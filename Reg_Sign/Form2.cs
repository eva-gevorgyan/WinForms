using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reg_Sign
{
    public partial class Form2 : Form
    {
        private User user;
        public Form2(User user)
        {
            InitializeComponent();
            this.user = user;
            button1.Enabled = false;
        }

        string username, password, confirmpassword;
        DateTime birth;
        private void button1_Click(object sender, EventArgs e)
        {
            username = textBox1.Text;
            password = textBox2.Text;
            confirmpassword = textBox3.Text;

            bool passwordsMatch = string.Equals(password, confirmpassword);

            if (passwordsMatch)
            {
                if (user.IsUsernameTaken(username))
                {
                    MessageBox.Show("This username is already taken. Please choose a different username.");
                }
                else
                {
                    MessageBox.Show($"{username}, welcome to our page!");
                    user.SaveInfo(username, password);
                }
            }
            else
            {
                MessageBox.Show("Passwords do not match!");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (password == confirmpassword)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
                textBox3.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
                textBox3.UseSystemPasswordChar = true;
            }
        }
    }
}
