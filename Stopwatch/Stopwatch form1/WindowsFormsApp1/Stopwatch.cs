using System;
using System.Collections;
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
    public partial class Stopwatch : Form
        //this creates the stopwatch for time tracking. 
    {
        Hashtable taskHash = new Hashtable();

        System.Diagnostics.Stopwatch stopwatch;
        List<string> taskList = new List<string>();
        
        

        public Stopwatch()//stopwatch function
        { 
            //functions that create and start the stopwatch
            InitializeComponent();
            StartUp();//function for creating initial conditions for stopwatch
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void StartUp()
        {
            //startup function for stopwatch
            Textbox_Stopwatch.Text = "00:00:00:00"; //sets initial stopwatch text in textbox
            stopwatch = new System.Diagnostics.Stopwatch();//creates a new stopwatch 
            //stopwatch.Start();
            timer1.Enabled = false; //this means the ticker will not be running at startup
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
             Textbox_Stopwatch.Text = stopwatch.Elapsed.ToString(); //sends the time elapsed from the diagnostics stopwatch to a string displayed in the box
        }

        private void Start_Button_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true; //begins ticker
            stopwatch.Start(); //runs stopwatch start 
        }

        private void Stop_Button_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false; //stops ticker running
            stopwatch.Stop(); //stops stopwatch from tracking time elapsed
        }

        private void Reset_Button_Click(object sender, EventArgs e) //resets stopwatch, ticker, and string displayed in timer box to initial conditions
        {
            stopwatch.Reset();
            timer1.Enabled = false;
            Textbox_Stopwatch.Text = "00:00:00:00";
        }

        public void save_Button_Click(object sender, EventArgs e) //saves current state of stopwatch and task being tracked
        {
            //Console.WriteLine(stopwatch.Elapsed.ToString());
            //Console.WriteLine(comboBox1.Text);

            string taskKey = (comboBox1.Text + DateTime.Now.ToString("hh:mm:ss t"));
            string timeElapsed = stopwatch.Elapsed.ToString();
            
         
            taskHash.Add(taskKey, timeElapsed);

            Console.WriteLine("data added to hashtable");
            
            foreach(string Key in taskHash.Keys)
            {
                Console.WriteLine(Key);
            }


            timer1.Enabled = false;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }



        public void add_TaskText_TextChanged(object sender, EventArgs e)
        {
            
        }
        public void addTask_Click(object sender, EventArgs e) //adds current task written in new task box to combobox
        {
            Console.WriteLine(add_TaskText.Text);
            taskList.Add(add_TaskText.Text);
            Console.WriteLine("*List*");
            taskList.ForEach(Console.WriteLine);
            Console.WriteLine("*Endlist*");
            comboBox1.Items.Add(add_TaskText.Text);

        }

    }
}