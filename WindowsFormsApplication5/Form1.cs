using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = pictureBox1.CreateGraphics();
            grBoof = Graphics.FromImage(bitmap);
        }

        Graphics graphics;
        Graphics grBoof;
        Bitmap bitmap;

        bool isClick1 = false;
        bool isClick2 = false;
        bool isClick3 = false;
        bool isClick4 = false;

        Pen pen;

        Point[] points = { new Point(5, 5), new Point(40, 20), new Point(80, 150), new Point(100, 10) };
        Rectangle[] rect = { new Rectangle(1, 1, 9, 9), new Rectangle(36, 16, 9, 9), new Rectangle(76, 146, 9, 9), new Rectangle(96, 6, 9, 9) };


        public void X_Y()
        {
            pen = new Pen(Color.Red, 2);

            grBoof.DrawLine(Pens.Red, points[0], points[1]);
            grBoof.DrawLine(Pens.Red, points[3], points[2]);

            grBoof.FillEllipse(Brushes.Wheat, rect[0]);
            grBoof.FillEllipse(Brushes.Wheat, rect[1]);
            grBoof.FillEllipse(Brushes.Wheat, rect[2]);
            grBoof.FillEllipse(Brushes.Wheat, rect[3]);

            grBoof.DrawBezier(pen, points[0], points[1], points[2], points[3]);

            graphics.DrawImage(bitmap, new Point(0, 0));
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if ((e.X < points[0].X + 5 && e.Y < points[0].Y + 5) && (e.X > points[0].X - 5 && e.Y > points[0].Y - 5))
            {
                isClick1 = true;
            }

            if ((e.X < points[1].X + 5 && e.Y < points[1].Y + 5) && (e.X > points[1].X - 5 && e.Y > points[1].Y - 5))
            {
                isClick2 = true;
            }

            if ((e.X < points[2].X + 5 && e.Y < points[2].Y + 5) && (e.X > points[2].X - 5 && e.Y > points[2].Y - 5))
            {
                isClick3 = true;
            }

            if ((e.X < points[3].X + 5 && e.Y < points[3].Y + 5) && (e.X > points[3].X - 5 && e.Y > points[3].Y - 5))
            {
                isClick4 = true;
            }
        }


        

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isClick1)
            {
                points[0].X = e.X;
                points[0].Y = e.Y;
                rect[0].X = e.X - 5;
                rect[0].Y = e.Y - 5;
                grBoof.Clear(Color.White);
                X_Y();
            }

            if (isClick2)
            {
                points[1].X = e.X;
                points[1].Y = e.Y;
                rect[1].X = e.X - 5;
                rect[1].Y = e.Y - 5;
                grBoof.Clear(Color.White);
                X_Y();
            }

            if (isClick3)
            {
                points[2].X = e.X;
                points[2].Y = e.Y;
                rect[2].X = e.X - 5;
                rect[2].Y = e.Y - 5;
                grBoof.Clear(Color.White);
                X_Y();
            }

            if (isClick4)
            {
                points[3].X = e.X;
                points[3].Y = e.Y;
                rect[3].X = e.X - 5;
                rect[3].Y = e.Y - 5;
                grBoof.Clear(Color.White);
                X_Y();
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (isClick1)
            {
                points[0].X = e.X;
                points[0].Y = e.Y;
                rect[0].X = e.X - 5;
                rect[0].Y = e.Y - 5;
                grBoof.Clear(Color.White);
                X_Y();
                isClick1 = false;
            }

            if (isClick2)
            {
                points[1].X = e.X;
                points[1].Y = e.Y;
                rect[1].X = e.X - 5;
                rect[1].Y = e.Y - 5;
                grBoof.Clear(Color.White);
                X_Y();
                isClick2 = false;
            }

            if (isClick3)
            {
                points[2].X = e.X;
                points[2].Y = e.Y;
                rect[2].X = e.X - 5;
                rect[2].Y = e.Y - 5;
                grBoof.Clear(Color.White);
                X_Y();
                isClick3 = false;
            }

            if (isClick4)
            {
                points[3].X = e.X;
                points[3].Y = e.Y;
                rect[3].X = e.X - 5;
                rect[3].Y = e.Y - 5;
                grBoof.Clear(Color.White);
                X_Y();
                isClick4 = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            grBoof.Clear(Color.White);
            X_Y();
        }
    }
}
