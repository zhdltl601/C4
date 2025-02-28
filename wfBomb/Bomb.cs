using System;
using System.Media;
using System.Text;
using System.Windows.Forms;
using wfBomb.Properties;
using System.IO;
using System.Diagnostics;
using Tulpep.NotificationWindow;
using System.Drawing;

namespace wfBomb
{
    public partial class Bomb : Form
    {
        #region Audio
        private readonly SoundPlayer sp_onTaskFinsihed;
        private readonly SoundPlayer sp_onTaskAnticipation;
        private readonly SoundPlayer sp_onPlant;
        private readonly StringBuilder stringBuilder;
        #endregion

        #region PopUp
        private readonly PopupNotifier popupNotifierOnFinsihed;
        #endregion

        private readonly string pauseButtonTextDefault;
        private readonly string pauseButtonTextResume;

        private readonly string muteBtnDefault;
        private readonly string muteBtnEnable;

        #region setting
        private bool muteAudio;
        #endregion

        private bool isPlanted;
        private bool isPlaying;

        private int targetHour;
        private int targetMinute;

        private int currentHour;
        private int currentMinute;
        private int currentSecond;
        public Bomb()
        {
            InitializeComponent();

            UnmanagedMemoryStream onExplosionAudio1 = Resources.onExplosion1real;
            UnmanagedMemoryStream onExplosionAudio2 = Resources.onExplosion2;
            UnmanagedMemoryStream onPlantAudio = Resources.bombHasBeenPlanted;

            sp_onTaskAnticipation = new SoundPlayer(onExplosionAudio1);//9 seconds
            sp_onTaskFinsihed = new SoundPlayer(onExplosionAudio2);
            sp_onPlant = new SoundPlayer(onPlantAudio);

            stringBuilder = new StringBuilder(5);

            pauseButtonTextDefault = PauseButton.Text;
            pauseButtonTextResume = "Resume";

            muteBtnDefault = MuteBtn.Text;
            muteBtnEnable = "EnableSound";

            popupNotifierOnFinsihed = new PopupNotifier();
            popupNotifierOnFinsihed.TitleText = "TaskFinished";
            popupNotifierOnFinsihed.TitleColor = Color.LightPink;

            //load user settings
            muteAudio = Settings.Default.IsMuted;
            MuteBtn.Text = muteAudio ? muteBtnEnable : muteBtnDefault;
        }
        ~Bomb()
        {
            sp_onTaskFinsihed.Dispose();
            sp_onTaskAnticipation.Dispose();
            sp_onPlant.Dispose();
        }
        private bool CanPlaySound => !muteAudio;
        private bool TryPlaySound(SoundPlayer player)
        {
            bool result = CanPlaySound;
            if (result)
                player.Play();
            return result;
        }
        private void UpdateCurrentTimeText()
        {
            string result = TimeUtility.ConvertTimeToString(currentHour, currentMinute);
            TimeHMLabel.Text = result;
            TimeSecondLabel.Text = string.Format("{0:D2}", currentSecond);
        }
        private void UpdateCurrentTime()
        {
            int currentSecondB60Result = MathfUtility.Base60(currentSecond);
            currentSecond -= 60 * currentSecondB60Result;
            currentMinute += currentSecondB60Result;

            int currentMinuteBase60Result = MathfUtility.Base60(currentMinute);
            currentMinute -= 60 * currentMinuteBase60Result;
            currentHour += currentMinuteBase60Result;

            currentHour = Math.Min(currentHour, 99);
        }
        private void GetTime(in string targetString, out int hour, out int minute)
        {
            stringBuilder.Clear();
            hour = 0;
            foreach (char item in targetString)
            {
                if (item == ':')
                {
                    hour = int.Parse(stringBuilder.ToString());
                    stringBuilder.Clear();
                }
                else
                {
                    if (item == ' ')
                        stringBuilder.Append('0');
                    else stringBuilder.Append(item);
                }

            }
            while (stringBuilder.Length < 2)
            {
                stringBuilder.Append('0');
            }
            minute = int.Parse(stringBuilder.ToString());
        }
        private void OnTaskFinsihed()
        {
            StopTimer();
            TryPlaySound(sp_onTaskFinsihed);

            FinishedTimeLabel.Visible = true;
            FinishedTimeHMLabel.Visible = true;
            DateTime current = DateTime.Now;
            int realTimeHour = current.Hour;
            //realTimeHour = realTimeHour > 12 ? realTimeHour - 12 : realTimeHour;
            int realTimeMinute = DateTime.Now.Minute;
            Debug.WriteLine($"{realTimeHour} {realTimeMinute}");
            FinishedTimeHMLabel.Text = TimeUtility.ConvertTimeToString(realTimeHour, realTimeMinute);

            popupNotifierOnFinsihed.ContentText = TimeUtility.ConvertTimeToString(targetHour, targetMinute);// string.Format("{0:D2}:{1:D2}", targetHour, targetMinute);
            popupNotifierOnFinsihed.Popup();
        }
        private void StopTimer()
        {
            Timer.Stop();
            isPlanted = false;
            isPlaying = false;
        }
        private void ResetTimer()
        {
            FinishedTimeLabel.Visible = false;
            FinishedTimeHMLabel.Visible = false;

            PauseButton.Text = pauseButtonTextDefault;
            EndTimeHMLabel.Text = TimeUtility.DEFAULT_TIME;
            sp_onTaskAnticipation.Stop();
            sp_onTaskFinsihed.Stop();
            currentHour = 0;
            currentMinute = 0;
            currentSecond = 0;
        }
        private void OnTick(object sender, EventArgs e)
        {
            currentSecond++;
            UpdateCurrentTime();
            UpdateCurrentTimeText();

            bool currentHourFlag = currentHour >= targetHour;
            bool currentMinuteFlag = currentMinute >= targetMinute;

            //uint antiHour;
            //uint antiMinute;
            const int anticipationSecond = 60 - 9; //number 9 : anticipation audioclip length, which is nine seconds
            if (CanPlaySound && currentHourFlag && currentMinute + 1 == targetMinute && currentSecond == anticipationSecond) // todo : fix this bug
            {
                sp_onTaskAnticipation.Play();
            }

            if (currentHourFlag && currentMinuteFlag)
            {
                OnTaskFinsihed();
            }
        }
        private void PlantButton_Click(object sender, EventArgs e)
        {
            GetTime(TimeInputMaskedTextBox.Text, out int hour, out int minute);
            TimeUtility.ConvertTimeToBase60(hour, minute, out int rHour, out int rMinute);

            bool invaludNumberInput = rHour == 0 && rMinute <= 0;
            if (invaludNumberInput)
            {
                // todo : invalid number popup
                MessageBox.Show("invalid number, time must be longer than zero minute", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (isPlanted)
            {
                DialogResult dialogResult = MessageBox.Show("C4 is already planted, replant?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult != DialogResult.Yes)
                {
                    return;
                }
            }

            ResetTimer();

            targetHour = rHour;
            targetMinute = rMinute;

            TryPlaySound(sp_onPlant);

            Timer.Start();

            TimeGB.Visible = true;
            isPlanted = true;
            isPlaying = true;

            TimeInputMaskedTextBox.Text = TimeUtility.DEFAULT_TIME;
            EndTimeHMLabel.Text = TimeUtility.ConvertTimeToString(rHour, rMinute);

            UpdateCurrentTimeText();
        }
        private void PauseButton_Click(object sender, EventArgs e)
        {
            if (!isPlanted) return;

            if (isPlaying)
            {
                isPlaying = false;
                PauseButton.Text = pauseButtonTextResume;
                Timer.Stop();
            }
            else
            {
                isPlaying = true;
                PauseButton.Text = pauseButtonTextDefault;
                Timer.Start();
            }
        }
        private void ClearTimerBtn_Click(object sender, EventArgs e)
        {
            TimeGB.Visible = false;
            ResetTimer();
            StopTimer();
            UpdateCurrentTimeText();
        }

        private void MuteBtn_Click(object sender, EventArgs e)
        {
            muteAudio = !muteAudio;
            Settings.Default.IsMuted = muteAudio;
            Settings.Default.Save();
            MuteBtn.Text = muteAudio ? muteBtnEnable : muteBtnDefault;
        }

        private void FileLoadBTN_Click(object sender, EventArgs e)
        {
        }
    }
}
