using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.IO;
using System.Reflection;

namespace TextToSpeech
{
    public partial class frmTextToSpeech : Form
    {
        SpeechSynthesizer objSpeechSynthesizer;
        public frmTextToSpeech()
        {
            InitializeComponent();
        }

        #region PAUSE
        private void pbPause_Click(object sender, EventArgs e)
        {

            if (objSpeechSynthesizer != null)
            {
                if (objSpeechSynthesizer.State == SynthesizerState.Paused)
                {
                    objSpeechSynthesizer.Resume();
                    lblMsg.Text = "RESUMED";
                }
                else if (objSpeechSynthesizer.State == SynthesizerState.Speaking)
                {
                    objSpeechSynthesizer.Pause();
                    lblMsg.Text = "PAUSED";
                }
                pbPlay.Cursor = Cursors.Hand;
                pbPlay.Enabled = false;
            }
        }
        #endregion

        #region SPEAK TEXT
        private void pbPlay_Click(object sender, EventArgs e)
        {
            //objSpeechSynthesizer.Dispose();
            //string imgPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Images\Player_Pause.PNG");
            //pbPlay.Image = Image.FromFile(imgPath);
          
            if(rtbText.Text != "")
            {
                objSpeechSynthesizer = new SpeechSynthesizer();              
                objSpeechSynthesizer.SpeakAsync(rtbText.Text);               
                lblMsg.Text = "SPEAKING";
                pbPlay.Cursor = Cursors.Default;
                pbPlay.Enabled = false;
                objSpeechSynthesizer.SpeakCompleted += new EventHandler<SpeakCompletedEventArgs>(objSpeechSynthesizer_SpeakCompleted);
            }
        }
        public void objSpeechSynthesizer_SpeakCompleted(object sender, SpeakCompletedEventArgs e)
        {
            lblMsg.Text="IDLE";
            pbPlay.Cursor = Cursors.Hand;
            pbPlay.Enabled = true;
        }
        #endregion

        #region STOP
        private void pbStop_Click(object sender, EventArgs e)
        {
            if(objSpeechSynthesizer != null)
            {
                objSpeechSynthesizer.Dispose();
                lblMsg.Text = "IDLE";
                pbPlay.Cursor = Cursors.Hand;
                pbPlay.Enabled = true;
            }
        }
        #endregion
      

    }
}
