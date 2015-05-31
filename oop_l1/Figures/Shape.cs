using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace oop_l1
{
    public abstract class Shape
    {
        public IForm v;
        public Point[] pointArray;
        public bool isClosed{get; set;}
        public bool isFlooded { get; set; }
    }
}
