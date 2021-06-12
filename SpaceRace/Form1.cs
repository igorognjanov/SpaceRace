using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceRace
{
    public partial class Form1 : Form
    {
        public Scene Scene { get; set; }

        int timeLeft;
        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            lblOpenGame.BackColor = lblSaveGame.BackColor = Color.Transparent;
            lblTime.BackColor = Color.Transparent;
            Init();
        }
        public void Init()
        {
            Scene = new Scene(Width, Height);
            Invalidate();
            timerGeneratingBalls.Start();
            timerMovingBalls.Start();
            timeLeft = 119;
            ProgressBarTimer.Start();
            progressBar.Value = 120;
            lblPointsLeft.Text = lblPointsRight.Text = "0";
            lblTime.Text = "2:00";
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Scene.Draw(e.Graphics);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S)
                Scene.MoveLDown();
            else if (e.KeyCode == Keys.A)
                Scene.MoveLLeft();
            else if (e.KeyCode == Keys.D)
                Scene.MoveLRight();
            else if (e.KeyCode == Keys.W)
            {
                if (!Scene.MoveLUp())
                {
                    Scene.PlayerLeft.AddPoint();
                    Scene.PlayerLeft.InitCenter();
                }
            }
            else if (e.KeyCode == Keys.Down)
                Scene.MoveRDown();
            else if (e.KeyCode == Keys.Left)
                Scene.MoveRLeft();
            else if (e.KeyCode == Keys.Right)
                Scene.MoveRRight();
            else if (e.KeyCode == Keys.Up)
            {
                if (!Scene.MoveRUp())
                {
                    Scene.PlayerRight.AddPoint();
                    Scene.PlayerRight.InitCenter();
                }
            }
            UpdatePoints();
            Invalidate();
        }

        public void UpdatePoints()
        {
            lblPointsLeft.Text = Scene.PlayerLeft.Points.ToString();
            lblPointsRight.Text = Scene.PlayerRight.Points.ToString();
        }

        private void timerMovingBalls_Tick(object sender, EventArgs e)
        {
            Scene.MoveBalls();
            if (Scene.CheckLeftIfTouching())
                Scene.PlayerLeft.InitCenter();
            if (Scene.CheckRightIfTouching())
                Scene.PlayerRight.InitCenter();
            Invalidate();
        }

        private void timerGeneratingBalls_Tick(object sender, EventArgs e)
        {
            timerGeneratingBalls.Interval = new Random().Next(120, 300);
            Scene.GenerateBall();
            Invalidate();
        }

        private void timerProgressBar_Tick(object sender, EventArgs e)
        {
            if (timeLeft >= 0)
            {
                this.progressBar.Increment(-1);
                lblTime.Text = String.Format("{0}:{1:00}", timeLeft / 60, timeLeft % 60);
                timeLeft -= 1;
            }
            else
            {
                timerMovingBalls.Stop();
                ProgressBarTimer.Stop();

                //DialogResult dr = MessageBox.Show(Scene.GetWinner() + " Дали сакате нова игра?", "GAME OVER", MessageBoxButtons.YesNo);
                if (MessageBox.Show(Scene.GetWinner() + " Дали сакате нова игра?", "GAME OVER", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    Init();
                else
                    this.Close();
            }
        }

    }
}
