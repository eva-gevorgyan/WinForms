namespace x_o
{
    public partial class Form1 : Form
    {
        private int step, player;
        private Button[] buttons;

        public Form1()
        {
            InitializeComponent();
            step = 1;
            player = 1;
            buttons = new[] { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //switch (step)
            //{
            //    case 0:
            //        sender.GetType().GetProperty("Text").SetValue(sender, "o");
            //        label1.Text = "Player " + player;
            //        player = 1;
            //        step = 1;
            //        break;
            //    case 1:
            //        sender.GetType().GetProperty("Text").SetValue(sender, "x");
            //        label1.Text = "Player " + player;
            //        player = 2;
            //        step = 0;
            //        break;
            //}
            sender.GetType().GetProperty("Enabled").SetValue(sender, false);
            Check();
        }
        private void ResetButtons()
        {
            foreach (var button in buttons)
            {
                button.Text = "";
                button.Enabled = true;
            }
        }
        private bool CheckButtons(Button button1, Button button2, Button button3)
        {
            return button1.Text == button2.Text && button2.Text == button3.Text && button1.Text != "";
        }
        private void DisableButtons()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }
        private void Check()
        {
            foreach (var combo in new[]
            {
        new[] { button1, button2, button3 },
        new[] { button4, button5, button6 },
        new[] { button7, button8, button9 },
        new[] { button1, button4, button7 },
        new[] { button3, button5, button7 },
    })
            {
                if (CheckButtons(combo[0], combo[1], combo[2]))
                {
                    MessageBox.Show($"{player} player won!");
                    DisableButtons();
                    return;
                }
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            ResetButtons();
        }
    }
}