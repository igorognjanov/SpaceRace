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
        public int MoveIndex = 10;
        public Rectangle Rectangle { get; set; }
        public Point Center { set; get; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int RectangleWidth = 20;
        public int RectangleHeight = 40;
        public Player(int Width, int Height)
        {
            this.Width = Width;
            this.Height = Height;
        }
        public void Draw(Graphics g)
        {
            Pen Pen = new Pen(Color.White, 3);
            g.DrawRectangle(Pen, Rectangle);
            Pen.Dispose();
        }
        abstract public bool MoveLeft();
        abstract public bool MoveRight();
        abstract public bool MoveUp();
        public bool MoveDown()
        {
            if (Center.Y + 80 >= Height)
            {
                return false;
            }
            Center = new Point(Center.X, Center.Y + MoveIndex);
            UpdateRectangle();
            return true;
        }
        public void UpdateRectangle()
        {
            Rectangle = new Rectangle(Center.X, Center.Y, RectangleWidth, RectangleHeight);
        }


    }
}
