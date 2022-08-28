namespace Clock
{
    partial class form1
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
            this.timer = new System.Windows.Forms.Label();
            this.stopwatchMilisec = new System.Windows.Forms.Label();
            this.stopwatchSec = new System.Windows.Forms.Label();
            this.stopwatchMin = new System.Windows.Forms.Label();
            this.stopwatchHour = new System.Windows.Forms.Label();
            this.timerMS = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.swResetButton = new System.Windows.Forms.Button();
            this.swStartButton = new System.Windows.Forms.Button();
            this.swPauseButton = new System.Windows.Forms.Button();
            this.swContinueButton = new System.Windows.Forms.Button();
            this.swHistory = new System.Windows.Forms.Label();
            this.swRecordButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Font = new System.Drawing.Font("Segoe UI Black", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(187)));
            this.timer.ForeColor = System.Drawing.Color.DimGray;
            this.timer.Location = new System.Drawing.Point(12, 9);
            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(300, 72);
            this.timer.TabIndex = 0;
            this.timer.Text = "Stopwatch";
            this.timer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.timer.Click += new System.EventHandler(this.timer_Click);
            // 
            // stopwatchMilisec
            // 
            this.stopwatchMilisec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(178)))), ((int)(((byte)(153)))));
            this.stopwatchMilisec.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.stopwatchMilisec.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.stopwatchMilisec.Location = new System.Drawing.Point(256, 134);
            this.stopwatchMilisec.Name = "stopwatchMilisec";
            this.stopwatchMilisec.Size = new System.Drawing.Size(56, 56);
            this.stopwatchMilisec.TabIndex = 4;
            this.stopwatchMilisec.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.stopwatchMilisec.Click += new System.EventHandler(this.stopwatchMilisec_Click);
            // 
            // stopwatchSec
            // 
            this.stopwatchSec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(178)))), ((int)(((byte)(153)))));
            this.stopwatchSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.stopwatchSec.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.stopwatchSec.Location = new System.Drawing.Point(171, 126);
            this.stopwatchSec.Name = "stopwatchSec";
            this.stopwatchSec.Size = new System.Drawing.Size(100, 70);
            this.stopwatchSec.TabIndex = 5;
            this.stopwatchSec.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.stopwatchSec.Click += new System.EventHandler(this.stopwatchSec_Click);
            // 
            // stopwatchMin
            // 
            this.stopwatchMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(178)))), ((int)(((byte)(153)))));
            this.stopwatchMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.stopwatchMin.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.stopwatchMin.Location = new System.Drawing.Point(99, 126);
            this.stopwatchMin.Name = "stopwatchMin";
            this.stopwatchMin.Size = new System.Drawing.Size(84, 70);
            this.stopwatchMin.TabIndex = 6;
            this.stopwatchMin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.stopwatchMin.Click += new System.EventHandler(this.stopwatchMin_Click);
            // 
            // stopwatchHour
            // 
            this.stopwatchHour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(178)))), ((int)(((byte)(153)))));
            this.stopwatchHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.stopwatchHour.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.stopwatchHour.Location = new System.Drawing.Point(17, 125);
            this.stopwatchHour.Name = "stopwatchHour";
            this.stopwatchHour.Size = new System.Drawing.Size(81, 70);
            this.stopwatchHour.TabIndex = 7;
            this.stopwatchHour.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.stopwatchHour.Click += new System.EventHandler(this.stopwatchHour_Click);
            // 
            // timerMS
            // 
            this.timerMS.Interval = 1;
            this.timerMS.Tick += new System.EventHandler(this.timerMS_Tick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(178)))), ((int)(((byte)(153)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(240, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 35);
            this.label1.TabIndex = 11;
            this.label1.Text = ".";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(178)))), ((int)(((byte)(153)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(162, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 56);
            this.label2.TabIndex = 12;
            this.label2.Text = ":";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(178)))), ((int)(((byte)(153)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(79, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 56);
            this.label3.TabIndex = 13;
            this.label3.Text = ":";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // swResetButton
            // 
            this.swResetButton.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.swResetButton.Location = new System.Drawing.Point(26, 231);
            this.swResetButton.Name = "swResetButton";
            this.swResetButton.Size = new System.Drawing.Size(81, 32);
            this.swResetButton.TabIndex = 4;
            this.swResetButton.Text = "RESET";
            this.swResetButton.UseVisualStyleBackColor = true;
            this.swResetButton.Click += new System.EventHandler(this.swResetButton_Click);
            // 
            // swStartButton
            // 
            this.swStartButton.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.swStartButton.Location = new System.Drawing.Point(124, 231);
            this.swStartButton.Name = "swStartButton";
            this.swStartButton.Size = new System.Drawing.Size(81, 32);
            this.swStartButton.TabIndex = 0;
            this.swStartButton.Text = "START";
            this.swStartButton.UseVisualStyleBackColor = true;
            this.swStartButton.Click += new System.EventHandler(this.swStartButton_Click);
            // 
            // swPauseButton
            // 
            this.swPauseButton.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.swPauseButton.Location = new System.Drawing.Point(220, 231);
            this.swPauseButton.Name = "swPauseButton";
            this.swPauseButton.Size = new System.Drawing.Size(81, 32);
            this.swPauseButton.TabIndex = 2;
            this.swPauseButton.Text = "PAUSE";
            this.swPauseButton.UseVisualStyleBackColor = true;
            this.swPauseButton.Click += new System.EventHandler(this.swPauseButton_Click);
            // 
            // swContinueButton
            // 
            this.swContinueButton.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.swContinueButton.Location = new System.Drawing.Point(108, 269);
            this.swContinueButton.Name = "swContinueButton";
            this.swContinueButton.Size = new System.Drawing.Size(114, 32);
            this.swContinueButton.TabIndex = 3;
            this.swContinueButton.Text = "CONTINUE";
            this.swContinueButton.UseVisualStyleBackColor = true;
            this.swContinueButton.Click += new System.EventHandler(this.swContinueButton_Click);
            // 
            // swHistory
            // 
            this.swHistory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.swHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.swHistory.Location = new System.Drawing.Point(26, 392);
            this.swHistory.Name = "swHistory";
            this.swHistory.Size = new System.Drawing.Size(275, 35);
            this.swHistory.TabIndex = 18;
            this.swHistory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.swHistory.Click += new System.EventHandler(this.swHistory_Click);
            // 
            // swRecordButton
            // 
            this.swRecordButton.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.swRecordButton.Location = new System.Drawing.Point(108, 357);
            this.swRecordButton.Name = "swRecordButton";
            this.swRecordButton.Size = new System.Drawing.Size(114, 32);
            this.swRecordButton.TabIndex = 1;
            this.swRecordButton.Text = "RECORD";
            this.swRecordButton.UseVisualStyleBackColor = true;
            this.swRecordButton.Click += new System.EventHandler(this.swRecordButton_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(178)))), ((int)(((byte)(153)))));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(178)))), ((int)(((byte)(153)))));
            this.label4.Location = new System.Drawing.Point(12, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(309, 88);
            this.label4.TabIndex = 19;
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(334, 486);
            this.Controls.Add(this.swRecordButton);
            this.Controls.Add(this.stopwatchMilisec);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.swHistory);
            this.Controls.Add(this.swContinueButton);
            this.Controls.Add(this.swPauseButton);
            this.Controls.Add(this.swStartButton);
            this.Controls.Add(this.swResetButton);
            this.Controls.Add(this.stopwatchHour);
            this.Controls.Add(this.stopwatchMin);
            this.Controls.Add(this.stopwatchSec);
            this.Controls.Add(this.timer);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "form1";
            this.Text = "Clock";
            this.Load += new System.EventHandler(this.form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label timer;
        private System.Windows.Forms.Label stopwatchMilisec;
        private System.Windows.Forms.Label stopwatchSec;
        private System.Windows.Forms.Label stopwatchMin;
        private System.Windows.Forms.Label stopwatchHour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button swResetButton;
        private System.Windows.Forms.Button swStartButton;
        private System.Windows.Forms.Button swPauseButton;
        private System.Windows.Forms.Timer timerMS;
        private System.Windows.Forms.Button swContinueButton;
        private System.Windows.Forms.Label swHistory;
        private System.Windows.Forms.Button swRecordButton;
        private System.Windows.Forms.Label label4;
    }
}

