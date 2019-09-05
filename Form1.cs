using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Intersection;

namespace Sphere_test
{
    public partial class Form1 : Form
    {
        const int maxX = 765;
        const int maxY = 765;
        const int L3 = 130; // CB, mm.
        
        private static Dec axisB, axisC;

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
        //Рисует круг
        private void DrawCircle(int cordX, int cordY, int rad)
        {
            Graphics cr = pictureBox1.CreateGraphics();
            cr.DrawEllipse(new Pen(Brushes.Black), cordX+((maxX-1)/2)-rad,maxY-(cordY + ((maxY - 1) / 2)+rad), rad*2, rad*2);
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

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                if (T_degreeB.Value != T_degreeB.Minimum)
                {
                    T_degreeB.Value -= 1;
                    bSet_Click(sender, e);
                }
            }
            if (e.KeyCode == Keys.D)
            {
                if (T_degreeB.Value != T_degreeB.Maximum)
                {
                    T_degreeB.Value += 1;
                    bSet_Click(sender, e);
                }
            }
        }

        private void T_degreeB_Scroll(object sender, EventArgs e)
        {
            int decX = Convert.ToInt32(valueX.Text);
            int decY = Convert.ToInt32(valueY.Text);
            Drav(decX, decY);
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

                axisC = new Dec();
                axisC.decZ = decY + Math.Sin(-(T_degreeB.Value+90) * Math.PI / 180) * L3; //coord Y
                axisC.decY = decX + Math.Cos(-(T_degreeB.Value +90) * Math.PI / 180)  * L3;  //coord X
                axisC.update_pXY();

                axisB = Shape.Algoritm(axisC); // axisB.decY= coord X, axisB.decZ= coord Y

                var Bx = Convert.ToInt32( axisB.decY);
                var By = Convert.ToInt32(axisB.decZ);

                var Cx = Convert.ToInt32(axisC.decY);
                var Cy = Convert.ToInt32(axisC.decZ);

                //отрисовка кругов
                DrawCircle(0, 0, Convert.ToInt32(Shape.L1), new Pen(Brushes.Red));
                DrawCircle( Cx,Cy, Convert.ToInt32(Shape.L2),new Pen(Brushes.GreenYellow));
                DrawCircle(decX, decY, Convert.ToInt32(L3), new Pen(Brushes.Blue));

                //отрисовка линий
                DrawLine(0, 0, Bx,By);
                DrawLine(Bx,By,Cx,Cy);
                DrawLine(Cx,Cy,decX,decY);
                
                //отрисовка точек
                DrawCircle(0, 0, 3, new Pen(Brushes.Black));
                DrawCircle(Bx,By, 3);
                DrawCircle(Cx,Cy, 3);
                DrawCircle(decX, decY, 3);

                var AC = Math.Sqrt(axisC.decZ * axisC.decZ + axisC.decY * axisC.decY);
           
                int CanB = Convert.ToInt32(Math.Acos(axisB.decY / Shape.L1) * 180 / Math.PI);
                valueQ2.Text = CanB.ToString();
                
                int CanC =180-Convert.ToInt32(Math.Acos((AC * AC - Shape.L1 * Shape.L1 - Shape.L2 * Shape.L2) / (2 * Shape.L1 * Shape.L2)) * 180 / Math.PI);
                valueQ3.Text = CanC.ToString();

                int CanD = -90 + CanB + CanC + T_degreeB.Value;
                valueQ4.Text = CanD.ToString();
            }
            catch (Exception e)
            {
                Text = e.ToString();
            }
        }

    }
}
