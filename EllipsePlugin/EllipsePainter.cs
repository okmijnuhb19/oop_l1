using System;
using oop_l1;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace EllipsePlugin
{
    public class EllipsePainter:LinePainter
    {
        public override void GetShape(IForm view,System.Drawing.Point[] parr, bool flooded)
        {
            Ellipse s = new Ellipse();
            s.pointArray = parr;
            s.v = view;
            s.isClosed = true;
            s.isFlooded = flooded;
            s.Draw();
        }
    }
}
