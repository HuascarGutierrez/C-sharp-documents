﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApplication8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double n;
        int a=0;
        private void baceptar_Click(object sender, EventArgs e)
        {
            n = double.Parse(tentrada.Text);
        }

        private void bmedirSP_Click(object sender, EventArgs e)
        {
            a++;
            Stopwatch tejecucion = new Stopwatch();
            tejecucion.Start();
            lresultado.Text = "";
            for (int i = 0; i < n; i++)
            {
                lresultado.Text = lresultado.Text + (i * 2).ToString() + "-";
            }
            tejecucion.Stop();
            TimeSpan t_total = tejecucion.Elapsed;
            grafica.Series[0].Points.AddXY(n,3600*t_total.Hours+60*t_total.Minutes+t_total.Seconds);
            Lsalidatiempo.Text = String.Format("{0:00}:{1:00}:{2:00}:{3:00}"
                , t_total.Hours, t_total.Minutes, t_total.Seconds
                , t_total.Milliseconds/10);
            if (a >= 5)
            {
                grafica.Visible = true;
            }
            else
            {
                grafica.Visible = false;
            }

        }

        private void grafica_Click(object sender, EventArgs e)
        {

        }

    }
}
