using System.Drawing.Printing;

namespace CV_Print
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Image cvImage;
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg,*.jpeg)|*.jpg;*.jpeg";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                cvImage = Image.FromFile(openFileDialog.FileName);
                cvImage = ResizeImage(cvImage, pictureBox1.Width, pictureBox1.Height);
                pictureBox1.Image = cvImage;
            }
        }

        private Image ResizeImage(Image image, int width, int height)
        {
            Bitmap resizedImage = new Bitmap(width, height);
            using (Graphics graphics = Graphics.FromImage(resizedImage))
            {
                graphics.DrawImage(image, 0, 0, width, height);
            }
            return resizedImage;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.DocumentName = "CV";
            printDocument.PrintPage += new PrintPageEventHandler(pd_PrintPage);

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        void pd_PrintPage(object sender, PrintPageEventArgs ev)
        {
            string name = textBox1.Text;
            string surname = textBox2.Text;
            string phone = textBox3.Text;
            string email = textBox4.Text;
            string address = textBox5.Text;

            if (cvImage != null)
            {
                ev.Graphics.DrawImage(cvImage, 10, 10);
            }

            Font font = new Font("Arial", 12);
            Brush brush = Brushes.Red;
            ev.Graphics.DrawString("Name: " + name, font, brush, 10, 50 + cvImage.Height);
            ev.Graphics.DrawString("Surname: " + surname, font, brush, 10, 70 + cvImage.Height);
            ev.Graphics.DrawString("Phone: " + phone, font, brush, 10, 90 + cvImage.Height);
            ev.Graphics.DrawString("Email: " + email, font, brush, 10, 110 + cvImage.Height);
            ev.Graphics.DrawString("Address: " + address, font, brush, 10, 130 + cvImage.Height);
        }

    }
}