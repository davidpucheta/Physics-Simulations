using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        double Q;

        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            double M, t1, C = 4.1813;

            if (check4000w.Checked == true)
            { Q = 4.00; }
            if (check2500w.Checked == true)
            { Q = 2.50; }

            M = ((llave.Value * 20) / 100);

            if (M > 1)
            {
                t1 = Convert.ToDouble(tempAguaFria.Text);
                resultadoTemperatura.Text = Convert.ToString((Q / ((M / 60) * C)) + t1);
                Flujo.Text = M.ToString();
            }
            else if (M == 0)
            {
                Flujo.Text = M.ToString();
                resultadoTemperatura.Text = "llave cerrada";
            }
            else
            {
                Flujo.Text = M.ToString();
                resultadoTemperatura.Text = tempAguaFria.Text;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Flujo_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void llave_Scroll(object sender, EventArgs e)
        {
           double M, t1, C = 4.1813;

           if (check4000w.Checked == true)
            { Q = 4.00; }
            if (check2500w.Checked == true)
            { Q = 2.50; }

            M = ((llave.Value * 20) / 100);

            if (M > 1)
            {
                t1 = Convert.ToDouble(tempAguaFria.Text);
                resultadoTemperatura.Text = Convert.ToString((Q / ((M / 60) * C)) + t1);
                Flujo.Text = M.ToString();
            }
            else if (M == 0)
            {
                Flujo.Text = M.ToString();
                resultadoTemperatura.Text = "llave cerrada";
            }
            else
            {
                Flujo.Text = M.ToString();
                resultadoTemperatura.Text = tempAguaFria.Text;
            }

        }

        private void tempAguaFria_TextChanged(object sender, EventArgs e)
        {
            double M, t1, C = 4.1813;

            if (check4000w.Checked == true)
            { Q = 4.00; }
            if (check2500w.Checked == true)
            { Q = 2.50; }

            M = ((llave.Value * 20) / 100);

            if (M > 1)
            {
                t1 = Convert.ToDouble(tempAguaFria.Text);
                resultadoTemperatura.Text = Convert.ToString((Q / ((M / 60) * C)) + t1);
                Flujo.Text = M.ToString();
            }
            else if (M == 0)
            {
                Flujo.Text = M.ToString();
                resultadoTemperatura.Text = "llave cerrada";
            }
            else
            {
                Flujo.Text = M.ToString();
                resultadoTemperatura.Text = tempAguaFria.Text;
            }
        }

        private void check2500w_CheckedChanged(object sender, EventArgs e)
        {
            double M, t1, C = 4.1813;

            if (check4000w.Checked == true)
            { Q = 4.00; }
            if (check2500w.Checked == true)
            { Q = 2.50; }

            M = ((llave.Value * 20) / 100);

            if (M > 1)
            {
                t1 = Convert.ToDouble(tempAguaFria.Text);
                resultadoTemperatura.Text = Convert.ToString((Q / ((M / 60) * C)) + t1);
                Flujo.Text = M.ToString();
            }
            else if (M == 0)
            {
                Flujo.Text = M.ToString();
                resultadoTemperatura.Text = "llave cerrada";
            }
            else
            {
                Flujo.Text = M.ToString();
                resultadoTemperatura.Text = tempAguaFria.Text;
            }
        }
    }
}
