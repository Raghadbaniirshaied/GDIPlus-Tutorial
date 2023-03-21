using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDIPlus_Tutorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Point[] points = new Point[10];
        private void Form1_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;

            this.Paint += new PaintEventHandler(Form1_Paint);

            Random r = new Random();

            for (int x = 0; x < 10; x++) 
            {
                points[x].X = r.Next(0, this.Width);
                points[x].Y = r.Next(0, this.Height);
            }



        }

         private void Form1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

            e.Graphics.FillPolygon(Brushes.Black, points);
            e.Graphics.DrawImage(Properties.Resources.Testimage, new Point(50 ,50));

        }

         private void tnrAppTimer_Tick(object sender, EventArgs e)
        {
            this.Refresh();
        }
    }
}
