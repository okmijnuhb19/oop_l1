using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace oop_l1
{
    enum rButtons {None,Line,Triangle,Rectangle,Parallelogramm,Trapeze,Quadrangle}
    public class Presenter
    {
        private readonly IForm _view;
        public static IForm vw { get; set; }
        private Point[] pointArray;
        private int currentPoint;
        private int pointValue;
        private bool isFlooded;
        public Section shape;
        public IPlugin plug;
        public Presenter(IForm view) 
        {
            
            _view = view;
            vw = _view;
            currentPoint = 0;
            pointArray = new Point[2];
            pointValue = 2;
            _view.ClearClick+=_view_ClearClick;
            
            _view.PBoxClick += _view_PBoxClick;
            _view.polygonLineClick += _view_polygonLineClick;
            _view.polygonClick += _view_polygonClick;
            _view.lineClick += _view_lineClick;
            _view.triangleClick += _view_triangleClick;
            _view.rectangleClick += _view_rectangleClick;
            _view.quadrangleClick += _view_quadrangleClick;
            _view.CheckBoxClick += _view_CheckBoxClick;
            _view.EllipsClick += _view_EllipsClick;
            _view.PluginButtonClick += _view_PluginButtonClick;
        }

        void _view_PluginButtonClick(object sender, EventArgs e)
        {
            _view.openfiledialod.Filter =
                "plugins (*.DLL)|*.DLL";

            // Allow the user to select multiple images. 
            _view.openfiledialod.Multiselect = true;
            _view.openfiledialod.Title = "Dll Browser";
            _view.openfiledialod.InitialDirectory = @"C:\Users\Andrew\Documents\Visual Studio 2012\Projects\oop_l1\EllipsePlugin\bin\Release";
            DialogResult dr = _view.openfiledialod.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                foreach (String dllPath in _view.openfiledialod.FileNames)
                {
                    var pluginAssembly = Assembly.LoadFrom(dllPath);
                    foreach (Type type in pluginAssembly.GetExportedTypes())
                    {
                        if (type.GetInterfaces().Contains(typeof(IPlugin)))
                        {
                            var plugin = (IPlugin)type.GetConstructor(Type.EmptyTypes).Invoke(new Object[0]);
                            plug = plugin;
                        }
                    }
                }
            }
        }

        void _view_EllipsClick(object sender, EventArgs e)
        {
            pointValue = 2;
            pointArray = new Point[pointValue];
            currentPoint = 0;
            isFlooded = _view.CheckBox;

            var tmp = plug.ShapeType.GetConstructor(Type.EmptyTypes).Invoke(new Object[0]);
            shape = (Section)tmp;
        }

        void _view_CheckBoxClick(object sender, EventArgs e)
        {
            isFlooded = _view.CheckBox;
        }

        void _view_quadrangleClick(object sender, EventArgs e)
        {
            pointValue = 4;
            pointArray = new Point[pointValue];
            currentPoint = 0;
            isFlooded = _view.CheckBox;
            shape = new Quadrangle();
        }
        void _view_rectangleClick(object sender, EventArgs e)
        {
            pointValue = 2;
            pointArray = new Point[pointValue];
            currentPoint = 0;
            isFlooded = _view.CheckBox;
            shape = new Rectangle();
        }
        void _view_triangleClick(object sender, EventArgs e)
        {
            pointValue = 3;
            pointArray = new Point[pointValue];
            currentPoint = 0;
            isFlooded = _view.CheckBox;
            shape = new Triangle();
        }
        void _view_lineClick(object sender, EventArgs e)
        {
            pointValue = 2;
            pointArray = new Point[pointValue];
            currentPoint = 0;
            isFlooded = false;
            shape = new Section();
        }
        void _view_polygonClick(object sender, EventArgs e)
        {
            pointValue = _view.NumberOfLinks;
            pointArray = new Point[pointValue];
            currentPoint = 0;
            isFlooded = _view.CheckBox;
            shape = new Polygon();
        }
        void _view_polygonLineClick(object sender, EventArgs e)
        {
            pointValue = _view.NumberOfLinks+1;
            pointArray=new Point[pointValue];
            currentPoint=0;
            isFlooded = false;
            shape = new PoligonalLine();
        }

        #region Обработка Событий
        void _view_PBoxClick(object sender, EventArgs e)
        {
            _view.PBox.Cursor=new Cursor(Cursor.Current.Handle);
            Point pnt = Cursor.Position;
            pointArray[currentPoint].X = pnt.X = pnt.X - _view.FormPosition.X - _view.PBoxPosition.X - 9;
            pointArray[currentPoint].Y = pnt.Y = pnt.Y - _view.FormPosition.Y - _view.PBoxPosition.Y - 32;
                     
            Graphics g = _view.PBox.CreateGraphics();
            g.DrawRectangle(new Pen(_view.selectedColorBack,1),pnt.X,pnt.Y,1,1);
            currentPoint++;
            if (currentPoint == pointValue) 
            {
                var painter = shape.GetPainter();
                painter.GetShape(_view,pointArray,isFlooded);
                currentPoint = 0;
            }
        }
       
        void _view_ClearClick(object sender, EventArgs e)
        {
            _view.PBox.Image = null;
        }
        #endregion
    }
}
