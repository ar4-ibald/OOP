using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace LabWork1.Figures
{
    abstract class Poly: Rectangle
    {
        public Point[] points;

        public Poly(Pen pen,Point begin, Point end):base(pen,begin,end)
        {
            
        }

    }
}
