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
    public abstract class MyShape
    {
        protected int x;
        protected int l;
        protected int y;
        protected Color color = Color.Green;
        public string X { get; set; }
        public string Y { get; set; }
        public string L { get; set; }
        public MyShape(int x1, int y1, int l1)
        {
            x = x1;
            y = y1;
            l = l1;
        }
        public MyShape() {  }
        abstract public void Draw(PictureBox picture1);
        public abstract override string ToString();

    }
}
