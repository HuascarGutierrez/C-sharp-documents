using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG_1
{
    public partial class Form1 : Form
    {
        int n;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            if (entrada.Text == "negros")
            {
                salida.Text = "racista";
            }
            else
            {
                n = int.Parse(entrada.Text);
            }
        }

        private void pares_Click(object sender, EventArgs e)
        {
            salida.Text = "";
            lista.Items.Clear();
            for (int i = 0; i < n; i++)
            {
                salida.Text = salida.Text + (i * 2) + ",";
                lista.Items.Add(i*2);
            }
        }

        private void impares_Click(object sender, EventArgs e)
        {
            salida.Text = "";
            lista.Items.Clear();
            for (int i = 0; i < n; i++)
            {
                salida.Text = salida.Text + ((i * 2)+1) + ",";
                lista.Items.Add((i * 2) + 1);
            }
        }

        private void serie_1_Click(object sender, EventArgs e)
        {
            salida.Text = "";
            lista.Items.Clear();
            int a = 0;
            int b = 1;
            int c = 1;
            for (int i=0; i<n; i++)
                { salida.Text = salida.Text + a + ",";
                lista.Items.Add(a);
                a = b;
                b = c;
                c = a + b;
                }
        }

        private void serie_2_Click(object sender, EventArgs e)
        {
            salida.Text = "";
            lista.Items.Clear();
            int fact = 1, a = 0;
            for (int i=0; i<n; i++)
            {
                fact = 1;
                for (int j = 1; j <= a; j++)
                {
                    fact =fact * j;
                }
                salida.Text = salida.Text + fact + ",";
                a += 1;
                lista.Items.Add(fact);
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
        }

        private void ingresar_Click(object sender, EventArgs e)
        {
            lista.Items.Add(nombre.Text);
            nombre.Text = "";
        }


    }
}
