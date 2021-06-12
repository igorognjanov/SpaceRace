using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceRace
{
    [Serializable]
    public class Ball
    {
        public Point Center { get; set; }
        public int Radius { get; set; }
        public Ball(int X, int Y, int Radius)
        {
            Center = new Point(X, Y);
            this.Radius = Radius;
        }
        public void Draw(Graphics g)
        {
            Brush Brush = new SolidBrush(Color.White);
            g.FillEllipse(Brush, Center.X - Radius, Center.Y - Radius, Radius * 2, Radius * 2);
            Brush.Dispose();
        }
        public void MoveLeft()
        {
            int MoveIndex = 2;
            Center = new Point(Center.X - MoveIndex, Center.Y);
        }
        public void MoveRight()
        {
            int MoveIndex = 2;
            Center = new Point(Center.X + MoveIndex, Center.Y);
        }
        public bool IsTouching(Ball that)
        {
            double d = Math.Sqrt(Math.Pow(Center.X - that.Center.X, 2) + Math.Pow(Center.Y - that.Center.Y, 2));
            return d <= Radius * 2;
        }
    }
}
