using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using SpeechLib;

namespace TelaffuzGelistirici
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SpVoice sp = new SpVoice();
        private void button1_Click(object sender, EventArgs e)
        {
            SpeechRecognitionEngine sr = new SpeechRecognitionEngine();
            Grammar g = new DictationGrammar();
            sr.LoadGrammar(g);
            try
            {
                button1.Text = "Konuşun";
                sr.SetInputToDefaultAudioDevice();
                RecognitionResult res = sr.Recognize();
                button1.Text = res.Text;
            }
            catch (Exception)
            {
                button1.Text = "Hata";
            }
        }

        private void button1_TextChanged(object sender, EventArgs e)
        {
            if (button1.Text=="What's up")
            {
                label1.Text = "Fine thanks and you?";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sp.Speak(richTextBox1.Text);
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
