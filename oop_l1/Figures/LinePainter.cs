using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_l1
{
    public class LinePainter
    {
        public virtual void GetShape (IForm view,Point[] parr, bool flooded)
        {
            Section s = new Section();
            s.pointArray = parr;
            s.v = view;
            s.isClosed = false;
            s.isFlooded = flooded;
            s.Draw();
        }
    }
}
