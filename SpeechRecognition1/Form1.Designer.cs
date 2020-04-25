namespace SpeechRecognition1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textToSpeakTextBox = new System.Windows.Forms.TextBox();
            this.speakButton = new System.Windows.Forms.Button();
            this.voicesComboBox = new System.Windows.Forms.ComboBox();
            this.rateTrackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.rateValueLabel = new System.Windows.Forms.Label();
            this.stopButton = new System.Windows.Forms.Button();
            this.volumeValueLabel = new System.Windows.Forms.Label();
            this.lable3 = new System.Windows.Forms.Label();
            this.volumeTrackBar = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rateTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // textToSpeakTextBox
            // 
            this.textToSpeakTextBox.Location = new System.Drawing.Point(22, 52);
            this.textToSpeakTextBox.Multiline = true;
            this.textToSpeakTextBox.Name = "textToSpeakTextBox";
            this.textToSpeakTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textToSpeakTextBox.Size = new System.Drawing.Size(692, 155);
            this.textToSpeakTextBox.TabIndex = 0;
            this.textToSpeakTextBox.Text = resources.GetString("textToSpeakTextBox.Text");
            // 
            // speakButton
            // 
            this.speakButton.Location = new System.Drawing.Point(593, 213);
            this.speakButton.Name = "speakButton";
            this.speakButton.Size = new System.Drawing.Size(110, 41);
            this.speakButton.TabIndex = 1;
            this.speakButton.Text = "Speak";
            this.speakButton.UseVisualStyleBackColor = true;
            this.speakButton.Click += new System.EventHandler(this.SpeakButtonClickHandler);
            // 
            // voicesComboBox
            // 
            this.voicesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.voicesComboBox.FormattingEnabled = true;
            this.voicesComboBox.Location = new System.Drawing.Point(22, 13);
            this.voicesComboBox.Name = "voicesComboBox";
            this.voicesComboBox.Size = new System.Drawing.Size(692, 21);
            this.voicesComboBox.TabIndex = 2;
            this.voicesComboBox.SelectedIndexChanged += new System.EventHandler(this.voicesComboBoxSelectedIndexChangedHandler);
            // 
            // rateTrackBar
            // 
            this.rateTrackBar.Location = new System.Drawing.Point(90, 228);
            this.rateTrackBar.Minimum = -10;
            this.rateTrackBar.Name = "rateTrackBar";
            this.rateTrackBar.Size = new System.Drawing.Size(352, 50);
            this.rateTrackBar.TabIndex = 3;
            this.rateTrackBar.Scroll += new System.EventHandler(this.RateTrackBarScrollHandler);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Rate";
            // 
            // rateValueLabel
            // 
            this.rateValueLabel.AutoSize = true;
            this.rateValueLabel.Location = new System.Drawing.Point(474, 242);
            this.rateValueLabel.Name = "rateValueLabel";
            this.rateValueLabel.Size = new System.Drawing.Size(14, 15);
            this.rateValueLabel.TabIndex = 5;
            this.rateValueLabel.Text = "0";
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(593, 260);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(110, 41);
            this.stopButton.TabIndex = 6;
            this.stopButton.Text = "Stop Speaking";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButtonClickHandler);
            // 
            // volumeValueLabel
            // 
            this.volumeValueLabel.AutoSize = true;
            this.volumeValueLabel.Location = new System.Drawing.Point(474, 284);
            this.volumeValueLabel.Name = "volumeValueLabel";
            this.volumeValueLabel.Size = new System.Drawing.Size(14, 15);
            this.volumeValueLabel.TabIndex = 9;
            this.volumeValueLabel.Text = "0";
            // 
            // lable3
            // 
            this.lable3.AutoSize = true;
            this.lable3.Location = new System.Drawing.Point(32, 284);
            this.lable3.Name = "lable3";
            this.lable3.Size = new System.Drawing.Size(49, 15);
            this.lable3.TabIndex = 8;
            this.lable3.Text = "Volume";
            // 
            // volumeTrackBar
            // 
            this.volumeTrackBar.LargeChange = 30;
            this.volumeTrackBar.Location = new System.Drawing.Point(90, 270);
            this.volumeTrackBar.Maximum = 100;
            this.volumeTrackBar.Name = "volumeTrackBar";
            this.volumeTrackBar.Size = new System.Drawing.Size(352, 50);
            this.volumeTrackBar.SmallChange = 15;
            this.volumeTrackBar.TabIndex = 7;
            this.volumeTrackBar.Scroll += new System.EventHandler(this.volumeTrackBar_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 366);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.volumeValueLabel);
            this.Controls.Add(this.lable3);
            this.Controls.Add(this.volumeTrackBar);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.rateValueLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rateTrackBar);
            this.Controls.Add(this.voicesComboBox);
            this.Controls.Add(this.speakButton);
            this.Controls.Add(this.textToSpeakTextBox);
            this.Name = "Form1";
            this.Text = "v";
            ((System.ComponentModel.ISupportInitialize)(this.rateTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textToSpeakTextBox;
        private System.Windows.Forms.Button speakButton;
        private System.Windows.Forms.ComboBox voicesComboBox;
        private System.Windows.Forms.TrackBar rateTrackBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label rateValueLabel;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Label volumeValueLabel;
        private System.Windows.Forms.Label lable3;
        private System.Windows.Forms.TrackBar volumeTrackBar;
        private System.Windows.Forms.Label label2;
    }
}

