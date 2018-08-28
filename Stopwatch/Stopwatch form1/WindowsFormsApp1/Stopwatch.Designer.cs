namespace WindowsFormsApp1
{
    partial class Stopwatch
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Textbox_Stopwatch = new System.Windows.Forms.TextBox();
            this.Start_Button = new System.Windows.Forms.Button();
            this.Stop_Button = new System.Windows.Forms.Button();
            this.Reset_Button = new System.Windows.Forms.Button();
            this.save_Button = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.addTask = new System.Windows.Forms.Button();
            this.add_TaskText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Textbox_Stopwatch
            // 
            this.Textbox_Stopwatch.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Textbox_Stopwatch.Location = new System.Drawing.Point(74, 138);
            this.Textbox_Stopwatch.Name = "Textbox_Stopwatch";
            this.Textbox_Stopwatch.Size = new System.Drawing.Size(139, 20);
            this.Textbox_Stopwatch.TabIndex = 0;
            // 
            // Start_Button
            // 
            this.Start_Button.Location = new System.Drawing.Point(12, 174);
            this.Start_Button.Name = "Start_Button";
            this.Start_Button.Size = new System.Drawing.Size(75, 23);
            this.Start_Button.TabIndex = 1;
            this.Start_Button.Text = "Start";
            this.Start_Button.UseVisualStyleBackColor = true;
            this.Start_Button.Click += new System.EventHandler(this.Start_Button_Click);
            // 
            // Stop_Button
            // 
            this.Stop_Button.Location = new System.Drawing.Point(104, 174);
            this.Stop_Button.Name = "Stop_Button";
            this.Stop_Button.Size = new System.Drawing.Size(75, 23);
            this.Stop_Button.TabIndex = 2;
            this.Stop_Button.Text = "Stop";
            this.Stop_Button.UseVisualStyleBackColor = true;
            this.Stop_Button.Click += new System.EventHandler(this.Stop_Button_Click);
            // 
            // Reset_Button
            // 
            this.Reset_Button.Location = new System.Drawing.Point(197, 174);
            this.Reset_Button.Name = "Reset_Button";
            this.Reset_Button.Size = new System.Drawing.Size(75, 23);
            this.Reset_Button.TabIndex = 3;
            this.Reset_Button.Text = "Reset";
            this.Reset_Button.UseVisualStyleBackColor = true;
            this.Reset_Button.Click += new System.EventHandler(this.Reset_Button_Click);
            // 
            // save_Button
            // 
            this.save_Button.Location = new System.Drawing.Point(104, 203);
            this.save_Button.Name = "save_Button";
            this.save_Button.Size = new System.Drawing.Size(75, 23);
            this.save_Button.TabIndex = 4;
            this.save_Button.Text = "Save";
            this.save_Button.UseVisualStyleBackColor = true;
            this.save_Button.Click += new System.EventHandler(this.save_Button_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(74, 111);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(139, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // addTask
            // 
            this.addTask.Location = new System.Drawing.Point(104, 73);
            this.addTask.Name = "addTask";
            this.addTask.Size = new System.Drawing.Size(75, 23);
            this.addTask.TabIndex = 6;
            this.addTask.Text = "Add Task";
            this.addTask.UseVisualStyleBackColor = true;
            this.addTask.Click += new System.EventHandler(this.addTask_Click);
            // 
            // add_TaskText
            // 
            this.add_TaskText.Location = new System.Drawing.Point(12, 32);
            this.add_TaskText.Name = "add_TaskText";
            this.add_TaskText.Size = new System.Drawing.Size(260, 20);
            this.add_TaskText.TabIndex = 7;
            this.add_TaskText.Text = "New Task";
            this.add_TaskText.TextChanged += new System.EventHandler(this.add_TaskText_TextChanged);
            // 
            // Stopwatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.add_TaskText);
            this.Controls.Add(this.addTask);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.save_Button);
            this.Controls.Add(this.Reset_Button);
            this.Controls.Add(this.Stop_Button);
            this.Controls.Add(this.Start_Button);
            this.Controls.Add(this.Textbox_Stopwatch);
            this.Name = "Stopwatch";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox Textbox_Stopwatch;
        private System.Windows.Forms.Button Start_Button;
        private System.Windows.Forms.Button Stop_Button;
        private System.Windows.Forms.Button Reset_Button;
        private System.Windows.Forms.Button save_Button;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button addTask;
        private System.Windows.Forms.TextBox add_TaskText;
    }
}

