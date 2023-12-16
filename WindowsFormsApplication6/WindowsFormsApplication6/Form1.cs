using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        int contador = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void tiempo_Tick(object sender, EventArgs e)
        {
            if (contador <= 99)
            {
                cont.Text = contador.ToString();
                contador++;
            }
            else
            {
                contador = 0;
                cont.Text = contador.ToString();
            }
            if (contador >= 94 && contador<=99)
            {
                boom.Image = global::WindowsFormsApplication6.Properties.Resources._22;
            }
            else
            {
                boom.Image = global::WindowsFormsApplication6.Properties.Resources._11;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (inicio.Text == "Inicio")
            {
                tiempo.Enabled = true;
                inicio.Text = "Stop";
            }
            else
            {
                tiempo.Enabled = false;
                inicio.Text = "Inicio";
            }

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            tiempo.Interval = 100 - 10*(trackBar1.Value-1);
        }
    }
}
