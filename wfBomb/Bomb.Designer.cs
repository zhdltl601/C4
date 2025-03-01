using System;
using System.Media;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;
namespace wfBomb
{
    partial class Bomb
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }
        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bomb));
            this.PlantButton = new System.Windows.Forms.Button();
            this.TimeLeftLabel = new System.Windows.Forms.Label();
            this.TimeInputMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.TimeHMLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.PauseButton = new System.Windows.Forms.Button();
            this.TimeSecondLabel = new System.Windows.Forms.Label();
            this.ClearTimerBtn = new System.Windows.Forms.Button();
            this.CurrentTimeLabel = new System.Windows.Forms.Label();
            this.EndTimeHMLabel = new System.Windows.Forms.Label();
            this.TimeGB = new System.Windows.Forms.GroupBox();
            this.MuteBtn = new System.Windows.Forms.Button();
            this.OFD_LoadAudio = new System.Windows.Forms.OpenFileDialog();
            this.FileLoadBTN = new System.Windows.Forms.Button();
            this.FinishedTimeLabel = new System.Windows.Forms.Label();
            this.FinishedTimeHMLabel = new System.Windows.Forms.Label();
            this.StartedTimeLabel = new System.Windows.Forms.Label();
            this.StartedTimeHMLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.TimeGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlantButton
            // 
            this.PlantButton.AccessibleDescription = "";
            this.PlantButton.Location = new System.Drawing.Point(12, 115);
            this.PlantButton.Name = "PlantButton";
            this.PlantButton.Size = new System.Drawing.Size(139, 35);
            this.PlantButton.TabIndex = 1;
            this.PlantButton.Text = "Plant!";
            this.PlantButton.UseVisualStyleBackColor = true;
            this.PlantButton.Click += new System.EventHandler(this.PlantButton_Click);
            // 
            // TimeLeftLabel
            // 
            this.TimeLeftLabel.AutoSize = true;
            this.TimeLeftLabel.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TimeLeftLabel.Location = new System.Drawing.Point(11, 29);
            this.TimeLeftLabel.Name = "TimeLeftLabel";
            this.TimeLeftLabel.Size = new System.Drawing.Size(149, 28);
            this.TimeLeftLabel.TabIndex = 2;
            this.TimeLeftLabel.Text = "CurrentTime : ";
            // 
            // TimeInputMaskedTextBox
            // 
            this.TimeInputMaskedTextBox.Location = new System.Drawing.Point(157, 117);
            this.TimeInputMaskedTextBox.Mask = "90:00";
            this.TimeInputMaskedTextBox.Name = "TimeInputMaskedTextBox";
            this.TimeInputMaskedTextBox.Size = new System.Drawing.Size(137, 31);
            this.TimeInputMaskedTextBox.TabIndex = 3;
            this.TimeInputMaskedTextBox.Text = "0000";
            this.TimeInputMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // TimeHMLabel
            // 
            this.TimeHMLabel.AutoSize = true;
            this.TimeHMLabel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TimeHMLabel.Location = new System.Drawing.Point(162, 29);
            this.TimeHMLabel.Name = "TimeHMLabel";
            this.TimeHMLabel.Size = new System.Drawing.Size(71, 32);
            this.TimeHMLabel.TabIndex = 4;
            this.TimeHMLabel.Text = "00:00";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::wfBomb.Properties.Resources.fish7;
            this.pictureBox1.Location = new System.Drawing.Point(12, 336);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::wfBomb.Properties.Resources.c4_2;
            this.pictureBox2.Location = new System.Drawing.Point(312, 34);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(300, 300);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.OnTick);
            // 
            // PauseButton
            // 
            this.PauseButton.AccessibleDescription = "";
            this.PauseButton.Location = new System.Drawing.Point(12, 156);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(139, 35);
            this.PauseButton.TabIndex = 8;
            this.PauseButton.Text = "Pause";
            this.PauseButton.UseVisualStyleBackColor = true;
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // TimeSecondLabel
            // 
            this.TimeSecondLabel.AutoSize = true;
            this.TimeSecondLabel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TimeSecondLabel.Location = new System.Drawing.Point(235, 29);
            this.TimeSecondLabel.Name = "TimeSecondLabel";
            this.TimeSecondLabel.Size = new System.Drawing.Size(40, 32);
            this.TimeSecondLabel.TabIndex = 9;
            this.TimeSecondLabel.Text = "00";
            // 
            // ClearTimerBtn
            // 
            this.ClearTimerBtn.AccessibleDescription = "";
            this.ClearTimerBtn.Location = new System.Drawing.Point(12, 197);
            this.ClearTimerBtn.Name = "ClearTimerBtn";
            this.ClearTimerBtn.Size = new System.Drawing.Size(139, 35);
            this.ClearTimerBtn.TabIndex = 10;
            this.ClearTimerBtn.Text = "ClearTimer";
            this.ClearTimerBtn.UseVisualStyleBackColor = true;
            this.ClearTimerBtn.Click += new System.EventHandler(this.ClearTimerBtn_Click);
            // 
            // CurrentTimeLabel
            // 
            this.CurrentTimeLabel.AutoSize = true;
            this.CurrentTimeLabel.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CurrentTimeLabel.Location = new System.Drawing.Point(11, 68);
            this.CurrentTimeLabel.Name = "CurrentTimeLabel";
            this.CurrentTimeLabel.Size = new System.Drawing.Size(141, 28);
            this.CurrentTimeLabel.TabIndex = 11;
            this.CurrentTimeLabel.Text = "EndTime      :";
            // 
            // EndTimeHMLabel
            // 
            this.EndTimeHMLabel.AutoSize = true;
            this.EndTimeHMLabel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EndTimeHMLabel.Location = new System.Drawing.Point(162, 68);
            this.EndTimeHMLabel.Name = "EndTimeHMLabel";
            this.EndTimeHMLabel.Size = new System.Drawing.Size(71, 32);
            this.EndTimeHMLabel.TabIndex = 12;
            this.EndTimeHMLabel.Text = "00:00";
            // 
            // TimeGB
            // 
            this.TimeGB.Controls.Add(this.CurrentTimeLabel);
            this.TimeGB.Controls.Add(this.EndTimeHMLabel);
            this.TimeGB.Controls.Add(this.TimeSecondLabel);
            this.TimeGB.Controls.Add(this.TimeLeftLabel);
            this.TimeGB.Controls.Add(this.TimeHMLabel);
            this.TimeGB.Location = new System.Drawing.Point(0, 0);
            this.TimeGB.Name = "TimeGB";
            this.TimeGB.Size = new System.Drawing.Size(294, 109);
            this.TimeGB.TabIndex = 13;
            this.TimeGB.TabStop = false;
            this.TimeGB.Text = "Time";
            this.TimeGB.Visible = false;
            // 
            // MuteBtn
            // 
            this.MuteBtn.AccessibleDescription = "";
            this.MuteBtn.Location = new System.Drawing.Point(11, 238);
            this.MuteBtn.Name = "MuteBtn";
            this.MuteBtn.Size = new System.Drawing.Size(139, 35);
            this.MuteBtn.TabIndex = 14;
            this.MuteBtn.Text = "MuteSound";
            this.MuteBtn.UseVisualStyleBackColor = true;
            this.MuteBtn.Click += new System.EventHandler(this.MuteBtn_Click);
            // 
            // OFD_LoadAudio
            // 
            this.OFD_LoadAudio.FileName = "openFileDialog1";
            // 
            // FileLoadBTN
            // 
            this.FileLoadBTN.Location = new System.Drawing.Point(12, 279);
            this.FileLoadBTN.Name = "FileLoadBTN";
            this.FileLoadBTN.Size = new System.Drawing.Size(112, 34);
            this.FileLoadBTN.TabIndex = 15;
            this.FileLoadBTN.Text = "LoadFile";
            this.FileLoadBTN.UseVisualStyleBackColor = true;
            this.FileLoadBTN.Click += new System.EventHandler(this.FileLoadBTN_Click);
            // 
            // FinishedTimeLabel
            // 
            this.FinishedTimeLabel.AutoSize = true;
            this.FinishedTimeLabel.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FinishedTimeLabel.Location = new System.Drawing.Point(312, 32);
            this.FinishedTimeLabel.Name = "FinishedTimeLabel";
            this.FinishedTimeLabel.Size = new System.Drawing.Size(154, 28);
            this.FinishedTimeLabel.TabIndex = 13;
            this.FinishedTimeLabel.Text = "FinishedTime : ";
            this.FinishedTimeLabel.Visible = false;
            // 
            // FinishedTimeHMLabel
            // 
            this.FinishedTimeHMLabel.AutoSize = true;
            this.FinishedTimeHMLabel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FinishedTimeHMLabel.Location = new System.Drawing.Point(460, 32);
            this.FinishedTimeHMLabel.Name = "FinishedTimeHMLabel";
            this.FinishedTimeHMLabel.Size = new System.Drawing.Size(71, 32);
            this.FinishedTimeHMLabel.TabIndex = 13;
            this.FinishedTimeHMLabel.Text = "00:00";
            this.FinishedTimeHMLabel.Visible = false;
            // 
            // StartedTimeLabel
            // 
            this.StartedTimeLabel.AutoSize = true;
            this.StartedTimeLabel.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StartedTimeLabel.Location = new System.Drawing.Point(312, 9);
            this.StartedTimeLabel.Name = "StartedTimeLabel";
            this.StartedTimeLabel.Size = new System.Drawing.Size(147, 28);
            this.StartedTimeLabel.TabIndex = 16;
            this.StartedTimeLabel.Text = "StartedTime  :";
            this.StartedTimeLabel.Visible = false;
            // 
            // StartedTimeHMLabel
            // 
            this.StartedTimeHMLabel.AutoSize = true;
            this.StartedTimeHMLabel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StartedTimeHMLabel.Location = new System.Drawing.Point(460, 6);
            this.StartedTimeHMLabel.Name = "StartedTimeHMLabel";
            this.StartedTimeHMLabel.Size = new System.Drawing.Size(71, 32);
            this.StartedTimeHMLabel.TabIndex = 17;
            this.StartedTimeHMLabel.Text = "00:00";
            this.StartedTimeHMLabel.Visible = false;
            // 
            // Bomb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 424);
            this.Controls.Add(this.StartedTimeHMLabel);
            this.Controls.Add(this.StartedTimeLabel);
            this.Controls.Add(this.FinishedTimeHMLabel);
            this.Controls.Add(this.FinishedTimeLabel);
            this.Controls.Add(this.FileLoadBTN);
            this.Controls.Add(this.MuteBtn);
            this.Controls.Add(this.TimeGB);
            this.Controls.Add(this.ClearTimerBtn);
            this.Controls.Add(this.PauseButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TimeInputMaskedTextBox);
            this.Controls.Add(this.PlantButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Bomb";
            this.Text = "Plantin the bomb";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.TimeGB.ResumeLayout(false);
            this.TimeGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button PlantButton;
        private Label TimeLeftLabel;
        private MaskedTextBox TimeInputMaskedTextBox;
        private Label TimeHMLabel;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Timer Timer;
        private Button PauseButton;
        private Label TimeSecondLabel;
        private Button ClearTimerBtn;
        private Label CurrentTimeLabel;
        private Label EndTimeHMLabel;
        private GroupBox TimeGB;
        private Button MuteBtn;
        private OpenFileDialog OFD_LoadAudio;
        private Button FileLoadBTN;
        private Label FinishedTimeLabel;
        private Label FinishedTimeHMLabel;
        private Label StartedTimeLabel;
        private Label StartedTimeHMLabel;
    }
}

