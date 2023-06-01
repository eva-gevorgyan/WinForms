namespace Клавиатура
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
        private void button1_Click(object sender, EventArgs e)
        {
            if (isCapsLockEnable)
            {
                textBox1.Text += (sender as Button).Text.ToUpper();
            }
            else
            {
                textBox1.Text += (sender as Button).Text;
            }
        }

        private void button48_Click(object sender, EventArgs e)
        {
            textBox1.Text += " ";
        }

        private bool isNumLockEnabled = false;
        private void button38_Click(object sender, EventArgs e)
        {
            isNumLockEnabled = !isNumLockEnabled;
            UpdateButtonStates();
        }

        private void UpdateButtonStates()
        {
            button27.Enabled = isNumLockEnabled; button28.Enabled = isNumLockEnabled; button29.Enabled = isNumLockEnabled;
            button30.Enabled = isNumLockEnabled; button31.Enabled = isNumLockEnabled; button32.Enabled = isNumLockEnabled;
            button33.Enabled = isNumLockEnabled; button34.Enabled = isNumLockEnabled; button35.Enabled = isNumLockEnabled;
            button36.Enabled = isNumLockEnabled; button37.Enabled = isNumLockEnabled;
        }

        private bool isCapsLockEnable = false;
        private void button49_Click(object sender, EventArgs e)
        {
            isCapsLockEnable = !isCapsLockEnable;
        }

        private void button44_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectionStart > 0)
            {
                textBox1.SelectionStart--;
                textBox1.SelectionLength = 0;
                textBox1.Focus();
            }
        }

        private void button46_Click(object sender, EventArgs e)
        {
            int selectionStart = textBox1.SelectionStart;
            int textLength = textBox1.TextLength;

            if (selectionStart < textLength)
            {
                textBox1.SelectionStart = selectionStart + 1;
                textBox1.Focus();
            }
        }

        private void button47_Click(object sender, EventArgs e)
        {
            int selectionStart = textBox1.SelectionStart;
            int currentLine = textBox1.GetLineFromCharIndex(selectionStart);
            int lineCount = textBox1.Lines.Length;

            if (currentLine < lineCount - 1)
            {
                int nextLineStartIndex = textBox1.GetFirstCharIndexFromLine(currentLine + 1);
                textBox1.SelectionStart = nextLineStartIndex;
                textBox1.Focus();
            }
        }

        private void button45_Click(object sender, EventArgs e)
        {
            int selectionStart = textBox1.SelectionStart;
            int currentLine = textBox1.GetLineFromCharIndex(selectionStart);

            if (currentLine > 0)
            {
                int previousLineStartIndex = textBox1.GetFirstCharIndexFromLine(currentLine - 1);
                textBox1.SelectionStart = previousLineStartIndex;
                textBox1.Focus();
            }
        }
        private void button50_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }
        }
        private void button51_Click(object sender, EventArgs e)
        {
            textBox1.Text += "    ";
        }
    }
}