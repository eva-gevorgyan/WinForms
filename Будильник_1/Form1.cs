using System;
using System.IO;
using System.Windows.Forms;
using NAudio.Wave;

namespace Будильник_1
{
    public partial class Form1 : Form
    {
        private int hour, minute, second;
        private WaveOutEvent waveOutEvent;
        private AudioFileReader audioFileReader;
        private string selectedMusicPath;
        public Form1()
        {
            InitializeComponent();
            timer1.Tick += timer1_Tick;
            timer1.Interval = 1000;
            waveOutEvent = new WaveOutEvent();

            for (int i = 0; i <= 24; i++)
            {
                comboBox1.Items.Add(i);
            }
            for (int i = 0; i <= 60; i++)
            {
                comboBox2.Items.Add(i);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            hour = DateTime.Now.Hour;
            minute = DateTime.Now.Minute;
            second = DateTime.Now.Second;
            label1.Text = hour.ToString();
            label2.Text = minute.ToString();
            label3.Text = second.ToString();

            if (label1.Text == label4.Text && label2.Text == label5.Text)
            {
                if (File.Exists(selectedMusicPath))
                {
                    waveOutEvent.Stop();
                    audioFileReader = new AudioFileReader(selectedMusicPath);
                    waveOutEvent.Init(audioFileReader);
                    waveOutEvent.Play();
                    timer1.Stop();
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Музыкальные файлы|*.mp3";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedMusicPath = openFileDialog.FileName;
                button1.Text = selectedMusicPath;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
                label4.Text = comboBox1.SelectedItem.ToString();

            if (comboBox2.SelectedItem != null)
                label5.Text = comboBox2.SelectedItem.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            waveOutEvent.Stop();
        }
    }
}
