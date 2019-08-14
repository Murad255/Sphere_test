﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Intersection;

namespace Sphere_test
{
    public partial class Form1 : Form
    {
        const int maxX = 505;
        const int maxY = 505;
        public Form1()
        {
            InitializeComponent();
 
        }

        
 
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            int decX = e.X - maxX / 2;
            int decY = -e.Y + maxY / 2;

            valueX.Text = decX.ToString();
            valueY.Text = decY.ToString();

            Drav(decX, decY);
        }

        private async void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            await Task.Run(() =>
            {
                int decX = e.X - maxX / 2;
                int decY = -e.Y + maxY / 2;

                this.Invoke(new Action(() => {
                    valueX.Text = decX.ToString();
                    valueY.Text = decY.ToString();

                    Drav(decX, decY);
                }));
            });
        }

        private void bSet_Click(object sender, EventArgs e)
        {
            int decX = Convert.ToInt32(valueX.Text);
            int decY = Convert.ToInt32(valueY.Text);

            Drav(decX, decY);
        }

        private void DrawCircle(int cordX, int cordY, int rad)
        {
            Graphics cr = pictureBox1.CreateGraphics();
            cr.DrawEllipse(new Pen(Brushes.Red), cordX+((maxX-1)/2)-rad,maxY-(cordY + ((maxY - 1) / 2)+rad), rad*2, rad*2);
        }
        private void DrawCircle(int cordX, int cordY, int rad, Pen pen)
        {
            Graphics cr = pictureBox1.CreateGraphics();
            cr.DrawEllipse(pen, cordX + ((maxX - 1) / 2) - rad, maxY - (cordY + ((maxY - 1) / 2) + rad), rad * 2, rad * 2);
        }
        private void DrawLine(int X1, int Y1, int X2, int Y2)
        {
            Graphics lr = pictureBox1.CreateGraphics();
            lr.DrawLine(new Pen(Brushes.Black), X1 + ((maxX - 1) / 2) ,
                                                maxY - (Y1 + ((maxY - 1) / 2) ),
                                                X2 + ((maxX - 1) / 2),
                                                maxY - (Y2 + ((maxY - 1) / 2)));
        }

        private void Drav(int decX, int decY)
        {
            try
            {
                Text = "Норм";

                Graphics gr = pictureBox1.CreateGraphics();
                gr.Clear(Color.White);
                //Рисует систему координат
                gr.DrawLine(new Pen(Brushes.Black), 0, (maxY - 1) / 2 + 1, maxX, (maxY - 1) / 2 + 1);
                gr.DrawLine(new Pen(Brushes.Black), (maxX - 1) / 2 + 1, 0, (maxX - 1) / 2 + 1, maxY);

                //Рисует круг
                DrawCircle(0, 0, Convert.ToInt32(Shape.L1));
                DrawCircle(decX, decY, Convert.ToInt32(Shape.L2), new Pen(Brushes.Blue));
                Dec dec = Shape.Algoritm(new Dec(0, Convert.ToDouble(decX), Convert.ToDouble(decY)));

                DrawCircle((int)dec.decY, (int)dec.decZ, 3, new Pen(Brushes.Black));
                DrawCircle(0, 0, 3, new Pen(Brushes.Black));
                DrawCircle(decX, decY, 3, new Pen(Brushes.Black));

                DrawLine(0, 0, (int)dec.decY, (int)dec.decZ);
                DrawLine((int)dec.decY, (int)dec.decZ, decX, decY);
            }
            catch (Exception)
            {
                Text = "Ошибка!!!";
            }
        }
    }
}
