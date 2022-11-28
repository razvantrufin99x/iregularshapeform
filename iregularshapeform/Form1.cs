using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace iregularshapeform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            Point[] pointsA = new Point[]
{
new Point(0, 0),
new Point(40, 60),
new Point(this.Width - 100, 10)
};
            path.AddCurve(pointsA);
            Point[] pointsB = new Point[]
{
new Point(this.Width - 40, this.Height - 60),
new Point(this.Width, this.Height),
new Point(10, this.Height)
};
            path.AddCurve(pointsB);
            path.CloseAllFigures();
            this.Region = new Region(path);
        }
    }
}
