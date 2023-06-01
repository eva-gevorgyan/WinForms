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
    public partial class Form3 : Form
    {
        private User user;

        public Form3(User user)
        {
            InitializeComponent();
            this.user = user;
        }


        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            bool isAuthenticated = user.Authenticate(username, password);

            if (isAuthenticated)
            {
                MessageBox.Show("Authentication successful. Welcome back!");
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }
    }
}
