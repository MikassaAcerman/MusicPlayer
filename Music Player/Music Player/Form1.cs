using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Player
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openMusicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "All Media (*mp3;*mp4;*Png;*jpg) | *.mp3;*.mp4;*.png;*.jpg";
            if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                axWindowsMediaPlayer1.URL = openFileDialog1.FileName;
            }
        }

        private void textToSpeechToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Text_To_Speech s = new Text_To_Speech();
            s.ShowDialog();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help s = new Help();
            s.ShowDialog();
        }

        private void helpToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("HI \n Duble click for full open \n app version1.0");
        }
    }
}
