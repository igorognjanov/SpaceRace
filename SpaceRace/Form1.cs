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
        public Form1()
        {
            InitializeComponent();
            Scene = new Scene(Width, Height);
            Invalidate();
            DoubleBuffered = true;
            timerGeneratingBalls.Start();
            timerMovingBalls.Start();
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
                Scene.MoveLUp();
            else if (e.KeyCode == Keys.Down)
                Scene.MoveRDown();
            else if (e.KeyCode == Keys.Left)
                Scene.MoveRLeft();
            else if (e.KeyCode == Keys.Right)
                Scene.MoveRRight();
            else if (e.KeyCode == Keys.Up)
                Scene.MoveRUp();
            Invalidate();
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
    }
}
