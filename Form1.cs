using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypingSpeedCheckerISuppose
{
    public partial class Form1 : Form
    {

        int seconds = 0;
        int minutes = 0;
        int hours = 0;
        int totalSeconds = 0;

        public Form1()
        {
            InitializeComponent();
            InitializeProgressBar();
            InitializeTimer();
        }

        private void InitializeTimer()
        {
            timerSeconds.Interval = 1000;
        }

        private void InitializeProgressBar()
        {
            pbarTextProgress.Maximum = lablMainText.Text.Length;
        }

        private void pboxClose_MouseEnter(object sender, EventArgs e)
        {
            pboxClose.Image = Properties.Resources.download__2_;
        }

        private void pboxClose_MouseLeave(object sender, EventArgs e)
        {
            pboxClose.Image = Properties.Resources.download__1_;
        }

        private void pboxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tboxWritingSpace_TextChanged(object sender, EventArgs e)
        {
            if(!timerSeconds.Enabled)
            {
                timerSeconds.Start();
            }
            int textCount = tboxWritingSpace.Text.Length;
            string lablString = lablMainText.Text.Substring(0, textCount);
            if(tboxWritingSpace.Text != lablString)
            {
                tboxWritingSpace.MaxLength = textCount;
                tboxWritingSpace.ForeColor = Color.Red;
            }
            else
            {
                tboxWritingSpace.MaxLength = lablMainText.Text.Length;
                tboxWritingSpace.ForeColor = Color.FromName("WindowText");
                UpdateProgressBar();
            }
            if(tboxWritingSpace.Text == lablMainText.Text)
            {
                Victory();
            }
        }

        private void UpdateLabelCPS()
        {
            if(totalSeconds> 0)
            {
                lablCPS.Text = "CPS: " + CharactersPerSecond().ToString();
            }
        }

        private void UpdateLabelCPM()
        {
            if (totalSeconds > 0)
            {
                lablCPM.Text = "CPM: " + CharactersPerMinute().ToString();
            }
        }

        private void Victory()
        {
            MessageBox.Show("You did it! Good job! Letters Per Second: " + CharactersPerSecond().ToString() + "! Letters Per Minute: " + CharactersPerMinute().ToString() + "! Final Time: " + hours.ToString("00") + ":" + minutes.ToString("00") + ":" + seconds.ToString("00") + "!");
            tboxWritingSpace.Clear();
            timerSeconds.Stop();
            seconds = 0;
            hours = 0;
            minutes = 0;
            totalSeconds = 0;
            UpdateTimeLabel();
            tboxWritingSpace.MaxLength = lablMainText.Text.Length;
            tboxWritingSpace.ForeColor = Color.FromName("WindowText");
            UpdateProgressBar();
        }

        private decimal CharactersPerSecond()
        {
            return tboxWritingSpace.Text.Length/ totalSeconds;
        }

        private decimal CharactersPerMinute()
        {
            return CharactersPerSecond() * 60;
        }

        private void UpdateProgressBar()
        {
            pbarTextProgress.Value = tboxWritingSpace.Text.Length;
        }

        private void timerSeconds_Tick(object sender, EventArgs e)
        {
            seconds++;
            if(seconds == 60)
            {
                seconds = 0;
                minutes++;
                if(minutes == 60)
                {
                    minutes = 0;
                    hours++;
                    if(hours > 99)
                    {
                        TimesUp();
                    }
                }
            }
            UpdateLabelCPS();
            UpdateLabelCPM();
            UpdateTimeLabel();
            totalSeconds++;
        }
        
        private void TimesUp()
        {
            MessageBox.Show("Times Up! Why did it take you over 99 hours? Did you really want to see what happens? Well this is all you get!");
            timerSeconds.Stop();
            tboxWritingSpace.Clear();
            seconds = 0;
            hours = 0;
            minutes = 0;
            totalSeconds = 0;
            UpdateTimeLabel();
            tboxWritingSpace.MaxLength = lablMainText.Text.Length;
            tboxWritingSpace.ForeColor = Color.FromName("WindowText");
            UpdateProgressBar();
        }

        private void UpdateTimeLabel()
        {
            lablTime.Text = "Time: " + hours.ToString("00") + ":" + minutes.ToString("00") + ":" + seconds.ToString("00");
        }
    }

}
