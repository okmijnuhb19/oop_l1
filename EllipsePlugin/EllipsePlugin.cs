using System;
using oop_l1;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EllipsePlugin
{
    public class EllipsePlugin:IPlugin
    {
        public string NameOfShape { get { return "Ellipse"; } }
        public Type ShapeType { get { return typeof(Ellipse); } }
        public int pointV { get { return 2; } }
        
    }
}
