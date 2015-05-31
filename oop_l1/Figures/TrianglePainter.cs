using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_l1
{
    public class TrianglePainter:LinePainter
    {
        public override void GetShape(IForm view,System.Drawing.Point[] parr, bool flooded)
        {
            Triangle s = new Triangle();
            s.pointArray = parr;
            s.isClosed = true;
            s.v = view;
            s.isFlooded = flooded;
            s.Draw();
        }
    }
}
