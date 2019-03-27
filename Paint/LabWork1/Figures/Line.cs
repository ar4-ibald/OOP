﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork1.Figures
{
    class Line : Figure
    {
        public Line(Pen pen, Point begin, Point end):base(pen,begin,end)
        {
        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawLine(pen, begin, end);
        }
    }
}
