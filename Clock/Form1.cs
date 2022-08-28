using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Clock
{
    public partial class form1 : Form
    {
        int miliseconds, seconds, minuts, hours;

        public form1()
        {
            InitializeComponent();
            RealStart();
        }
        public void RealStart()
        {
            miliseconds = 0;
            seconds = 0;
            minuts = 0;
            hours = 0;
            stopwatchMilisec.Text = miliseconds.ToString();
            stopwatchSec.Text = seconds.ToString();
            stopwatchMin.Text = minuts.ToString();
            stopwatchHour.Text = hours.ToString();

            swStartButton.Enabled = true;
            swPauseButton.Enabled = false;
            swResetButton.Enabled = false;
            swContinueButton.Enabled = false;
            swRecordButton.Enabled = false;
        }
        private void form1_Load(object sender, EventArgs e)
        {

        }
        private void timerMS_Tick(object sender, EventArgs e)
        {
            TimeStart();
        }
        public  void TimeStart()
        {
            if(miliseconds < 1000)
            {
                miliseconds += 16;
                stopwatchMilisec.Text = miliseconds.ToString();
            }
            if(miliseconds >= 1000)
            {
                miliseconds = 0;
                seconds++;
                stopwatchMilisec.Text = miliseconds.ToString();
                stopwatchSec.Text = seconds.ToString();
            }
            if(seconds == 60)
            {
                seconds = 0;
                minuts++;
                stopwatchSec.Text = seconds.ToString();
                stopwatchMin.Text = minuts.ToString();
            }
            if(minuts == 60)
            {
                minuts = 0;
                hours++;
                stopwatchMin.Text = minuts.ToString();
                stopwatchHour.Text = hours.ToString();
            }
        }
        private void stopwatchMilisec_Click(object sender, EventArgs e)
        {

        }

        private void stopwatchSec_Click(object sender, EventArgs e)
        {

        }

        private void stopwatchMin_Click(object sender, EventArgs e)
        {

        }

        private void stopwatchHour_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void swContinueButton_Click(object sender, EventArgs e)
        {
            timerMS.Start();
        }

        private void swRecordButton_Click(object sender, EventArgs e)
        {
            swHistory.Text = $"{hours}:{minuts}:{seconds}.{miliseconds}";
        }

        private void swHistory_Click(object sender, EventArgs e)
        {

        }

        private void timer_Click(object sender, EventArgs e)
        {

        }

        private void swStartButton_Click(object sender, EventArgs e)
        {
            timerMS.Start();
            swStartButton.Enabled = false;
            swPauseButton.Enabled = true;
            swResetButton.Enabled = true;
            swRecordButton.Enabled = true;
        }

        private void swPauseButton_Click(object sender, EventArgs e)
        {
            timerMS.Stop();
            swContinueButton.Enabled = true;
            swResetButton.Enabled = true;
        }

        private void swResetButton_Click(object sender, EventArgs e)
        {
            timerMS.Stop();
            RealStart();
        }
    }
}
