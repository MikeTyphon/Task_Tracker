using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private short _hours, _minutes, _seconds, _centiseconds;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            IncreaseCentiseconds();
            Showtime();

        }
        private void IncreaseCentiseconds()
        {
            if (_centiseconds == 99)
            {
                _centiseconds = 0;
                IncreaseSeconds();
            }
            else
            {
                _centiseconds++;
            }
        }
        private void IncreaseSeconds()
        {
            if(_seconds ==59)
            {
                _seconds = 0;
                IncreaseMinutes();
            }
            else
            {
                _seconds++;
            }
        }
        private void IncreaseMinutes()
        {
            if(_minutes == 59)
            {
                _minutes = 0;
                IncreaseHours();
            }
            else
            {
                _minutes++;
            }
        }

        private void IncreaseHours()
        {
            _hours++;
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            timer1.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            timer1.Enabled = false;
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            _hours = 0;
            _minutes = 0;
            _seconds = 0;
            _centiseconds = 0;
            Showtime();

        }
        private void Showtime()
        {
            hoursText.Text = _hours.ToString("00");
            minutesText.Text = _minutes.ToString("00");
            secondsText.Text = _seconds.ToString("00");
            centiSecondsText.Text = _centiseconds.ToString("00");
        }
    }
}
