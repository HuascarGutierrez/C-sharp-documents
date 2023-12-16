using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_II_C_Sharp_H.Gutierrez
{
    public partial class Form1 : Form
    {
        int[,] matriz;

        public Form1()
        {
            InitializeComponent();
        }

        private void pregunta_1_Click(object sender, EventArgs e)
        {
            alerta.Text = "";
            int N = int.Parse(filas.Text);
            if (N > 2)
            {
                tabla.RowCount = N;
                tabla.ColumnCount = N;
                alerta.Text = "solo se usara en Nro de filas";
                matriz = new int[N, N];
                int veces;
                if (N % 2 != 0)
                    veces = (N + 1) / 2;
                else
                    veces = N / 2;
                int var = 1;
                for (int i = 0; i < veces; i++)
                {
                    for (int j = i; j < N - i; j++)
                    {
                        for (int k = 0; k < N - i; k++)
                        {
                            matriz[j, k] = var;
                        }
                    }
                    var+=2;
                }
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        tabla.Rows[i].Cells[j].Value = matriz[i, j];
                    }
                }
            }
            else
            {
                alerta.Text = "ingrese un tamano mayor a 2 para la fila";
            }
        }

        private void pregunta_2_Click(object sender, EventArgs e)
        {
            alerta.Text = "";
            int N = int.Parse(filas.Text);
            int M = int.Parse(columnas.Text);
            tabla.RowCount = N;
            tabla.ColumnCount = M;
            matriz = new int[N, M];
            for (int f = 0; f < N; f++)
            {
                int num_decimal = f , bin_int;
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
                for (int c = (M - 1); c >= 0; c -= 1)
                {
                    matriz[f, c] = bin_int % 10;
                    bin_int /= 10;
                    tabla.Rows[f].Cells[c].Value = matriz[f,c];
                }
            }
        }

        private void pregunta_3_Click(object sender, EventArgs e)
        {
            int N = int.Parse(filas.Text);
            tabla.RowCount = N;
            tabla.ColumnCount = N;
            matriz = new int[N, N];
            alerta.Text = "solo se usara en Nro de filas";
            int valor=1;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matriz[j, i] = valor;
                    tabla.Rows[j].Cells[i].Value = matriz[j, i];
                    valor++;
                }
            }            
        }

        private void pregunta_4_Click(object sender, EventArgs e)
        {
            alerta.Text = "solo se usara en Nro de filas";
            int N = int.Parse(filas.Text);
            matriz = new int[N, N];
            tabla.RowCount = N;
            tabla.ColumnCount = N;
            int limite = 1, valor = 1,incremento=0;
            for (int i = N-1; i >=0; i-=1)
            {
                for (int j = 0; j <limite; j++)
                {
                        matriz[j, i] = valor;
                        valor++;
                        tabla.Rows[j].Cells[i].Value = matriz[j, i];
                }
                valor += incremento;
                incremento++;
                limite++;
            }
            int indicio=N-1;
            for (int i = 1; i < N; i++)
            {
                indicio -= 1;
                valor = matriz[i, indicio];
                for (int j = indicio+1; j < N; j++)
                {
                    matriz[i, j] = valor + 1;
                    tabla.Rows[i].Cells[j].Value = matriz[i, j];
                    valor++;
                }
            }
        }

        private void pregunta_5_Click(object sender, EventArgs e)
        {
            alerta.Text = "solo se usara en Nro de filas";
            int N = int.Parse(filas.Text);
            matriz = new int[N, N];
            tabla.RowCount = N;
            tabla.ColumnCount = N;
            int contador=0;
            int valor = 1;
            for (int i = 0; i < N; i++)
            {
                if (contador % 2 == 0)
                {
                    for (int j = 0; j < N; j++)
                    {
                        matriz[j, i] = valor;
                        tabla.Rows[j].Cells[i].Value = matriz[j, i];
                        valor++;
                    }

                }
                else
                {
                    for (int j = N-1; j >=0; j-=1)
                    {
                        matriz[j, i] = valor;
                        tabla.Rows[j].Cells[i].Value = matriz[j, i];
                        valor++;
                    }
                }
                contador++;
            }
        }

        private void pregunta_6_Click(object sender, EventArgs e)
        {
            alerta.Text = "";
            int N = int.Parse(filas.Text);
            int M = int.Parse(columnas.Text);
            matriz = new int[N, M];
            tabla.RowCount = N;
            tabla.ColumnCount = M;
            int max = N * M;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    matriz[i, j] = max;
                    tabla.Rows[i].Cells[j].Value = matriz[i,j];
                    max -= 1;
                }
            }

        }

        private void pregunta_7_Click(object sender, EventArgs e)
        {
            alerta.Text = "solo se usara en Nro de filas";
            int N = int.Parse(filas.Text);
            matriz = new int[N, N];
            tabla.RowCount = N;
            tabla.ColumnCount = N;
            int limite = 1, valor = 1;
            for (int i = 0; i <N; i++)
            {
                for (int j = 0; j < limite; j++)
                {
                    matriz[i, j] = valor;
                    valor++;
                    tabla.Rows[i].Cells[j].Value = matriz[i, j];
                }
                limite++;
            }
            int indicio = 0;
            for (int i = 0; i < N; i++)
            {
                indicio ++;
                for (int j = indicio; j < N; j++)
                {
                    matriz[i, j] = valor;
                    tabla.Rows[i].Cells[j].Value = matriz[i, j];
                    valor++;
                }
            }
        }

        private void pregunta_8_Click(object sender, EventArgs e)
        {
            alerta.Text = "solo se usara en Nro de filas";
            int A= int.Parse(filas.Text);
            matriz = new int[A, A];
            tabla.RowCount = A;
            tabla.ColumnCount = A;
            int valor, incremento=0;
            for (int i = 0; i < A; i++)
            {
                valor=1+incremento;
                for (int j = 0; j < A; j++)
                {
                    if (valor <= A)
                    {
                        matriz[i, j] = valor;
                    }
                    else
                    {
                        valor = 1;
                        matriz[i, j] = valor;
                    }
                    tabla.Rows[i].Cells[j].Value = matriz[i, j];
                    valor++;
                }
                incremento++;
            }
        }

        private void pregunta_9_Click(object sender, EventArgs e)
        {
            alerta.Text = "solo se usara en Nro de filas";
            int N = int.Parse(filas.Text);
            matriz = new int[N, N];
            tabla.RowCount = N;
            tabla.ColumnCount = N;
            int contador = 0, referencia = N-1, incremento = 2 * N - 1;
            int valor = 1;
            int limite = 0;
            for (int z = 0; z < N; z++)
            {
                if (z % 2 == 0)
                {
                    for (int i = limite; i < N - limite; i++)
                    {
                        matriz[contador, i] = valor;
                        valor++;
                    }
                    for (int i = limite+1; i < N - limite; i++)
                    {
                        matriz[i, referencia] = valor;
                        valor++;
                    }
                }
                else
                {
                    for (int i = limite + 1; i < N - limite; i++)
                    {
                        matriz[i, contador] = valor;
                        valor++;
                    }
                    for (int i = limite+1; i < N - limite-1; i++)
                    {
                        matriz[referencia, i] = valor;
                        valor++;
                    }
                    limite++;
                    contador++;
                    referencia -= 1;
                }       
            }
            for (int i = 0; i < N; i++)
            {
                valor = 1 + incremento;
                for (int j = 0; j < N; j++)
                {
                    tabla.Rows[i].Cells[j].Value = matriz[i, j];
                }
            }
        }

    }
}
