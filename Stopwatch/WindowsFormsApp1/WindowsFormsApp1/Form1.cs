using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        Stopwatch stopwatch;

        public Form1()
        {
            InitializeComponent();
            StartUp();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void StartUp()
        {
            Textbox_Stopwatch.Text = "00 : 00 :00:00";
            stopwatch = new Stopwatch();
            //stopwatch.Start();
            timer1.Enabled = false;


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Textbox_Stopwatch.Text = stopwatch.Elapsed.ToString();
        }

        private void Start_Button_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            stopwatch.Start();
        }

        private void Stop_Button_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            stopwatch.Stop();
        }

        private void Reset_Button_Click(object sender, EventArgs e)
        {
            stopwatch.Reset();
            timer1.Enabled = false;
            Textbox_Stopwatch.Text = "00:00:00:00";
        }
    }
}
