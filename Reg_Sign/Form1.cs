namespace Reg_Sign
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private User user = new User();
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(user);
            form2.ShowDialog();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(user);
            form3.ShowDialog();
        }
    }
}