using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocalizationStrategizer
{
    public partial class Form1 : Form
    {
        private double panelX, panelY;
        private const double maxX = 72;
        private const double minX = -72;
        private const double maxY = 72;
        private const double minY = -72;
        private Point lastPoint;
        private Graphics g;
        public Form1()
        {
            InitializeComponent();
            panelX = panel1.Width;
            panelY = panel1.Height;
            g = panel1.CreateGraphics();
        }

        private void resetDrawables_Click(object sender, EventArgs e)
        {
            this.panel1.Invalidate();
        }

        private void DownArms_Click(object sender, EventArgs e)
        {

        }

        private void Panel1_MouseClick(object sender, MouseEventArgs e)
        {
            double Y = 144 * (e.X / panelX);
            double X = 144 * (e.Y / panelY);
            if(X > 0 && X < maxX)
            {
                X = maxX - X;
            }
            else if(X > maxX)
            {
                X = -(X + minX);
            }
            else
            {
                X = 0;
            }

            if (Y > 0 && Y < maxY)
            {
                Y = maxY - Y;
            }
            else if (Y > maxY)
            {
                Y = -(Y + minY);
            }
            else
            {
                Y = 0;
            }
            Console.WriteLine("X: " + X);
            Console.WriteLine("Y: " + Y);
           
            Pen p = new Pen(Color.Yellow);
            Point point = new Point(e.X, e.Y);
            g.DrawEllipse(p, new RectangleF(new PointF(e.X-12, e.Y-12), new SizeF(24, 24)));
            g.FillEllipse(new SolidBrush(Color.DeepSkyBlue), new RectangleF(new PointF(e.X - 12, e.Y - 12), new SizeF(24, 24)));

            if (lastPoint.X != 0f && lastPoint.Y != 0f)
            {
                Point turnPoint = new Point(lastPoint.X, point.Y);
                g.DrawLine(p, lastPoint, turnPoint);
                g.DrawLine(p, turnPoint, point);
            }
            codeOutput.AppendText("updatePosition()\n");
            codeOutput.AppendText("moveWithEncoder(" + point.X + ", " + point.Y + ")\n");
            lastPoint = point;
        }
    }
}
