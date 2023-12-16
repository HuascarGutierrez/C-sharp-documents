using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Práctica_I_C_sharp_H.Gutierrez
{
    public partial class Form1 : Form
    {
        int[] serie;
        string cadena;
        string[] cadenas;

        public Form1()
        {
            InitializeComponent();
        }

        private void pregunta_1_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
            int M = int.Parse(entrada.Text), c=0, diferencia=1, contador=0;
            serie = new int[M];
            for (int i = 0; i < M; i++)
            {   
                c += diferencia;
                serie[i] = c;
                lista.Items.Add(serie[i]);
                contador++;
                if (contador % 3 == 0)
                {
                    if (contador % 2 == 0)
                    {
                        diferencia = 1;
                        c = 0;
                    }
                    else
                    {
                        diferencia = -1;
                        c = 4;
                    }
                }            
            }
        }

        private void pregunta_2_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
            int A = int.Parse(entrada.Text);
            int mult=0, dato=2, x = 0, y = 1, z = 1;
            serie= new int [A];

            for (int i = 0; i < A; i++)
            {         
                if (i % 2 == 0)
                {
                    serie[i] = x;
                    x = y;
                    y = z;
                    z = x + y;
                }
                else
                {
                    serie[i] = dato * mult;
                    mult++;
                    if (mult % 3 == 0)
                        mult = 0;
                    
                }
                lista.Items.Add(serie[i]);
            }
        }

        private void pregunta_3_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
            int N = int.Parse(entrada.Text), J=int.Parse(entrada_2.Text);
            int incremento=1;
            serie = new int [N];
            for (int i = 0; i < N; i++)
            {
                if ((i + 1) % J != 0)
                    serie[i] = i + 1;
                else
                {
                    serie[i] = incremento;
                    incremento++;
                }
                lista.Items.Add(serie[i]);
            }
        }

        private void pregunta_4_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
            int N = int.Parse(entrada.Text);
            serie = new int[N];
            int limite, c = 0, diferencia = 1, contador = 0;
            if (N % 2 == 0)
                limite = N / 2;
            else
                limite = (N + 1) / 2;
            for (int i = 0; i < N; i++)
            {
                c += diferencia;
                serie[i] = c;
                lista.Items.Add(serie[i]);
                contador++;
                if (contador % limite == 0)
                {
                    diferencia = -1;
                    if (N % 2 == 0)
                        c++;
                }
            }
        }

        private void pregunta_5_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
            int K = int.Parse(entrada.Text);
            serie = new int[K];
            for (int i = 0; i < K; i++)
            {
                if ((i + 1) % 3 == 0)
                    serie[i] = (int) Math.Pow(i + 1, 2);
                else
                    serie[i] = i + 1;
                lista.Items.Add(serie[i]);
            }
        }

        private void pregunta_6_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
            int F = int.Parse(entrada.Text);
            serie = new int[F];
            int x=0, y=1, z=1, n=1;
            for(int i=0; i<F; i++)
            {
                if (i % 2 == 0)
                {
                    serie[i] = x;
                    x = y;
                    y = z;
                    z = x + y;
                }
                else
                {
                    serie[i] = n;
                    n++;
                }
                lista.Items.Add(serie[i]);
            }
        }

        private void pregunta_7_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
            int B = int.Parse(entrada.Text);
            serie = new int[B];         
            string [] serie_mostrar= new string[B]; 
            for (int x = 0; x < B; x++) 
                serie[x]=2*x+1;
            int i;
            for ( i = 0; i < B; i++)
            {   
                string mostrar="";
                if (i != B - 1)
                {
                    mostrar = "";
                    for (int j = 0; j < B - i; j++)
                    {
                        mostrar += (serie[j]) + ", ";
                    }
                }
                else
                    mostrar+=serie[0];
                serie_mostrar[i] = mostrar;
                lista.Items.Add(serie_mostrar[i]);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pregunta_1_B_Click(object sender, EventArgs e)
        {
            cadena = entrada_cadena.Text;
            string cadena_2="";
            for (int i=0; i<cadena.Length;i++)
                cadena_2+=cadena[cadena.Length-1-i];
            if (cadena_2 == cadena)
                salida.Text = "Es palindromo";
            else
                salida.Text = "No es palindromo";
        }

        private void pregunta_2_B_Click(object sender, EventArgs e)
        {
            cadena = entrada_cadena.Text;
            cadenas = cadena.Split(' ');
            string nombre = cadenas[0], apellido = cadenas[1], fecha = cadenas[2], ci = cadenas[3];
            string codigo = "";
            codigo += nombre[0];
            codigo += apellido[0];
            codigo += fecha[0];
            codigo += fecha[1];
            codigo += ci[0];
            codigo += ci[1];
            salida.Text = codigo;
        }

        private void pregunta_3_B_Click(object sender, EventArgs e)
        {
            cadena = entrada_cadena.Text;
            cadena = cadena.ToLower();
            cadena = cadena.Replace('á', 'a');
            cadena = cadena.Replace('é', 'e');
            cadena = cadena.Replace('í', 'i');
            cadena = cadena.Replace('ó', 'o');
            cadena = cadena.Replace('ú', 'u');
            cadenas = cadena.Split(' ');
            int contador=0;
            for (int i = 0; i < cadenas.Length; i++)
            {
                string palabra = cadenas[i];
                int cont = 0;
                for (int j = 0; j < palabra.Length; j++)
                {
                    if (palabra[j] == 'a' || palabra[j] == 'e' || palabra[j] == 'i' || palabra[j] == 'o' || palabra[j] == 'u')
                        cont++;
                }
                if (cont >= 5)
                    contador++;
            }
            salida.Text = "la frase tiene " + (contador) + " palabras pentavocalicas.";

        }

        private void pregunta_4_B_Click(object sender, EventArgs e)
        {
            cadena = entrada_cadena.Text;
            cadena = cadena.ToLower();
            cadenas = cadena.Split(' ');
            string palabra = palabra_rep.Text;
            palabra=palabra.ToLower();
            int contador=0;
            for (int i = 0; i < cadenas.Length; i++)
            {
                if (cadenas[i] == palabra)
                    contador++;
            }
            if (contador == 1)
                salida.Text = palabra + ", se repite una vez.";
            else if (contador == 0)
                salida.Text = palabra + ", no se repite ni una sola vez.";
            else
                salida.Text = palabra + ", se repite " + (contador) + " veces.";
        }

        private void pregunta_5_B_Click(object sender, EventArgs e)
        {
            cadena = entrada_cadena.Text;
            cadena=cadena.Trim();
            cadenas = cadena.Split(' ');
            int num_palabras = cadenas.Length;
            if (num_palabras % 2 != 0)
            {
                int medio = (num_palabras - 1) / 2;
                cadenas[medio] = "examen";
            }
            salida.Text = "";
            for (int i = 0; i < num_palabras; i++)
                salida.Text += cadenas[i] + " ";
            preg_5.Text += "\tLa frase contiene " + num_palabras + " palabras."; 
        }
    }
}
