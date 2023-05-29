using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VectorField
{
    public struct Vect
    {
        public double x, y;
    }
    public struct Zaryad
    {
        public double Power;
        public bool isPlus;
        public double x, y;
    }
    public partial class Form1 : Form
    {
        double SpaceScale  = 10;  // Пикселей на единицу
        double VectorScale = 1;   // Длина единичного вектора в пикселях
        double GridFreq    = 10;  // Частота точек
        Zaryad[] zaryads = new Zaryad[10];
        int ZaryadCounter = 0;
      
        Vect f(Vect p)
        {
            Vect q;
            q.x = 0;
            q.y = 0;
            for(int i = 0; i < ZaryadCounter; i++)
            {
                double x1 = p.x+zaryads[i].x;
                double y1 = p.y+zaryads[i].y;
                double power = zaryads[i].Power;
                double r = Math.Sqrt(x1 * x1 + y1 * y1);
                if (zaryads[i].isPlus)
                {
                    q.x += power * x1 / r;
                    q.y += power * y1 / r;
                } else
                {
                    q.x -= power * x1 / r;
                    q.y -= power * y1 / r;
                }

            }
            return q;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void trackBarScale_Scroll(object sender, EventArgs e)
        {
            SpaceScale = (double)trackBarScale.Value;
            textBoxScale.Text = SpaceScale.ToString();
            panel1.Invalidate();
        }

        private void trackBarVector_Scroll(object sender, EventArgs e)
        {
            VectorScale = (double) trackBarVector.Value/10;
            textBoxVector.Text = VectorScale.ToString();
            panel1.Invalidate();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            GridFreq = (double) numericUpDown1.Value;
            panel1.Invalidate();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics; g.TranslateTransform(panel1.Width/2, panel1.Height/2);

            double Down = -(panel1.Width / 2) / SpaceScale;
            double Up = -Down;
            Vect p;
            for (p.x = Down; p.x <= Up; p.x += GridFreq)
            {
                int ix = (int)Math.Round(p.x * SpaceScale);
                for (p.y = Down; p.y <= Up; p.y += GridFreq)
                {
                    int iy = (int)Math.Round(p.y * SpaceScale);
                    g.DrawEllipse(Pens.Blue, ix - 1, iy - 1, 3, 3);
                    Vect q = f(p);
                    int jx = (int)Math.Round(q.x* VectorScale);
                    int jy = (int)Math.Round(q.y* VectorScale);
                    g.DrawLine(Pens.Red, ix, iy, ix+jx, iy+jy);
                }
            }
            
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            zaryads[ZaryadCounter].x = e.X - 400.1;
            zaryads[ZaryadCounter].y = e.Y - 400.1;
            zaryads[ZaryadCounter].Power = (double)numericUpDown2.Value;
            zaryads[ZaryadCounter++].isPlus = checkBox1.Checked;
            label4.Text = "X: " + (e.X-400) + "Y: " + (e.Y-400) + "Plus: "+ checkBox1.Checked;
            panel1.Invalidate();
        }
    }
}
