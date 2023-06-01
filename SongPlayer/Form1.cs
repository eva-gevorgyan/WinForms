using NAudio.Wave;

namespace SongPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            waveOutEvent = new WaveOutEvent();
           // audioFileReader = null;
        }
        private string selectedMusic;
        private void button1_Click(object sender, EventArgs e)
        {
            var openfiledialog = new OpenFileDialog();
            openfiledialog.Filter = "Музыкальные файлы|*.mp3";
            if (openfiledialog.ShowDialog() == DialogResult.OK)
            {
                selectedMusic = openfiledialog.FileName;
                button1.Text = selectedMusic;
            }
        }

        private WaveOutEvent waveOutEvent;
        private AudioFileReader audioFileReader;
        private void button2_Click(object sender, EventArgs e)
        {
            if (File.Exists(selectedMusic))
            {
                waveOutEvent.Stop();
                audioFileReader = new AudioFileReader(selectedMusic);
                waveOutEvent.Init(audioFileReader);
                waveOutEvent.Play();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (waveOutEvent != null)
            {
                waveOutEvent.Pause();
            }
        }

        private float volume = 1.0f;
        private void button4_Click(object sender, EventArgs e)
        {
            if (waveOutEvent != null)
            {
                volume += 0.1f;
                if (volume > 1.0f)
                    volume = 1.0f;
                waveOutEvent.Volume = volume;
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (waveOutEvent != null)
            {
                volume -= 0.1f;
                if (volume < 0.0f)
                    volume = 0.0f;
                waveOutEvent.Volume = volume;
            }
        }

    }
}