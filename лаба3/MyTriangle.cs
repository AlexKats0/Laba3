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
    public class MyTriangle : MyShape
    {
        protected Color color = Color.Green;
        public MyTriangle() : base() { }
        public MyTriangle(int x, int y, int l) : base(x, y, l) { }
        public override void Draw(PictureBox picture1)
        {
            Pen pen = new Pen(color, 3);
            Graphics g = Graphics.FromHwnd(picture1.Handle);
            Point[] points =
            {
                new Point(x, y), new Point (x, y+l), new Point(x+l, y+l), new Point(x, y)
            };
            g.DrawPolygon(pen, points);
        }

        public override string ToString()
        {
            return $"Треугольник  x={Convert.ToString(x)} y= {Convert.ToString(y)} l= {Convert.ToString(l)}";
        }
    }
}
