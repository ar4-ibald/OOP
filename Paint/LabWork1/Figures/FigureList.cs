using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace LabWork1.Figures
{
    class FigureList
    {
        private List<Figure> figureList;

        public FigureList()
        {
            figureList = new List<Figure>();
        }

        public void Add(Figure figure)
        {
            figureList.Add(figure);
        }

        public void Clear()
        {
            figureList.Clear();
        }

        public void Draw(Graphics graphics)
        {
            foreach (Figure figure in figureList)
            {
                figure.Draw(graphics);
            }
        }        
    }
}
