using System;
using oop_l1;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows;
using System.Threading.Tasks;

namespace EllipsePlugin
{
    public class Ellipse:Section
    { 
        public override LinePainter GetPainter()
        {
            return new EllipsePainter();
        }
        public override void Draw()
        {
            Graphics g = v.PBox.CreateGraphics();
            g.DrawEllipse(new Pen(v.selectedColorBack, v.ThicknessValue), pointArray[0].X, pointArray[0].Y, pointArray[1].X - pointArray[0].X, pointArray[1].Y - pointArray[0].Y);
            Brush solidBrush = new SolidBrush(v.selectedColorBack);
            if (isFlooded == true)
            {
                g.FillEllipse(solidBrush, pointArray[0].X, pointArray[0].Y, pointArray[1].X - pointArray[0].X, pointArray[1].Y - pointArray[0].Y);
            }
        }
    }
}
