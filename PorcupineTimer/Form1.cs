//#define TEST
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PorcupineTimer.Audio;

namespace PorcupineTimer
{
    /// <summary>
    /// Main Form and also composition root
    /// </summary>
    public partial class Form1 : Form
    {

        private bool _started = false;
        private const int ticksPerHour = 6;
        private int _iterations;
        private readonly string _defaultButtonText;
        private readonly IAudioManager _audioManager;

        public Form1(IAudioManager audioManager)
        {
            if (audioManager == null)
            {
                throw new ArgumentNullException(nameof(audioManager));
            }
            _audioManager = audioManager;
            InitializeComponent();
            _defaultButtonText = btnStart.Text;
            SetHours();
        }

        private void SetHours()
        {
            var hours = tbTime.Value > 0 ? tbTime.Value : 0.5;
            lblHours.Text = $"Hours: {hours}";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
#if TEST
            tickTimer.Interval = 6000;
#endif
            ToggleTime();
        }

        private void ToggleTime()
        {
            if (!_started)
            {
                _started = true;
                var hours = tbTime.Value;
                _iterations = CalculateIterations(hours);
                pbStatus.Maximum = _iterations;
                tickTimer.Start();
                pbStatus.Visible = true;
                btnStart.Text = "Reset";
            }
            else
            {
                Reset();
            }
        }

        private int CalculateIterations(int hours)
        {
            if (hours > 0)
            {
                return hours * ticksPerHour;
            }
            else
            {
                return ticksPerHour / 2;
            }
        }

        private void Reset()
        {
            _started = false;
            tickTimer.Stop();
            pbStatus.Value = 0;
            pbStatus.Visible = false;
            btnStart.Text = _defaultButtonText;
        }

        private void tickTimer_Tick(object sender, EventArgs e)
        {
            if (_iterations > 0)
            {
                pbStatus.PerformStep();
                _iterations--;
            }
            else
            {
                MuteSound();
                Reset();
            }
        }

        private void MuteSound()
        {
            _audioManager.SetMasterVolumeMute(true);
        }

        private void tbTime_ValueChanged(object sender, EventArgs e)
        {
            SetHours();
        }
    }
}
