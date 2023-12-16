using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics; //super importante

namespace WindowsFormsApplication7
{
    public partial class Form1 : Form
    {
        double n;
        public Form1()
        {
            InitializeComponent();
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            n = int.Parse(entrada.Text);
            
        }

        private void b_Medir_Serie_Pares_Click(object sender, EventArgs e)
        {
            // empieza el programa
            Stopwatch tejecucion = new Stopwatch();
            tejecucion.Start();
            salida.Text = "";
            for (int i = 0; i < n; i++)
            {
                salida.Text = salida.Text + (i * 2).ToString() + "-";
            }
            tejecucion.Stop();
            TimeSpan t_total = tejecucion.Elapsed; //da el tiempo total tranzcurrido
            s_Tiempo.Text = String.Format("{0:00}:{1:00}:{2:00}:{3:00}" // formato bafo 
                , t_total.Hours, t_total.Minutes, t_total.Seconds
                , t_total.Milliseconds / 10);
        }

        private void b_Sumatoria_Click(object sender, EventArgs e)
        {

        }

    }
}
