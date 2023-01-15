using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;

namespace Music_Player
{
    
    
    public partial class Text_To_Speech : Form
    {
        SpeechSynthesizer s = new SpeechSynthesizer();
        bool a;
        public Text_To_Speech()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            s.Rate = trackBar1.Value;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            s.Volume = trackBar2.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (a)
            {
                s.Volume = 100;
                s.Rate = 100;
            }
            s.SpeakAsync(textBox1.Text);
        }

        private void Text_To_Speech_Load(object sender, EventArgs e)
        {

        }
    }
}
