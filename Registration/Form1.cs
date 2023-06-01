using System.Drawing.Printing;

namespace Registration
{
    public partial class Form1 : Form
    {
        string name, surname, phone, email, password, confirmpassword;
        public Form1()
        {
            InitializeComponent();
            button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            name = textBox1.Text;
            surname = textBox2.Text;
            phone = textBox3.Text;
            email = textBox4.Text;
            password = textBox5.Text;
            confirmpassword = textBox6.Text;

            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(pd_Print);

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        void pd_Print(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 15);
            Brush brush = Brushes.Pink;
            e.Graphics.DrawString("Info", font, brush, label1.Location.X, label1.Location.Y);
            e.Graphics.DrawString("name: " + name, font, brush, 10, 50);
            e.Graphics.DrawString("surname: " + surname, font, brush, 10, 80);
            e.Graphics.DrawString("phone: " + phone, font, brush, 10, 110);
            e.Graphics.DrawString("email: " + email, font, brush, 10, 140);
            e.Graphics.DrawString("password: " + password, font, brush, 10, 170);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
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
    }
}