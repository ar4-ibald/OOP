using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork1.Figures
{
    class Rectangle : Figure
    {
        public int width
        {
            get
            {
                return Math.Abs(begin.X - end.X);
            }
        }
        public int height
        {
            get
            {
                return Math.Abs(begin.Y - end.Y);
            }
        }

        public virtual Point topLeftPoint
        {
            get
            {
                return new Point(Math.Min(begin.X, end.X), Math.Min(begin.Y, end.Y));
            }
        }

        public virtual Point downRightPoint
        {
            get
            {
                return new Point(Math.Max(begin.X, end.X), Math.Max(begin.Y, end.Y));
            }
        }
        
        public int hugeside
        {
            get
            {
                return Math.Max(width, height);
            }
        }

        public int smallside
        {
            get
            {
                return Math.Min(width, height);
            }
        }


        public Rectangle(Pen pen,Point begin, Point end):base(pen,begin,end)
        {
            
        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawRectangle(pen, topLeftPoint.X, topLeftPoint.Y, width, height);
        }
    }
}
