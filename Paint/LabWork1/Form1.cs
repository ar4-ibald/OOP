using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using LabWork1.Figures;

namespace LabWork1
{
    public partial class Form1 : Form
    {
        Point startpoint, endpoint;
        Graphics canvas;
        Color color = Color.Blue;
        Pen pen = new Pen(Color.Blue, 3);
        Figure figBuff;
        FigureList figureList = new FigureList();

        private bool isDrawn = false;

        public Form1()
        {
            InitializeComponent();
            canvas = canv.CreateGraphics();
            figBuff = new Square(new Pen(color, 3), startpoint, endpoint);
        }                
                
        private void Rectangle_Click(object sender, EventArgs e)
        {
            figBuff = new Figures.Rectangle(new Pen(color, 3), startpoint, endpoint);
        }
        private void Square_Click(object sender, EventArgs e)
        {
            figBuff = new Square(new Pen(color, 3), startpoint, endpoint);
        }
        private void Ellipse_Click(object sender, EventArgs e)
        {
            figBuff = new Ellipse(new Pen(color, 3), startpoint, endpoint);
        }
        private void Circle_Click(object sender, EventArgs e)
        {
            figBuff = new Circle(new Pen(color, 3), startpoint, endpoint);
        }
        private void Line_Click(object sender, EventArgs e)
        {
            figBuff = new Line(new Pen(color, 3), startpoint, endpoint);
        }
        private void Rhombus_Click(object sender, EventArgs e)
        {
            figBuff = new Rhombus(new Pen(color, 3), startpoint, endpoint);
        }
        private void Triangle_Click(object sender, EventArgs e)
        {
            figBuff = new Triangle(new Pen(color, 3), startpoint, endpoint);
        }
        private void RightTriangle_Click(object sender, EventArgs e)
        {
            figBuff = new RightTriangle(new Pen(color, 3), startpoint, endpoint);
        }

        private void canv_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawn = true;

            startpoint.X = e.X;
            startpoint.Y = e.Y;
            figBuff.begin = startpoint;
            figBuff.end = startpoint;
        }

        private void canv_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawn)
            {
                endpoint.X = e.X;
                endpoint.Y = e.Y;
              
                figBuff.end = endpoint;
                canv.Refresh();
            }            
        }

        private void canv_Paint(object sender, PaintEventArgs e)
        {
            figureList.Draw(e.Graphics);
            if (isDrawn)
            {
                figBuff.Draw(e.Graphics);
            }

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            figureList.Clear();
            canvas.Clear(Color.White);
        }

        private void canv_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawn = false;
            endpoint.X = e.X;
            endpoint.Y = e.Y;
            figBuff.end = endpoint;

            figureList.Add(figBuff);

            figBuff = (Figure)Activator.CreateInstance(figBuff.GetType(), pen,startpoint,endpoint);
            figureList.Draw(canvas);
        }
    }
}
