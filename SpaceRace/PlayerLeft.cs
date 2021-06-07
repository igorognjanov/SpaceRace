using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceRace
{
    public class PlayerLeft : Player
    {
        public PlayerLeft(int Width, int Height) : base(Width, Height)
        {
            this.Center = new Point (Width / 4 - RectangleWidth / 2, Height - 100);
            UpdateRectangle();
        }


        public override bool MoveLeft()
        {
            if (Center.X <= 0)
                return false;
            Center = new Point(Center.X - MoveIndex, Center.Y);
            UpdateRectangle();
            return true;
        }

        public override bool MoveRight()
        {
            if (Center.X + RectangleWidth + MoveIndex >= Width / 2)
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
