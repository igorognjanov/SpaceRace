using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceRace
{
    abstract public class Player
    {
        public int MoveIndex = 15;
        public Ball Ball { get; set; }
        public Point Center { set; get; }
        public int Points { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Radius = 16;
        public Player(int Width, int Height)
        {
            this.Width = Width;
            this.Height = Height;
        }
        public void Draw(Graphics g)
        {
            Pen Pen = new Pen(Color.White, 3);
            g.DrawEllipse(Pen, Center.X - Radius, Center.Y - Radius, Radius * 2, Radius * 2);
            Pen.Dispose();
        }
        abstract public bool MoveLeft();
        abstract public bool MoveRight();
        abstract public bool MoveUp();
        abstract public void InitCenter();
        public bool MoveDown()
        {
            if (Center.Y + 80 + MoveIndex >= Height)
            {
                return false;
            }
            Center = new Point(Center.X, Center.Y + MoveIndex);
            UpdateBall();
            return true;
        }
        public void UpdateBall()
        {
            Ball = new Ball(Center.X, Center.Y, Radius);
        }

        public bool IsTouching(Ball Ball)
        {
            return this.Ball.IsTouching(Ball);
        }
    }
}
