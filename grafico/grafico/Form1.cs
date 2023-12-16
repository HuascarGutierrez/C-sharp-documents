using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grafico
{
    public partial class Form1 : Form
    {
        double x = 0;
        Random numale = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tiempo.Enabled = true;
        }

        private void tiempo_Tick(object sender, EventArgs e)
        {
            if (x <= 10)
            {
                double y = -0.5+ Math.Pow(x - 5, 2)/25;
                grafica.Series[0].Points.AddXY(x, y);
                double a =  Math.Sin(x*2*Math.PI/10);
                grafica.Series[1].Points.AddXY(x, a);
                x++;
                
            }
        }
    }
}
