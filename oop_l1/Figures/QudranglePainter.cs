using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_l1
{
    public class QudranglePainter:LinePainter
    {
        public override void GetShape(IForm view,System.Drawing.Point[] parr, bool flooded)
        {
            Quadrangle s = new Quadrangle();
            s.pointArray = parr;
            s.v = view;
            s.isClosed = true;
            s.isFlooded = flooded;
            s.Draw();
        }
    }
}
