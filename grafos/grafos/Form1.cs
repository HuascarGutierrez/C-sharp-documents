using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grafos
{
    public partial class Form1 : Form
    {
        //{{1,2,3,4,5},{{1,2},{1,4},{2,1},{2,3},{2,5},{3,2},{3,4},{4,1},{4,3},{4,5},{5,2},{5,4}}}

        //ejemplo 1 {[1,2,3,4],[(1,2),(1,3),(1,4),(2,1),(2,4),(3,1),(3,4),(4,1),(4,2),(4,3)]}
        //ejemplo 2 {[1,2,3,4],[(1,2),(1,3),(1,4),(2,1),(2,3),(2,4),(3,1),(3,2),(3,4),(4,1),(4,2),(4,3)]}
        //{[1,2,3,4,5],[(1,2),(1,4),(2,1),(2,3),(2,5),(3,2),(3,4),(4,1),(4,3),(4,5),(5,2),(5,4)]}

        // caminos {[1,2,3,4],[(1,2,1),(1,3,2),(1,4,3),(2,1,4),(2,4,5),(3,1,6),(3,4,7),(4,1,8),(4,2,9),(4,3,10)]}
//        int numNodos, numAristas, incremento, incrementoF, incrementoC;
        String grafo;
        String[] vGrafo, nodos, aristas;
        String[,] Aristas;
        int[,] matrizGrafo;
        public Form1()
        {
            InitializeComponent();
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            lNodos.Items.Clear();
            lAristas.Items.Clear();
            Mat.Columns.Clear();
            Mat.Rows.Clear();
            
            grafo = entrada.Text;
            grafo = grafo.Replace(" ", "");
            grafo = grafo.Replace("],[(","},{");
            grafo = grafo.Replace("{[", "{"); 
            grafo = grafo.Replace(")]}","},");
            grafo = grafo.Replace(")", "}");
            grafo = grafo.Replace("(", "{");

            /*grafo = entrada.Text;
            grafo = grafo.Replace(" ", "");
            grafo = grafo.Replace("},{{","},{");
            grafo = grafo.Replace("{{", "{"); 
            grafo = grafo.Replace("}}}","},");*/

            vGrafo = grafo.Split('{');
            for (int i = 1; i < vGrafo.Length; i++)
            {
                vGrafo[i] = vGrafo[i].Replace("},", "");
            }
            nodos = vGrafo[1].Split(',');
            aristas = new String [vGrafo.Length-2];
            for (int i = 2; i < vGrafo.Length; i++)
            {
                aristas[i-2] = vGrafo[i];
            }
            Mat.RowCount = nodos.Length;
            Mat.ColumnCount = nodos.Length;
            matrizGrafo = new int[nodos.Length, nodos.Length];
            for (int i = 0; i < nodos.Length; i++)
            {
                lNodos.Items.Add(nodos[i]);
                Mat.Columns[i].HeaderText = nodos[i];
                Mat.Rows[i].HeaderCell.Value = nodos[i];
            }

            for (int i = 0; i < aristas.Length; i++)
            {
                lAristas.Items.Add("("+aristas[i]+")");
            }

            Aristas = new String[aristas.Length,3];
            for (int i = 0; i < aristas.Length; i++)
            {
                for(int j=0;j<3;j++)
                {
                    Aristas[i,j] = aristas[i].Split(',')[j];
                }
            }

            for (int j = 0; j < nodos.Length; j++)
            {
                for (int i = 0; i < nodos.Length; i++)
                    matrizGrafo[i, j] = 0;
            }

            for (int i = 0; i < nodos.Length; i++)
            {
                for (int j = 0; j < nodos.Length; j++)
                {
                    for (int k = 0; k < aristas.Length; k++)
                    {
                        if (nodos[i].Equals(Aristas[k, 0]) && nodos[j].Equals(Aristas[k, 1]))
                            matrizGrafo[i, j] = 1;
                    }
                }
            }
            double caminoAct=0, caminoAnt=0;
            for (int i = 0; i < nodos.Length; i++)
            {
                for (int j = 0; j < nodos.Length - 1 - i; j++)
                {
                    for (int k = 0; k < aristas.Length; k++)
                    {
                        if (nodos[i].Equals(Aristas[k, 0]) && nodos[j].Equals(Aristas[k, 1]))
                        {
                            caminoAct += double.Parse(Aristas[k, 2]);
                        }
                    }
                }
            }x
        }
        //vector camino int.Parse(Aristas[k,2])

        private void mMatriz_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < nodos.Length; i++)
            {
                for (int j = 0; j < nodos.Length; j++)
                {
                    Mat.Rows[i].Cells[j].Value = matrizGrafo[i, j];
                }
            }
        }

        private void lAristas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /*private void bGrafo_Click(object sender, EventArgs e)
        {
            Mat.Rows.Clear();
            Mat.Columns.Clear();
            lNodos.Items.Clear();
            lAristas.Items.Clear();
            numNodos = int.Parse(nNodos.Text);
            numAristas = int.Parse(nAristas.Text);
            vGrafo = new String[numNodos];
            matrizGrafo = new int[numNodos,numAristas];
            incremento = 0;
            incrementoF = 0;
            incrementoC = 0;
            Mat.RowCount = numNodos;
            Mat.ColumnCount = numNodos;
        }

        private void bNodoi_Click(object sender, EventArgs e)
        {
            String vertice = iNodo.Text;
            vGrafo[incremento] = vertice;
            lNodos.Items.Add(vertice+"-"+(incremento).ToString());
            Mat.Columns[incremento].HeaderText = vertice;
            Mat.Rows[incremento].HeaderCell.Value = vertice;
            incremento++;
            for (int i = 0; i < numNodos; i++)
            {
                for (int j = 0; j < numNodos; j++)
                {
                    matrizGrafo[i, j] = 0;
                }
            }
        }

        private void bAristai_Click(object sender, EventArgs e)
        {
            String busqueda1 = iAristai.Text;
            String busqueda2 = iAristaf.Text;
            lAristas.Items.Add(("(" + busqueda1 + "," + busqueda2 + ")"));
            for (int i = 0; i < vGrafo.Length; i++)
            {
                if (busqueda1.Equals(vGrafo[i]))
                {
                    for (int j = 0; j < vGrafo.Length; j++)
                    {
                        if (busqueda2.Equals(vGrafo[j]))
                        {
                            matrizGrafo[i,j] = 1;
                        }
                    }
                }
            }
        }

        private void mMatriz_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < vGrafo.Length; i++)
            {
                for (int j = 0; j < vGrafo.Length; j++)
                {
                    Mat.Rows[i].Cells[j].Value = matrizGrafo[i, j];
                }
            }
        }*/
    }
}
