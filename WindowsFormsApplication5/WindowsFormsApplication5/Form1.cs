using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string frase;

        private void frase_TextChanged(object sender, EventArgs e)
        {

        }

        private void enviar_Click(object sender, EventArgs e)
        {
            
        }

        private void vocal_Click(object sender, EventArgs e)
        {
            frase = palabras.Text + " ";
            frase = frase.ToLower();
            frase.ToCharArray();
            vocales.Items.Clear();
            int i=0,a=0;
            for (int c = 0; c < frase.Length; c++)
            {
                if (frase[c] == ' ')
                    i++;
            }
            while (i > 0)
            {   int num=0;
                string palabra = "";
                while (frase[a] != ' ')
                {
                    if (frase[a] == 'a' || frase[a] == 'e' || frase[a] == 'i' || frase[a] == 'o' || frase[a] == 'u')
                        num++;
                    palabra += frase[a];
                    a++;

                }
                a++;
                vocales.Items.Add("la palabra "+palabra+" tiene "+(num)+" vocales");
                i -= 1;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            frase = palabras.Text;
            frase = frase.ToLower();
            frase.ToCharArray();
            vocales.Items.Clear();
            vocales.Items.Add("el tamano de la frase es: "+frase.Length);
        }

        private void palabra_Click(object sender, EventArgs e)
        {
            
            frase = palabras.Text + " ";
            frase = frase.ToLower();
            frase.ToCharArray();
            vocales.Items.Clear();
            int i = 0;
            for (int c = 0; c < frase.Length; c++)
            {
                if (frase[c] == ' ')
                    i++;
            }
            vocales.Items.Add("Existen "+(i)+" palabras");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frase = palabras.Text + " ";
            frase = frase.ToUpper();
            vocales.Items.Clear();
            vocales.Items.Add(frase);
        }

        private void cadena_Click(object sender, EventArgs e)
        {
            frase = palabras.Text + " ";
            string subfrase = "";
            subfrase = frase.Substring(int.Parse(inicio.Value.ToString()), int.Parse(final.Value.ToString()) - int.Parse(inicio.Value.ToString()));
            //TAMBIEN SE PUEDE (INT)OBJETO.VALUE
            vocales.Items.Clear();
            vocales.Items.Add(subfrase);
        }

        private void Indice_Click(object sender, EventArgs e)
        {
            frase = palabras.Text;
            string caracter = textBox1.Text;
            int indice = frase.IndexOf(caracter);
            vocales.Items.Clear();
            vocales.Items.Add(indice);
        }

        private void minuscula_Click(object sender, EventArgs e)
        {
            frase = palabras.Text;
            string minuscula = frase.ToLower();
            vocales.Items.Clear();
            vocales.Items.Add(minuscula);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frase = palabras.Text;
            string frase_1=reem_a.Text, frase_2=reem_b.Text;
            frase.Replace(frase_1, frase_2);
            frase = "adios que tal";
            vocales.Items.Add(frase);
        }
                    
        private void f_trim_Click(object sender, EventArgs e)
        {
            frase = palabras.Text;
            string hola=frase.Trim();
            vocales.Items.Clear();
            vocales.Items.Add(hola);
        }

        private void contiene_Click(object sender, EventArgs e)
        {
            frase = palabras.Text;
            string c=contenido.Text;
            Boolean cont = frase.Contains(c);
            vocales.Items.Add(cont);
            
        }

        private void cortar_Click(object sender, EventArgs e)
        {
            frase = palabras.Text;
            string[] pal= frase.Split(' ');
            for (int c = 0; c < pal.Length; c++)
            {
                vocales.Items.Add(pal[c]);
            }
           
        }
        

    }
}
