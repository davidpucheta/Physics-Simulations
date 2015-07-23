using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace simulacionNivelDelTanque
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
            {
                timer1.Start();
                capacidadTanque.Enabled = false;
                initBtn.Text = "Parar Simulación";
            }

            else if (timer1.Enabled == true)
            {
                timer1.Stop();
                capacidadTanque.Enabled = true;
                initBtn.Text = "Iniciar Simulación";
            }

                
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int i = ((int)llaveLlenado.Value * 20) / 100;
            int o = ((int)llaveVaciado.Value * 20) / 100;

            textBoxFlujoLlenado.Text = "" + i;
            textBoxFlujoVaciado.Text = "" + o;


        }
    }
}
