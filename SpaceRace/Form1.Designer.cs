
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
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.ProgressBarTimer = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.lblPointsLeft = new System.Windows.Forms.Label();
            this.lblPointsRight = new System.Windows.Forms.Label();
            this.lblSaveGame = new System.Windows.Forms.Label();
            this.lblOpenGame = new System.Windows.Forms.Label();
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
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.Black;
            this.progressBar.Enabled = false;
            this.progressBar.Location = new System.Drawing.Point(-1, 624);
            this.progressBar.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar.Maximum = 120;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(1023, 28);
            this.progressBar.TabIndex = 0;
            // 
            // ProgressBarTimer
            // 
            this.ProgressBarTimer.Interval = 1000;
            this.ProgressBarTimer.Tick += new System.EventHandler(this.timerProgressBar_Tick);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblTime.Location = new System.Drawing.Point(455, 9);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(118, 55);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "2:00";
            // 
            // lblPointsLeft
            // 
            this.lblPointsLeft.AutoSize = true;
            this.lblPointsLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPointsLeft.ForeColor = System.Drawing.Color.White;
            this.lblPointsLeft.Location = new System.Drawing.Point(12, 558);
            this.lblPointsLeft.Name = "lblPointsLeft";
            this.lblPointsLeft.Size = new System.Drawing.Size(46, 51);
            this.lblPointsLeft.TabIndex = 2;
            this.lblPointsLeft.Text = "0";
            // 
            // lblPointsRight
            // 
            this.lblPointsRight.AutoSize = true;
            this.lblPointsRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPointsRight.ForeColor = System.Drawing.Color.White;
            this.lblPointsRight.Location = new System.Drawing.Point(957, 558);
            this.lblPointsRight.Name = "lblPointsRight";
            this.lblPointsRight.Size = new System.Drawing.Size(46, 51);
            this.lblPointsRight.TabIndex = 3;
            this.lblPointsRight.Text = "0";
            // 
            // lblSaveGame
            // 
            this.lblSaveGame.AutoSize = true;
            this.lblSaveGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaveGame.ForeColor = System.Drawing.Color.White;
            this.lblSaveGame.Location = new System.Drawing.Point(429, 576);
            this.lblSaveGame.Name = "lblSaveGame";
            this.lblSaveGame.Size = new System.Drawing.Size(67, 29);
            this.lblSaveGame.TabIndex = 4;
            this.lblSaveGame.Text = "Save";
            this.lblSaveGame.Click += new System.EventHandler(this.lblSaveGame_Click);
            // 
            // lblOpenGame
            // 
            this.lblOpenGame.AutoSize = true;
            this.lblOpenGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpenGame.ForeColor = System.Drawing.Color.White;
            this.lblOpenGame.Location = new System.Drawing.Point(536, 576);
            this.lblOpenGame.Name = "lblOpenGame";
            this.lblOpenGame.Size = new System.Drawing.Size(73, 29);
            this.lblOpenGame.TabIndex = 5;
            this.lblOpenGame.Text = "Open";
            this.lblOpenGame.Click += new System.EventHandler(this.lblOpenGame_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1016, 652);
            this.Controls.Add(this.lblOpenGame);
            this.Controls.Add(this.lblSaveGame);
            this.Controls.Add(this.lblPointsRight);
            this.Controls.Add(this.lblPointsLeft);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.progressBar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Timer ProgressBarTimer;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblPointsLeft;
        private System.Windows.Forms.Label lblPointsRight;
        private System.Windows.Forms.Label lblSaveGame;
        private System.Windows.Forms.Label lblOpenGame;
    }
}

