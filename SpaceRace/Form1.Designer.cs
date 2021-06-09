
namespace SpaceRace
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
            this.timerMovingBalls = new System.Windows.Forms.Timer(this.components);
            this.timerGeneratingBalls = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.ProgressBarTimer = new System.Windows.Forms.Timer(this.components);
            this.tbTimer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // timerMovingBalls
            // 
            this.timerMovingBalls.Interval = 1;
            this.timerMovingBalls.Tick += new System.EventHandler(this.timerMovingBalls_Tick);
            // 
            // timerGeneratingBalls
            // 
            this.timerGeneratingBalls.Interval = 1000;
            this.timerGeneratingBalls.Tick += new System.EventHandler(this.timerGeneratingBalls_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.Black;
            this.progressBar1.Enabled = false;
            this.progressBar1.Location = new System.Drawing.Point(-1, 507);
            this.progressBar1.Maximum = 120;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(767, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // ProgressBarTimer
            // 
            this.ProgressBarTimer.Interval = 1000;
            this.ProgressBarTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tbTimer
            // 
            this.tbTimer.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tbTimer.BackColor = System.Drawing.Color.Black;
            this.tbTimer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTimer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbTimer.Enabled = false;
            this.tbTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTimer.ForeColor = System.Drawing.Color.White;
            this.tbTimer.Location = new System.Drawing.Point(331, 0);
            this.tbTimer.Margin = new System.Windows.Forms.Padding(0);
            this.tbTimer.Name = "tbTimer";
            this.tbTimer.Size = new System.Drawing.Size(100, 54);
            this.tbTimer.TabIndex = 1;
            this.tbTimer.Text = "2:00";
            this.tbTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(762, 530);
            this.Controls.Add(this.tbTimer);
            this.Controls.Add(this.progressBar1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerMovingBalls;
        private System.Windows.Forms.Timer timerGeneratingBalls;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer ProgressBarTimer;
        private System.Windows.Forms.TextBox tbTimer;
    }
}

