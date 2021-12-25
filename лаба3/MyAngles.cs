using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;

namespace лаба3
{
    public class MyAngles : MyShape
    {

        private int n = 6;
        Point[] points;
        double r1 = 0;
        protected Color color = Color.Green;
        public MyAngles() : base()
        {
            points = new Point[n];
            CalculatePoints(x, y);
        }
        public MyAngles(int x, int y, int l) : base(x, y, l)
        {
            points = new Point[n];
            CalculatePoints(x, y);
        }

        private void CalculatePoints(int x, int y)
        {
            double angle = 0;
            double R = l / (2 * Math.Sin(Math.PI / n));
            r1 = R;
            for (int i = 0; i < 6; i++)
            {
                points[i].X = Convert.ToInt32(x + (R * Math.Cos(angle)));
                points[i].Y = Convert.ToInt32(y + (R * Math.Sin(angle)));
                angle = angle + 2 * Math.PI / n;
            }
        }

        public override void Draw(PictureBox picture1)
        {
            Pen pen = new Pen(color, 3);
            Graphics g = Graphics.FromHwnd(picture1.Handle);
            g.DrawPolygon(pen, points);
        }

        public override string ToString()
        {
            return $"Многоугольник  x={Convert.ToString(x)} y= {Convert.ToString(y)} l= {Convert.ToString(l)}";
        }
    }
}
