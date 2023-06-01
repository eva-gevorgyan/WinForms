namespace _10_TO_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            int number10 = int.Parse(textBox1.Text);
            string number2 = "";
            Stack<int> stack = new Stack<int>();
            while (number10 > 0)
            {
                stack.Push(number10 % 2);
                number10 /= 2;
            }
            foreach (var s in stack)
            {
                number2 += s;
            }
            //int c = int.Parse(number2);
            textBox2.Text = number2;
        }
    }
}