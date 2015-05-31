using System;                                   
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_l1
{
    public interface IForm 
    {
        event EventHandler polygonLineClick;
        event EventHandler polygonClick;
        event EventHandler lineClick;
        event EventHandler triangleClick;
        event EventHandler rectangleClick;
        event EventHandler quadrangleClick;
        event EventHandler CircleClick;
        event EventHandler EllipsClick;
        event EventHandler PBoxClick;
        event EventHandler ClearClick;
        event EventHandler CheckBoxClick;
        event EventHandler PluginButtonClick;
        OpenFileDialog openfiledialod { get; set; }
        int NumberOfLinks { get; }
        bool CheckBox { get; }
        Point FormPosition { get; }
        Point PBoxPosition { get; }
        int ThicknessValue { get; }
        PictureBox PBox { get; set; }
        Color selectedColorBack { get; set; }
    }
    
    public partial class Form1 : Form,IForm
    {
        public Form1()
        {
            InitializeComponent();
            elips.Hide();
            clear.Click += clear_Click;
            pictureBox1.Click += pictureBox1_Click;
            #region ColorEvents
            color_white.Click += color_white_Click;
            colorBlack.Click += colorBlack_Click;
            colorCrimson.Click += colorCrimson_Click;
            colorDodgerBlue.Click += colorDodgerBlue_Click;
            colorForestGreen.Click += colorForestGreen_Click;
            colorGold.Click += colorGold_Click;
            colorIndigo.Click += colorIndigo_Click;
            colorLawnGreen.Click += colorLawnGreen_Click;
            colorLightSeaGreen.Click += colorLightSeaGreen_Click;
            colorMagenta.Click += colorMagenta_Click;
            colorMediumSpringGreen.Click += colorMediumSpringGreen_Click;
            colorMidnightBlue.Click += colorMidnightBlue_Click;
            colorNavy.Click += colorNavy_Click;
            colorOlive.Click += colorOlive_Click;
            colorOrange.Click += colorOrange_Click;
            colorOrchid.Click += colorOrchid_Click;
            colorRed.Click += colorRed_Click;
            colorSaddleBrown.Click += colorSaddleBrown_Click;
            colorSilver.Click += colorSilver_Click;
            colorYellow.Click += colorYellow_Click;
#endregion
            polygonLine1.Click += polygonLine1_Click;
            polygon1.Click += polygon1_Click;
            line1.Click += line1_Click;
            triangle1.Click += triangle1_Click;
            rectangle1.Click += rectangle1_Click;
            quadrangle1.Click += quadrangle1_Click;
            pluginButton.Click+=pluginButton_Click;
            elips.Click += elips_Click;
            checkBox1.Click += checkBox1_Click;
        }

       


        #region changeColor
        void colorYellow_Click(object sender, EventArgs e)
        {
            selectedColor.BackColor = Color.Yellow;
            selectedColorBack = Color.Yellow;
        }

        void colorSilver_Click(object sender, EventArgs e)
        {
            selectedColor.BackColor = Color.Silver;
            selectedColorBack = Color.Silver;
        }

        void colorSaddleBrown_Click(object sender, EventArgs e)
        {
            selectedColor.BackColor=Color.SaddleBrown;
            selectedColorBack = Color.SaddleBrown;
        }

        void colorRed_Click(object sender, EventArgs e)
        {
            selectedColor.BackColor = Color.Red;
            selectedColorBack = Color.Red;
        }

        void colorOrchid_Click(object sender, EventArgs e)
        {
            selectedColor.BackColor = Color.Orchid;
            selectedColorBack = Color.Orchid;
        }

        void colorOrange_Click(object sender, EventArgs e)
        {
            selectedColor.BackColor = Color.Orange;
            selectedColorBack = Color.Orange;
        }

        void colorOlive_Click(object sender, EventArgs e)
        {
            selectedColor.BackColor = Color.Olive;
            selectedColorBack = Color.Olive;
        }

        void colorNavy_Click(object sender, EventArgs e)
        {
            selectedColor.BackColor = Color.Navy;
            selectedColorBack = Color.Navy;
        }

        void colorMidnightBlue_Click(object sender, EventArgs e)
        {
            selectedColor.BackColor = Color.MidnightBlue;
            selectedColorBack = Color.MidnightBlue;
        }

        void colorMediumSpringGreen_Click(object sender, EventArgs e)
        {
            selectedColor.BackColor = Color.MediumSpringGreen;
            selectedColorBack = Color.MediumSpringGreen;
        }

        void colorMagenta_Click(object sender, EventArgs e)
        {
            selectedColor.BackColor = Color.Magenta;
            selectedColorBack = Color.Magenta;
        }

        void colorLightSeaGreen_Click(object sender, EventArgs e)
        {
            selectedColor.BackColor = Color.LightSeaGreen;
            selectedColorBack = Color.LightSeaGreen;
        }

        void colorLawnGreen_Click(object sender, EventArgs e)
        {
            selectedColor.BackColor = Color.LawnGreen;
            selectedColorBack = Color.LawnGreen;
        }

        void colorIndigo_Click(object sender, EventArgs e)
        {
            selectedColor.BackColor = Color.Indigo;
            selectedColorBack = Color.Indigo;
        }

        void colorGold_Click(object sender, EventArgs e)
        {
            selectedColor.BackColor = Color.Gold;
            selectedColorBack = Color.Gold;
        }

        void colorForestGreen_Click(object sender, EventArgs e)
        {
            selectedColor.BackColor = Color.ForestGreen;
            selectedColorBack = Color.ForestGreen;
        }

        void colorDodgerBlue_Click(object sender, EventArgs e)
        {
            selectedColor.BackColor = Color.DodgerBlue;
            selectedColorBack = Color.DodgerBlue;
        }

        void colorCrimson_Click(object sender, EventArgs e)
        {
            selectedColor.BackColor = Color.Crimson;
            selectedColorBack = Color.Crimson;
        }

        void colorBlack_Click(object sender, EventArgs e)
        {
            selectedColor.BackColor = Color.Black;
            selectedColorBack = Color.Black;
        }

        void color_white_Click(object sender, EventArgs e)
        {
            selectedColor.BackColor = Color.White;
            selectedColorBack = Color.White;
        }
        #endregion
        #region Проброс событий
        void checkBox1_Click(object sender, EventArgs e)
        {
            if (CheckBoxClick != null) CheckBoxClick(this, EventArgs.Empty);
        }

        void elips_Click(object sender, EventArgs e)
        {
            if (EllipsClick != null) EllipsClick(this, EventArgs.Empty);
        }

        void circle_Click(object sender, EventArgs e)
        {
            if (CircleClick != null) CircleClick(this, EventArgs.Empty);
        }

        void quadrangle1_Click(object sender, EventArgs e)
        {
            if (quadrangleClick != null) quadrangleClick(this, EventArgs.Empty);
        }

        void rectangle1_Click(object sender, EventArgs e)
        {
            if (rectangleClick != null) rectangleClick(this, EventArgs.Empty);
        }

        void triangle1_Click(object sender, EventArgs e)
        {
            if (triangleClick != null) triangleClick(this, EventArgs.Empty);
        }

        void line1_Click(object sender, EventArgs e)
        {
            if (lineClick != null) lineClick(this, EventArgs.Empty);
        }

        void polygon1_Click(object sender, EventArgs e)
        {
            if (polygonClick != null) polygonClick(this, EventArgs.Empty);
        }

        void polygonLine1_Click(object sender, EventArgs e)
        {
            if (polygonLineClick != null) polygonLineClick(this, EventArgs.Empty);
        }
       
        
        void pictureBox1_Click(object sender, EventArgs e)
        {
            if (PBoxClick != null) PBoxClick(this, EventArgs.Empty);
        }
    
        void clear_Click(object sender, EventArgs e)
        {
            if (ClearClick != null) ClearClick(this, EventArgs.Empty);
        }
        #endregion
        #region IForm
        public bool CheckBox { get { return checkBox1.Checked; } }
        public int ThicknessValue { get { return Convert.ToInt32(Thickness.Value); } }
        public Color selectedColorBack { get { return selectedColor.BackColor; } set { selectedColor.BackColor = value; } }
        public PictureBox PBox { get { return pictureBox1; } set { pictureBox1 = value; } }
        public Point PBoxPosition { get { return this.pictureBox1.Location; } }
        public Point FormPosition { get { return this.Location; } }
        public int NumberOfLinks { get { return Convert.ToInt32(numberOfLinks.Value); } }
        public OpenFileDialog openfiledialod { get { return openFileDialog1; } set { openFileDialog1 = value; } }
        
        public event EventHandler polygonLineClick;
        public event EventHandler polygonClick;
        public event EventHandler lineClick;
        public event EventHandler triangleClick;
        public event EventHandler rectangleClick;
        public event EventHandler quadrangleClick;
        public event EventHandler CircleClick;
        public event EventHandler EllipsClick;
        public event EventHandler CheckBoxClick;
        public event EventHandler PluginButtonClick;

        public event EventHandler ClearClick;
        public event EventHandler PBoxClick;
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void pluginButton_Click(object sender, EventArgs e)
        {
            elips.Show();
            if (PluginButtonClick != null) PluginButtonClick(this, EventArgs.Empty);
        }

        
    }
}
