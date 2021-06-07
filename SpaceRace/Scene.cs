using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceRace
{
    public class Scene
    {
        public Player PlayerLeft { get; set; }
        public Player PlayerRight { get; set; }
        public Line VerticalLine { get; set; }
        public Random Random { get; set; }

        public Scene(int Width, int Height)
        {
            PlayerLeft = new PlayerLeft(Width, Height);
            PlayerRight = new PlayerRight(Width, Height);
            VerticalLine = new Line(Width, Height);
            Random = new Random();
        }
        public void Draw(Graphics g)
        {
            PlayerLeft.Draw(g);
            PlayerRight.Draw(g);
            VerticalLine.Draw(g);
        }
        public void MoveLDown()
        {
            PlayerLeft.MoveDown();
        }
        public void MoveLLeft()
        {
            PlayerLeft.MoveLeft();
        }
        public void MoveLRight() {
            PlayerLeft.MoveRight();
        }
        public void MoveLUp()
        {
            PlayerLeft.MoveUp();
        }
        public void MoveRDown()
        {
            PlayerRight.MoveDown();
        }
        public void MoveRLeft()
        {
            PlayerRight.MoveLeft();
        }
        public void MoveRRight()
        {
            PlayerRight.MoveRight();
        }
        public void MoveRUp()
        {
            PlayerRight.MoveUp();
        }

    }
}
