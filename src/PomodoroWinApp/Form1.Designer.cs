
namespace PomodoroWinApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Start = new System.Windows.Forms.Button();
            this.Settings = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.lblPomodoro = new System.Windows.Forms.Label();
            this.lblCompletedCount = new System.Windows.Forms.Label();
            this.lblStatusText = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Log = new System.Windows.Forms.Button();
            this.Contract = new System.Windows.Forms.Button();
            this.checkBoxEnableSounds = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownBreakByRound = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownPomodorosByRound = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownBreakInterval = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownWorkInterval = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBreakByRound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPomodorosByRound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBreakInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWorkInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.LightCoral;
            this.Start.Location = new System.Drawing.Point(12, 287);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(126, 37);
            this.Start.TabIndex = 9;
            this.Start.Text = "Start Pomodoro";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Settings
            // 
            this.Settings.Location = new System.Drawing.Point(436, 287);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(126, 37);
            this.Settings.TabIndex = 12;
            this.Settings.Text = "Settings";
            this.Settings.UseVisualStyleBackColor = true;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(278, 287);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(126, 37);
            this.Reset.TabIndex = 11;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // lblPomodoro
            // 
            this.lblPomodoro.AutoSize = true;
            this.lblPomodoro.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblPomodoro.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblPomodoro.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblPomodoro.Location = new System.Drawing.Point(290, 207);
            this.lblPomodoro.Name = "lblPomodoro";
            this.lblPomodoro.Size = new System.Drawing.Size(0, 31);
            this.lblPomodoro.TabIndex = 16;
            // 
            // lblCompletedCount
            // 
            this.lblCompletedCount.AutoSize = true;
            this.lblCompletedCount.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblCompletedCount.Location = new System.Drawing.Point(290, 151);
            this.lblCompletedCount.Name = "lblCompletedCount";
            this.lblCompletedCount.Size = new System.Drawing.Size(0, 31);
            this.lblCompletedCount.TabIndex = 15;
            // 
            // lblStatusText
            // 
            this.lblStatusText.AutoSize = true;
            this.lblStatusText.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblStatusText.Location = new System.Drawing.Point(290, 88);
            this.lblStatusText.Name = "lblStatusText";
            this.lblStatusText.Size = new System.Drawing.Size(194, 38);
            this.lblStatusText.TabIndex = 14;
            this.lblStatusText.Text = "- Not Started -";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTimer.Location = new System.Drawing.Point(290, 12);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(137, 59);
            this.lblTimer.TabIndex = 13;
            this.lblTimer.Text = "00:00";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.Log);
            this.panel1.Controls.Add(this.Contract);
            this.panel1.Controls.Add(this.checkBoxEnableSounds);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.numericUpDownBreakByRound);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.numericUpDownPomodorosByRound);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.numericUpDownBreakInterval);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.numericUpDownWorkInterval);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(601, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 325);
            this.panel1.TabIndex = 17;
            // 
            // Log
            // 
            this.Log.BackColor = System.Drawing.Color.White;
            this.Log.Location = new System.Drawing.Point(266, 13);
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(50, 29);
            this.Log.TabIndex = 28;
            this.Log.Text = "Log";
            this.Log.UseVisualStyleBackColor = false;
            this.Log.Click += new System.EventHandler(this.Log_Click);
            // 
            // Contract
            // 
            this.Contract.BackColor = System.Drawing.Color.White;
            this.Contract.Location = new System.Drawing.Point(22, 275);
            this.Contract.Name = "Contract";
            this.Contract.Size = new System.Drawing.Size(126, 37);
            this.Contract.TabIndex = 27;
            this.Contract.Text = "< Contract";
            this.Contract.UseVisualStyleBackColor = false;
            this.Contract.Click += new System.EventHandler(this.Contract_Click);
            // 
            // checkBoxEnableSounds
            // 
            this.checkBoxEnableSounds.AutoSize = true;
            this.checkBoxEnableSounds.Checked = true;
            this.checkBoxEnableSounds.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEnableSounds.Location = new System.Drawing.Point(190, 282);
            this.checkBoxEnableSounds.Name = "checkBoxEnableSounds";
            this.checkBoxEnableSounds.Size = new System.Drawing.Size(126, 24);
            this.checkBoxEnableSounds.TabIndex = 26;
            this.checkBoxEnableSounds.Text = "Enable sounds";
            this.checkBoxEnableSounds.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(245, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "minute(s)";
            // 
            // numericUpDownBreakByRound
            // 
            this.numericUpDownBreakByRound.Location = new System.Drawing.Point(173, 207);
            this.numericUpDownBreakByRound.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDownBreakByRound.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownBreakByRound.Name = "numericUpDownBreakByRound";
            this.numericUpDownBreakByRound.Size = new System.Drawing.Size(66, 27);
            this.numericUpDownBreakByRound.TabIndex = 24;
            this.numericUpDownBreakByRound.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "Long break duration:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(245, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "minute(s)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(245, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "minute(s)";
            // 
            // numericUpDownPomodorosByRound
            // 
            this.numericUpDownPomodorosByRound.Location = new System.Drawing.Point(173, 160);
            this.numericUpDownPomodorosByRound.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownPomodorosByRound.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPomodorosByRound.Name = "numericUpDownPomodorosByRound";
            this.numericUpDownPomodorosByRound.Size = new System.Drawing.Size(66, 27);
            this.numericUpDownPomodorosByRound.TabIndex = 20;
            this.numericUpDownPomodorosByRound.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Pomodoros by round:";
            // 
            // numericUpDownBreakInterval
            // 
            this.numericUpDownBreakInterval.Location = new System.Drawing.Point(173, 112);
            this.numericUpDownBreakInterval.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDownBreakInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownBreakInterval.Name = "numericUpDownBreakInterval";
            this.numericUpDownBreakInterval.Size = new System.Drawing.Size(66, 27);
            this.numericUpDownBreakInterval.TabIndex = 18;
            this.numericUpDownBreakInterval.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Break duration:";
            // 
            // numericUpDownWorkInterval
            // 
            this.numericUpDownWorkInterval.Location = new System.Drawing.Point(173, 66);
            this.numericUpDownWorkInterval.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDownWorkInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownWorkInterval.Name = "numericUpDownWorkInterval";
            this.numericUpDownWorkInterval.Size = new System.Drawing.Size(66, 27);
            this.numericUpDownWorkInterval.TabIndex = 16;
            this.numericUpDownWorkInterval.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Pomodoro duration:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(22, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "Settings";
            // 
            // textBoxLog
            // 
            this.textBoxLog.Location = new System.Drawing.Point(12, 357);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ReadOnly = true;
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLog.Size = new System.Drawing.Size(922, 279);
            this.textBoxLog.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(951, 649);
            this.Controls.Add(this.textBoxLog);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblPomodoro);
            this.Controls.Add(this.lblCompletedCount);
            this.Controls.Add(this.lblStatusText);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Podomoro";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBreakByRound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPomodorosByRound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBreakInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWorkInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Settings;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Label lblPomodoro;
        private System.Windows.Forms.Label lblCompletedCount;
        private System.Windows.Forms.Label lblStatusText;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Contract;
        private System.Windows.Forms.CheckBox checkBoxEnableSounds;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDownBreakByRound;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownPomodorosByRound;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownBreakInterval;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownWorkInterval;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Log;
        private System.Windows.Forms.TextBox textBoxLog;
    }
}

