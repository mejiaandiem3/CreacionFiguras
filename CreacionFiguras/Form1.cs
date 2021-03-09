using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreacionFiguras
{
    public partial class Form1 : Form
    {
        //variables que determinan la ubicacion del click
        int x, y;
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            Point punto = new Point(e.X,e.Y);
            x = punto.X;
            y = punto.Y;

            panel1.Invalidate();


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics papel = panel1.CreateGraphics();
            Pen lapiz = new Pen(Color.Black);

            if (lstfiguras.SelectedIndex==0)
            {
                SolidBrush brocha = new SolidBrush(Color.Red);
                papel.DrawEllipse(lapiz, x - 50, y - 50, 100, 100);
                papel.FillEllipse(brocha, x - 50, y - 50, 100, 100);
            }

            if (lstfiguras.SelectedIndex == 1)
            {
                SolidBrush brocha = new SolidBrush(Color.Green);
                papel.DrawRectangle(lapiz, x - 50, y - 50, 100, 100);
                papel.FillRectangle(brocha, x - 50, y - 50, 100, 100);
            }



        }
    }
}
