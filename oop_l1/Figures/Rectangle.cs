using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_l1
{
    public class Rectangle:Section
    {
        public override LinePainter GetPainter()
        {
            return new RectanglePainter();
        }
        public override void Draw()
        {
            Point[] t = pointArray;
            pointArray = new Point[4];
            pointArray[0] = t[0];
            pointArray[2] = t[1];
            pointArray[1].X = t[0].X;
            pointArray[1].Y = t[1].Y;
            pointArray[3].X = t[1].X;
            pointArray[3].Y = t[0].Y;
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
