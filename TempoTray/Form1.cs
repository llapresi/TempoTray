using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace TempoTray
{
    public partial class Form1 : Form
    {
        // current bpm to put in BPM Label
        float currentBPM;

        // Stopwatch used to get times
        Stopwatch watch;

        // int counting times bpm button is tapped
        int count;

        // float storing milliseconds of first tap
        float mSecsFirst;

        // float storing milliseconds of previous tap
        float mSecsPrevious;

        // float storing milliseconds of current tap
        float mSecs;

        // number of seconds we should wait until restarting the BPM timer
        float restartTime = 2.5f;

        // Timer to track last time user clicked the tap button;
        Timer closeTimer;

        // Number used to debounce clicks, currently set at 200ms (300bpm)
        int debounceAmount = 300;

        public Form1()
        {
            InitializeComponent();

            // Make new timer, set closeTimer and start the "last time button was pressed" timer
            watch = new Stopwatch();
            closeTimer = new Timer();
            closeTimer.Interval = (10 * 1000);
            closeTimer.Tick += new System.EventHandler(CloseWindow);
            closeTimer.Start();
            this.ShowInTaskbar = false;
        }

        // Calls when Form1 is made visible
        private void Form1_Shown(Object sender, EventArgs e)
        {
            // Resets timers, counts and BPM label on form
            ResetTimer();

            // Set location of forum to bottom right of screen
            Rectangle workingArea = Screen.GetWorkingArea(this);
            this.Location = new Point(workingArea.Right - Size.Width,
                                      workingArea.Bottom - Size.Height);
            this.FormBorderStyle = FormBorderStyle.None;
        }

        // Calls when Form1 loses focus
        private void CloseWindow(Object sender, EventArgs e)
        {
            // Stop the watch
            watch.Stop();

            // Stop the timer checking for user activity
            closeTimer.Stop();

            // Close the form
            this.Close();
        }

        // Handles starting and stopping the timer when the form opens / closes
        private void ResetTimer()
        {
            // Reset the count, BPM label and mSecs
            count = 0;
            mSecsFirst = 0;
            mSecsPrevious = 0;
            mSecs = 0;
            bpmLabel.Text = "bpm:";
            watch.Stop();
            watch.Reset();
            watch.Start();
        }

        // When our Tap button is pressed
        private void tapButton_Click(object sender, EventArgs e)
        {
            // Reset the timer checking for user interaction
            closeTimer.Stop();
            closeTimer.Start();

            // Tap out the BPM
            TapBPM();
        }

        // Function to actually tap out the BPM
        void TapBPM()
        {
            // Get initial time at click
            mSecs = watch.ElapsedMilliseconds;

            // Check if our last tap was within the reset threshold or not
            if((mSecs - mSecsPrevious) > (1000 * restartTime))
            {
                // Reset the count
                count = 0;
            }

            // If we haven't clicked yet
            if (count == 0)
            {
                bpmLabel.Text = "bpm: First Tap";
                mSecsFirst = mSecs;
                count = 1;
            }
            else
            {
                if ((mSecs - mSecsPrevious) > debounceAmount)
                {
                    currentBPM = (60000 * count) / (mSecs - mSecsFirst);
                    bpmLabel.Text = "bpm: " + Math.Round(currentBPM).ToString();
                    count++;
                }
            }
            mSecsPrevious = mSecs;
        }
    }
}
