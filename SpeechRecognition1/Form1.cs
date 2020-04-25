using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace SpeechRecognition1
{
    public partial class Form1 : Form
    {
        private SpeechSynthesizer _synthesizer;
        private List<VoiceInfo> _availableVoices = new List<VoiceInfo>();

        public Form1()
        {
            InitializeComponent();
            _synthesizer = new SpeechSynthesizer();
            LoadVoices();


            rateTrackBar.Value = _synthesizer.Rate;
            rateValueLabel.Text = _synthesizer.Rate.ToString();

            volumeTrackBar.Value = _synthesizer.Volume;
            volumeValueLabel.Text = _synthesizer.Volume.ToString();


            _synthesizer.SpeakProgress += (s, e) => label2.Text = e.Text;

        }

        private void SpeakButtonClickHandler(object sender, EventArgs e)
        {
            _synthesizer.SpeakAsync(textToSpeakTextBox.Text);
        }

        private void LoadVoices()
        {
            //var voices = _synthesizer.GetInstalledVoices();
            
            foreach (var voice in _synthesizer.GetInstalledVoices())
            {
                if (!voice.Enabled)
                    continue; // continue in loop skips and starts again the loop. 
                _availableVoices.Add(voice.VoiceInfo);
                voicesComboBox.Items.Add($"{voice.VoiceInfo.Name} ({voice.VoiceInfo.Culture})");
            }

            if (voicesComboBox.Items.Count > 0)
                voicesComboBox.SelectedIndex = 0;
        }

        private void voicesComboBoxSelectedIndexChangedHandler(object sender, EventArgs e)
        {
            var voiceInfo = _availableVoices[voicesComboBox.SelectedIndex];
            _synthesizer.SelectVoice(voiceInfo.Name);
        }

        private void RateTrackBarScrollHandler(object sender, EventArgs e)
        {
            rateValueLabel.Text = rateTrackBar.Value.ToString();
            _synthesizer.Rate = rateTrackBar.Value;
        }

        private void stopButtonClickHandler(object sender, EventArgs e)
        {
            _synthesizer.SpeakAsyncCancelAll();
        }

        private void volumeTrackBar_Scroll(object sender, EventArgs e)
        {
            volumeValueLabel.Text = volumeTrackBar.Value.ToString();
            _synthesizer.Volume = volumeTrackBar.Value;
        }
    }
}
