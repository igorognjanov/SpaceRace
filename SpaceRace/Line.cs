using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceRace
{
    public class Line
    {
        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }
        public Line(int Width, int Height)
        {
            StartPoint = new Point(Width / 2, 65);
            EndPoint = new Point(Width / 2, Height);
        }
        public void Draw(Graphics g)
        {
            Pen Pen = new Pen(Color.White, 2);
            g.DrawLine(Pen, StartPoint, EndPoint);
            Pen.Dispose();
        }
    }
}
