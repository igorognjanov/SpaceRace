using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceRace
{
    public class PlayerRight : Player
    {
        public PlayerRight(int Width, int Height) : base(Width, Height)
        {

            Center = new Point((int)(Width * 0.75) - RectangleWidth / 2, Height - 100);
            UpdateRectangle();
        }

        public override bool MoveLeft()
        {
            if (Center.X - MoveIndex <= Width / 2)
                return false;
            Center = new Point(Center.X - MoveIndex, Center.Y);
            UpdateRectangle();
            return true;
        }

        public override bool MoveRight()
        {
            if (Center.X  + RectangleWidth * 2 >= Width)
                return false;
            Center = new Point(Center.X + MoveIndex, Center.Y);
            UpdateRectangle();
            return true;
        }

        public override bool MoveUp()
        {
            if (Center.Y <= 0)
                return false;
            Center = new Point(Center.X, Center.Y - MoveIndex);
            UpdateRectangle();
            return true;
        }
    }
}
