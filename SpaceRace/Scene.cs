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
        public List<Ball> BallsLeftToRight { get; set; }
        public List<Ball> BallsRightToLeft { get; set; }
        public Line VerticalLine { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Random Random { get; set; }

        public Scene(int Width, int Height)
        {
            PlayerLeft = new PlayerLeft(Width, Height);
            PlayerRight = new PlayerRight(Width, Height);
            VerticalLine = new Line(Width, Height);
            BallsLeftToRight = new List<Ball>();
            BallsRightToLeft = new List<Ball>();
            this.Width = Width;
            this.Height = Height;
            Random = new Random();
        }
        public void Draw(Graphics g)
        {
            PlayerLeft.Draw(g);
            PlayerRight.Draw(g);
            VerticalLine.Draw(g);
            foreach (Ball Ball in BallsLeftToRight)
            {
                Ball.Draw(g);
            }
            foreach (Ball Ball in BallsRightToLeft)
            {
                Ball.Draw(g);
            }
        }
        public void GenerateBall()
        {
            if (Random.Next(0, 2) == 0)
            {
                //  Od levo kon desno

                BallsLeftToRight.Add(new Ball(-10, Random.Next(Height - 150), 10));
            }
            else
            {
                //  Od desno kon levo
                BallsRightToLeft.Add(new Ball(Width + 10, Random.Next(Height - 150), 10));
            }
        }
        public bool CheckLeftIfTouching()
        {
            foreach (Ball b in BallsRightToLeft) 
            {
                if (PlayerLeft.IsTouching(b))
                    return true;
            }
            foreach (Ball b in BallsLeftToRight)
            {
                if (PlayerLeft.IsTouching(b))
                    return true;
            }
            return false;
        }
        public bool CheckRightIfTouching()
        {
            foreach (Ball b in BallsLeftToRight)
            {
                if (PlayerRight.IsTouching(b))
                    return true;
            }
            foreach (Ball b in BallsRightToLeft)
            {
                if (PlayerRight.IsTouching(b))
                    return true;
            }
            return false;

        }
        public void MoveBalls()
        {
            foreach (Ball Ball in BallsLeftToRight)
            {
                Ball.MoveRight();
            }
            foreach (Ball ball in BallsRightToLeft)
            {
                ball.MoveLeft();
            }
        }
        public string GetWinner()
        {
            string ret = "";
            if (PlayerRight.Points == PlayerLeft.Points)
                ret = "Нема победник, и двајцата играчи имаат ист број на поени.";
            else if (PlayerRight.Points < PlayerLeft.Points)
                ret = "Победник е играчот од левата страна!";
            else if (PlayerRight.Points > PlayerLeft.Points)
                ret = "Победник е играчот од десната страна!";
            return ret;
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
        public bool MoveLUp()
        {
            return PlayerLeft.MoveUp();
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
        public bool MoveRUp()
        {
            return PlayerRight.MoveUp();
        }

    }
}
