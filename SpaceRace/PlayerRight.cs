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
            InitCenter();
            UpdateBall();
        }
        public override void InitCenter()
        {
            Center = new Point((int)(Width * 0.75), Height - 100);
        }
        public override void MoveLeft()
        {
            if (Center.X - Radius - MoveIndex >= Width / 2)
            {
                Center = new Point(Center.X - MoveIndex, Center.Y);
                UpdateBall();
            }
        }

        public override void MoveRight()
        {
            if (Center.X + Radius + MoveIndex <= Width)
            {
                Center = new Point(Center.X + MoveIndex, Center.Y);
                UpdateBall();
            }
        }

        public override bool MoveUp()
        {
            if (Center.Y - Radius - MoveIndex <= 0)
                return false;
            Center = new Point(Center.X, Center.Y - MoveIndex);
            UpdateBall();
            return true;
        }
    }
}
