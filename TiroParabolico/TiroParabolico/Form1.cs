using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TiroParabolico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            const double g = 9.8;
            double x = 0, y = 0, t = 0;
            double ang = (double)Angulo.Value;
            double vel = (double)Velocidad.Value;

            initBtn.Enabled = false;

            for (t = 1; y>=0 ; t++)
            {
                y = (vel * Math.Sin(ang * Math.PI / 180) * t / 30) - (g * 0.5 * Math.Pow(t / 30, 2));
                x = (vel * Math.Cos(ang * Math.PI / 180) * t / 30);
                                             
            }
            
            tiempo.Text = "" + (t / 30);
            distancia.Text = "" + (vel * Math.Cos(ang * Math.PI / 180) * t / 30);
            a_max.Text = "" + (Math.Pow(vel * Math.Sin(ang * Math.PI / 180), 2) / (2 * g));
            initBtn.Enabled = true;
        
        }
         
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}