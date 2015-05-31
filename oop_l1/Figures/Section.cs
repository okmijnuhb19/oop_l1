using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace oop_l1
{
    public class Section:Shape
    {
        public virtual LinePainter GetPainter() 
        {
            return new LinePainter();
        }
        public virtual void Draw()
        {
        
            Graphics g = v.PBox.CreateGraphics();
            g.DrawLines(new Pen(v.selectedColorBack, v.ThicknessValue), pointArray);
            if (isClosed == true)
            {
                g.DrawLine(new Pen(v.selectedColorBack, v.ThicknessValue), pointArray[0], pointArray[pointArray.Length - 1]);
            }
            Brush solidBrush = new SolidBrush(v.selectedColorBack);
            if (isFlooded == true)
            {
                g.FillPolygon(solidBrush, pointArray);
            }
        }
    }

}
