using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_l1
{
    public class Polygon:Section
    {
        public override LinePainter GetPainter()
        {
            return new PolygonPainter();
        }
    }
}
