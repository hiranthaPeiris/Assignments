using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clipping
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        uint points;
        uint pts;
        ulong segments, p;
        double[] x = new double[100];
        double[] y = new double[100];
        Random r = new Random();

        double a1, b1, a2, b2;
        double c1, d1, c2, d2;

        private void btnInsert_Click(object sender, EventArgs e)
        {
            double x1, y1;
            if((double.TryParse(txtX.Text, out x1))&&(double.TryParse(txtY.Text,out y1)) && (x1 >= 0) && (x1 < panel1.Height) && (y1 >= 0) && (y1 < panel1.Width))
            {
                x[pts] = x1;
                y[pts] = y1;
                DisplayPoint((float)x1, (float)y1);
                pts++;
                if (pts == points)
                {
                    txtV.Clear();
                    txtX.Clear();
                    txtY.Clear();
                    btnInsert.Enabled = false;
                    gbCP.Enabled = false;
                    gbLS.Enabled = true;
                    gbAlg.Enabled = true;
                    gbTime.Enabled = true;
                    btnClear.Enabled = true;
                    btnDraw.Enabled = true;

                }
                else
                {
                    txtV.Text = pts.ToString();
                    txtX.Clear();
                    txtY.Clear();
                    txtX.Focus();
                }
            }
            else
            {
                MessageBox.Show("Error");
                txtX.Clear();
                txtY.Clear();
                txtX.Focus();
            }
        }

        Boolean visible;

        private void DisplayPoint(float x, float y)
        {
            Graphics g = panel1.CreateGraphics();
            g.DrawLine(Pens.White, x, panel1.Height - y, x + 0.1F, panel1.Height - y);
        }

        private void DisplayLine(float x1,float y1,float x2,float y2)
        {
            Graphics g = panel1.CreateGraphics();
            if((x1==x2) && (y1 == y2))
            {
                DisplayPoint(x1, y1);
            }
            else
            {
                g.DrawLine(Pens.White, x1, panel1.Height - y1, x2, panel1.Height - y2);

            }
        }

        private void DrawPolygon()
        {
            long i, j;
            for (i = 0; i < points; i++)
            {
                j = (i + 1) % points;
                DisplayLine((float)x[i], (float)y[i], (float)x[j], (float)y[j]);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if((uint.TryParse(txtNum.Text, out points)) && (points > 2))
            {
                pts = 0;
                txtNum.Enabled = false;
                btnOk.Enabled = false;
                txtV.Text = pts.ToString();
                txtX.Enabled = true;
                txtY.Enabled = true;
                txtX.Focus();
                btnInsert.Enabled = true;
            }
            else
            {
                MessageBox.Show("Error");
                txtNum.Clear();
                txtNum.Focus();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            panel1.Invalidate();
            txtTime.Clear();
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            DrawPolygon();
        }
        private void CyrusBeck()
        {
            Stopwatch stopWatch = new Stopwatch();

            stopWatch.Start();

            CalculateNormals();

            for (p = 0; p < segments; p++)
            {
                a1 = r.Next(0, panel1.Width);
                b1 = r.Next(0, panel1.Width);
                a2 = r.Next(0, panel1.Width);
                b2 = r.Next(0, panel1.Width);

                AlgCB();

                if (visible)
                {
                    DisplayLine((float)c1, (float)d1, (float)c2, (float)d2);
                }
            }

            stopWatch.Stop();

            TimeSpan ts = stopWatch.Elapsed;
            txtTime.Text = ts.ToString();
        }

        private void Skala()
        {
            Stopwatch stopWatch = new Stopwatch();

            stopWatch.Start();

            for (p = 0; p < segments; p++)
            {
                a1 = r.Next(0, panel1.Width);
                b1 = r.Next(0, panel1.Width);
                a2 = r.Next(0, panel1.Width);
                b2 = r.Next(0, panel1.Width);

                AlgSK();

                if (visible)
                {
                    DisplayLine((float)c1, (float)d1, (float)c2, (float)d2);
                }
            }

            stopWatch.Stop();

            TimeSpan ts = stopWatch.Elapsed;
            txtTime.Text = ts.ToString();
        }

        private void Proposed()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            CalculateNormals();
            

            for (p = 0; p < segments; p++)
            {
                a1 = r.Next(0, panel1.Width);
                b1 = r.Next(0, panel1.Width);
                a2 = r.Next(0, panel1.Width);
                b2 = r.Next(0, panel1.Width);

                AlgPro();

                if (visible)
                {
                    DisplayLine((float)c1, (float)d1, (float)c2, (float)d2);
                }
            }

            stopWatch.Stop();

            TimeSpan ts = stopWatch.Elapsed;
            txtTime.Text = ts.ToString();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if(ulong.TryParse(txtNumber.Text, out segments) && (segments != 0))
            {
                txtTime.Clear();
                btnRun.Enabled = false;
                gbLS.Enabled = false;
                gbAlg.Enabled = false;
                btnClear.Enabled = false;
                btnDraw.Enabled = false;

                if(lbAg.SelectedIndex == 0)
                {
                    CyrusBeck();
                }else if (lbAg.SelectedIndex == 1)
                {
                    Skala();
                }else if (lbAg.SelectedIndex == 2)
                {
                    Proposed();
                }
                else
                {
                    MessageBox.Show("Select an algorithum");
                }
                btnRun.Enabled = true;
                gbLS.Enabled = true;
                gbAlg.Enabled = true;
                btnClear.Enabled = true;
                btnDraw.Enabled = true;
            }
        }

        // Cyrus Beck Algorithm BEGIN

        double[] nx = new double[100];
        double[] ny = new double[100];

        double DotProduct(double x1, double y1, double x2, double y2)
        {
            return x1 * x2 + y1 * y2;
        }

        void CalculateNormals()
        {
            long i, j, k;

            for (i = 0; i < points; i++)
            {
                j = (i + 1) % points;
                k = (i + 2) % points;

                if (x[i] == x[j])
                {
                    nx[i] = 1.0;
                    ny[i] = 0.0;
                }
                else
                {
                    nx[i] = -(y[j] - y[i]) / (x[j] - x[i]);
                    ny[i] = 1.0;
                }

                if (DotProduct(nx[i], ny[i], x[k] - x[i], y[k] - y[i]) > 0)
                {
                    nx[i] *= -1;
                    ny[i] *= -1;
                }
            }
        }

        private void AlgCB()
        {
            double t1, t2, t, num, den;
            double dirVx, dirVy, Fx, Fy;
            int i;

            t1 = 0.0;
            t2 = 1.0;

            dirVx = a2 - a1;
            dirVy = b2 - b1;

            visible = true;
            i = 0;

            while ((i < points) && visible)
            {
                Fx = a1 - x[i];
                Fy = b1 - y[i];

                num = DotProduct(nx[i], ny[i], Fx, Fy);
                den = DotProduct(nx[i], ny[i], dirVx, dirVy);

                if (den == 0.0)
                {
                    if (num > 0.0)
                    {
                        visible = false;
                    }
                }
                else
                {
                    t = -(num / den);

                    if (den < 0.0)
                    {
                        if (t <= 1.0)
                        {
                            if (t > t1)
                            {
                                t1 = t;
                            }
                        }
                        else
                        {
                            visible = false;
                        }
                    }
                    else
                    {
                        if (t >= 0.0)
                        {
                            if (t < t2)
                            {
                                t2 = t;
                            }
                        }
                        else
                        {
                            visible = false;
                        }
                    }
                }
                i++;
            }

            if (t1 <= t2)
            {
                c1 = a1 + t1 * dirVx;
                d1 = b1 + t1 * dirVy;
                c2 = a1 + t2 * dirVx;
                d2 = b1 + t2 * dirVy;
            }
            else
            {
                visible = false;
            }
        }

        // Cyrus Beck Algorithm END

        // Skala Algorithm BEGIN

        private void AlgSK()
        {
        }

        // Skala Algorithm END

        // Proposed Algorithm BEGIN

        private void AlgPro()
        {

        }

        // Proposed Algorithm END
    }

}
