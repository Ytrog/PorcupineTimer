namespace PorcupineTimer
{
    partial class Form1
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
            this.tbTime = new System.Windows.Forms.TrackBar();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblHours = new System.Windows.Forms.Label();
            this.pbStatus = new System.Windows.Forms.ProgressBar();
            this.tickTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tbTime)).BeginInit();
            this.SuspendLayout();
            // 
            // tbTime
            // 
            this.tbTime.LargeChange = 3;
            this.tbTime.Location = new System.Drawing.Point(74, 13);
            this.tbTime.Name = "tbTime";
            this.tbTime.Size = new System.Drawing.Size(320, 45);
            this.tbTime.TabIndex = 0;
            this.tbTime.Value = 3;
            this.tbTime.ValueChanged += new System.EventHandler(this.tbTime_ValueChanged);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(400, 13);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start timer";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Location = new System.Drawing.Point(13, 12);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(55, 13);
            this.lblHours.TabIndex = 2;
            this.lblHours.Text = "Hours: {0}";
            // 
            // pbStatus
            // 
            this.pbStatus.Location = new System.Drawing.Point(16, 33);
            this.pbStatus.Name = "pbStatus";
            this.pbStatus.Size = new System.Drawing.Size(356, 23);
            this.pbStatus.Step = 1;
            this.pbStatus.TabIndex = 3;
            this.pbStatus.Visible = false;
            // 
            // tickTimer
            // 
            this.tickTimer.Interval = 600000;
            this.tickTimer.Tick += new System.EventHandler(this.tickTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 70);
            this.Controls.Add(this.pbStatus);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.tbTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Porcupine Timer";
            ((System.ComponentModel.ISupportInitialize)(this.tbTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tbTime;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.ProgressBar pbStatus;
        private System.Windows.Forms.Timer tickTimer;
    }
}

