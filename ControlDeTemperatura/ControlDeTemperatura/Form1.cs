using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ControlDeTemperatura
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxTempDeseada_TextChanged(object sender, EventArgs e)
        {

        }

        private void trackBarFlIn_Scroll(object sender, EventArgs e)
        {
            textBoxFlIn.Text = trackBarFlIn.Value.ToString();
        }

        private void trackBarTempDeseada_Scroll(object sender, EventArgs e)
        {
            textBoxTempDeseada.Text = trackBarTempDeseada.Value.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            double tSal = Convert.ToDouble(TempControl.Text);
            double tEnt = Convert.ToDouble(TempEntrada.Text);
            double Voltaje = Convert.ToDouble(VoltControl.Text);
            int tempDeseada = trackBarTempDeseada.Value;
            int Flujo = trackBarFlIn.Value;
            double constanteQ = .0046;

            
            if (Flujo <= 0 || tEnt > tempDeseada)
            {
                TempControl.Text = TempEntrada.Text;
                VoltControl.Text = "0";
            }

            else
            {
                TempControl.Text = Convert.ToString(tEnt + Math.Pow(Voltaje, 2) * constanteQ / Flujo);

                if (tSal < tempDeseada)
                {
                    Voltaje++;
                    VoltControl.Text = Convert.ToString(Voltaje);
                }
                if (tSal > tempDeseada)
                {
                    Voltaje--;
                    VoltControl.Text = Convert.ToString(Voltaje);
                }


            }

        }
    }
}
