﻿namespace Shortcuts
{
    partial class frmPomodoroTimer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPomodoroTimer));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblRemainingTime = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnLongBreak = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnShortBreak = new System.Windows.Forms.Button();
            this.btnPomodoro = new System.Windows.Forms.Button();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.lblPomoCount = new System.Windows.Forms.Label();
            this.txtBlockNote = new System.Windows.Forms.TextBox();
            this.cbBlockGroup = new System.Windows.Forms.ComboBox();
            this.sevenSegmentArray1 = new Shortcuts.SevenSegmentArray();
            this.sevenSegmentArray2 = new Shortcuts.SevenSegmentArray();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblRemainingTime
            // 
            this.lblRemainingTime.AutoSize = true;
            this.lblRemainingTime.Font = new System.Drawing.Font("TR Arial Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRemainingTime.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblRemainingTime.Location = new System.Drawing.Point(587, 77);
            this.lblRemainingTime.Name = "lblRemainingTime";
            this.lblRemainingTime.Size = new System.Drawing.Size(48, 18);
            this.lblRemainingTime.TabIndex = 1;
            this.lblRemainingTime.Text = "00:00";
            this.lblRemainingTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Linen;
            this.btnReset.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReset.Location = new System.Drawing.Point(408, 396);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(121, 50);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.Tomato;
            this.btnPause.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPause.ForeColor = System.Drawing.Color.White;
            this.btnPause.Location = new System.Drawing.Point(281, 396);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(121, 50);
            this.btnPause.TabIndex = 0;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnLongBreak
            // 
            this.btnLongBreak.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLongBreak.Location = new System.Drawing.Point(445, 26);
            this.btnLongBreak.Name = "btnLongBreak";
            this.btnLongBreak.Size = new System.Drawing.Size(190, 36);
            this.btnLongBreak.TabIndex = 0;
            this.btnLongBreak.Text = "Long Break";
            this.btnLongBreak.UseVisualStyleBackColor = true;
            this.btnLongBreak.Click += new System.EventHandler(this.btnLongBreak_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.OliveDrab;
            this.btnStart.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(154, 396);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(121, 50);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnShortBreak
            // 
            this.btnShortBreak.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnShortBreak.Location = new System.Drawing.Point(249, 26);
            this.btnShortBreak.Name = "btnShortBreak";
            this.btnShortBreak.Size = new System.Drawing.Size(190, 36);
            this.btnShortBreak.TabIndex = 0;
            this.btnShortBreak.Text = "Short Break";
            this.btnShortBreak.UseVisualStyleBackColor = true;
            this.btnShortBreak.Click += new System.EventHandler(this.btnShortBreak_Click);
            // 
            // btnPomodoro
            // 
            this.btnPomodoro.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPomodoro.Location = new System.Drawing.Point(53, 26);
            this.btnPomodoro.Name = "btnPomodoro";
            this.btnPomodoro.Size = new System.Drawing.Size(190, 36);
            this.btnPomodoro.TabIndex = 0;
            this.btnPomodoro.Text = "Pomodoro";
            this.btnPomodoro.UseVisualStyleBackColor = true;
            this.btnPomodoro.Click += new System.EventHandler(this.btnPomodoro_Click);
            // 
            // picClose
            // 
            this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClose.Image = global::Shortcuts.Properties.Resources.picClose;
            this.picClose.Location = new System.Drawing.Point(630, 396);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(52, 50);
            this.picClose.TabIndex = 2;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(27, 411);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 3;
            this.btnTest.Text = "test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Visible = false;
            this.btnTest.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblPomoCount
            // 
            this.lblPomoCount.AutoSize = true;
            this.lblPomoCount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPomoCount.Location = new System.Drawing.Point(166, 347);
            this.lblPomoCount.Name = "lblPomoCount";
            this.lblPomoCount.Size = new System.Drawing.Size(22, 21);
            this.lblPomoCount.TabIndex = 4;
            this.lblPomoCount.Text = "...";
            this.lblPomoCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBlockNote
            // 
            this.txtBlockNote.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBlockNote.Location = new System.Drawing.Point(53, 104);
            this.txtBlockNote.Multiline = true;
            this.txtBlockNote.Name = "txtBlockNote";
            this.txtBlockNote.Size = new System.Drawing.Size(582, 72);
            this.txtBlockNote.TabIndex = 5;
            this.txtBlockNote.Text = "ne yaptın?";
            // 
            // cbBlockGroup
            // 
            this.cbBlockGroup.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbBlockGroup.FormattingEnabled = true;
            this.cbBlockGroup.Items.AddRange(new object[] {
            "GENEL",
            "TeklifTakip",
            "Shortcuts",
            "Kinect",
            "ImageProcessing"});
            this.cbBlockGroup.Location = new System.Drawing.Point(53, 77);
            this.cbBlockGroup.Name = "cbBlockGroup";
            this.cbBlockGroup.Size = new System.Drawing.Size(121, 23);
            this.cbBlockGroup.TabIndex = 6;
            this.cbBlockGroup.Text = "GENEL";
            // 
            // sevenSegmentArray1
            // 
            this.sevenSegmentArray1.ArrayCount = 2;
            this.sevenSegmentArray1.ColorBackground = System.Drawing.Color.White;
            this.sevenSegmentArray1.ColorDark = System.Drawing.Color.White;
            this.sevenSegmentArray1.ColorLight = System.Drawing.Color.Blue;
            this.sevenSegmentArray1.DecimalShow = true;
            this.sevenSegmentArray1.ElementPadding = new System.Windows.Forms.Padding(4);
            this.sevenSegmentArray1.ElementWidth = 10;
            this.sevenSegmentArray1.ItalicFactor = 0F;
            this.sevenSegmentArray1.Location = new System.Drawing.Point(148, 182);
            this.sevenSegmentArray1.Name = "sevenSegmentArray1";
            this.sevenSegmentArray1.Size = new System.Drawing.Size(195, 145);
            this.sevenSegmentArray1.TabIndex = 7;
            this.sevenSegmentArray1.TabStop = false;
            this.sevenSegmentArray1.Value = "0000";
            // 
            // sevenSegmentArray2
            // 
            this.sevenSegmentArray2.ArrayCount = 2;
            this.sevenSegmentArray2.ColorBackground = System.Drawing.Color.White;
            this.sevenSegmentArray2.ColorDark = System.Drawing.Color.White;
            this.sevenSegmentArray2.ColorLight = System.Drawing.Color.RoyalBlue;
            this.sevenSegmentArray2.DecimalShow = true;
            this.sevenSegmentArray2.ElementPadding = new System.Windows.Forms.Padding(4);
            this.sevenSegmentArray2.ElementWidth = 10;
            this.sevenSegmentArray2.ItalicFactor = 0F;
            this.sevenSegmentArray2.Location = new System.Drawing.Point(374, 182);
            this.sevenSegmentArray2.Name = "sevenSegmentArray2";
            this.sevenSegmentArray2.Size = new System.Drawing.Size(195, 145);
            this.sevenSegmentArray2.TabIndex = 7;
            this.sevenSegmentArray2.TabStop = false;
            this.sevenSegmentArray2.Value = "0000";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotal.Location = new System.Drawing.Point(465, 347);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(22, 21);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "...";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmPomodoroTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(694, 458);
            this.Controls.Add(this.sevenSegmentArray2);
            this.Controls.Add(this.sevenSegmentArray1);
            this.Controls.Add(this.cbBlockGroup);
            this.Controls.Add(this.txtBlockNote);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblPomoCount);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.picClose);
            this.Controls.Add(this.lblRemainingTime);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnLongBreak);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnShortBreak);
            this.Controls.Add(this.btnPomodoro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPomodoroTimer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pomodoro Timer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPomodoroTimer_FormClosing);
            this.Load += new System.EventHandler(this.frmPomodoroTimer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPomodoro;
        private System.Windows.Forms.Button btnShortBreak;
        private System.Windows.Forms.Button btnLongBreak;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblRemainingTime;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Label lblPomoCount;
        private System.Windows.Forms.TextBox txtBlockNote;
        private System.Windows.Forms.ComboBox cbBlockGroup;
        private SevenSegmentArray sevenSegmentArray1;
        private SevenSegmentArray sevenSegmentArray2;
        private System.Windows.Forms.Label lblTotal;
    }
}