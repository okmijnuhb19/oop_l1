using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_l1
{
    public class PoligonalLinePainter:LinePainter
    {
        public override void GetShape(IForm view,System.Drawing.Point[] parr, bool flooded)
        {
            PoligonalLine s = new PoligonalLine();
            s.pointArray = parr;
            s.v = view;
            s.isClosed = false;
            s.isFlooded = flooded;
            s.Draw();
        }
    }
}
