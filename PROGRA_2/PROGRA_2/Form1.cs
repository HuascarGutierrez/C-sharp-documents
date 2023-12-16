using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace PROGRA_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[,] Mat = new int[50,50];
        int tf;
        int tc;

        void Mat_Ide()
        {
            for (int f = 0; f < tf; f++)
            {
                for (int c = 0; c < tc; c++)
                {
                    if (f == c)
                    {
                        Mat[f, c] = 1;
                    }
                    else
                    {
                        Mat[f, c] = 0;
                    }
                }
            }
        }

        private void aceptar_Click(object sender, EventArgs e)
        {

            tabla.Columns.Clear();
            tf = int.Parse(filas.Text);
            tc = int.Parse(columnas.Text);
            tabla.RowCount = tf;
            tabla.ColumnCount = tc;    

        }


        private void matriz_Click(object sender, EventArgs e)
        {
            int lim=tc,cant;
            if (tc%2!=0)
            {
                lim-=1;
                lim/=2;
                cant=1;
                for (int f = 0; f < tf; f++)
                {
                    for (int c = 0; c < tc; c++)
                    {
                        if (c < lim - cant / 2 || c > lim+cant/2)
                            Mat[f, c] = 0;
                        else
                            Mat[f, c] = 1;
                    }
                    if (f < tf/2)
                        cant += 2;
                    else
                        cant -= 2;
                }
            }
            else
            {
                lim /= 2;
                
                cant=2;
                for (int f = 0; f < tf; f++)
                {
                    for (int c = 0; c < tc; c++)
                    {
                        if (c < lim - cant / 2 || c > lim-1 + cant / 2)
                            Mat[f, c] = 0;
                        else
                            Mat[f, c] = 1;
                    }
                    if (f+1 < tf / 2)
                        cant += 2;
                    else
                        if (f+1 != tf/2)
                            cant -= 2;
                }
            }
        }

        private void identidad_Click(object sender, EventArgs e)
        {
            Mat_Ide();
        }

        private void mostrar_Click(object sender, EventArgs e)
        {
            for (int f = 0; f < tf; f++)
            {
                for (int c = 0; c < tc; c++)
                {
                    tabla.Rows[f].Cells[c].Value = Mat[f, c];
                }
            }
        }

        private void binario_Click(object sender, EventArgs e)
        {                  
            for (int f = 0; f < tf; f++)
            {
                int num_decimal = f+1, bin_int;
                double a = 1, binario = 0, i = 1;
                while (num_decimal >= 2)
                {
                    binario += num_decimal % 2 * a;
                    num_decimal /= 2;
                    a = Math.Pow(10, i);
                    i++;

                }
                binario += num_decimal * a;
                bin_int = int.Parse(binario.ToString());
                for (int c = (tc - 1); c >= 0; c -= 1)
                {                   
                    Mat[f, c] = bin_int%10;
                    bin_int /= 10;
                }
            }
        }

        private void filas_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
