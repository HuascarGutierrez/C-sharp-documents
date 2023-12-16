using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Proyecto_Ordenamiento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int dato, c=0, n, z;
        int[] vectorGuardado = new int[50], vector;
        int x = 0;
        int[,] matriz;
        int filasMatriz = 0;
        int limiteTimer = 0;

        public int[] darVector()
        {
            int[] vectorTemp = new int[ListaDesordenada.Items.Count];
            for (int i=0; i<ListaDesordenada.Items.Count;i++)
            {
                vectorTemp[i] = vectorGuardado[i];
            }
            return vectorTemp;
        } // funcion para hacer mas simple la obtencion del vector para la grafica

        private void agregar_Click(object sender, EventArgs e)
        {
            dato = int.Parse(entrada.Text);
            ListaDesordenada.Items.Add(dato);
            vectorGuardado[c] = dato;
            c++;
            entrada.Clear();
        }

        private void insercion_Click(object sender, EventArgs e)
        {
            n = ListaDesordenada.Items.Count;
            matriz = new int[50, n];
            vector = darVector();

            listaOrdenada.Items.Clear();

            for (int k = 0; k < n; k++)
            {
                matriz[filasMatriz, k] = vector[k];
            }
            filasMatriz++;   //codigo para guardar los pasos

            int m = vector.Length;
            for (int i = 1; i < m; i++)
            {
                int actual = vector[i];
                int j = i - 1;
                while (j >= 0 && vector[j] > actual)
                {
                    vector[j + 1] = vector[j];
                    j = j - 1;
                }
                vector[j + 1] = actual;

                for (int k = 0; k < n; k++)
                {
                    matriz[filasMatriz, k] = vector[k];
                }
                filasMatriz++;   //codigo para guardar los pasos
            }

            limiteTimer = filasMatriz;
            filasMatriz = 0;
            timer1.Start();
            timer1.Enabled = true;
            x = 0;

            z = 0;
            grafico.Series[z].Points.Clear();     //anadir y limpiar la grafica            
        }

        private void rapido_Click(object sender, EventArgs e)
        {
            n = ListaDesordenada.Items.Count;
            matriz = new int[50, n];
            vector = darVector();

            listaOrdenada.Items.Clear();

            for (int k = 0; k < n; k++)
            {
                matriz[filasMatriz, k] = vector[k];
            }
            filasMatriz++;   //codigo para guardar los pasos

            QuickSort(vector, 0, vector.Length - 1);

            for (int k = 0; k < n; k++)
            {
                matriz[filasMatriz, k] = vector[k];
            }

            filasMatriz++;   //codigo para guardar los pasos

            limiteTimer = filasMatriz;
            filasMatriz = 0;
            timer1.Start();
            timer1.Enabled = true;
            x = 0;

            z = 1;
            grafico.Series[z].Points.Clear();     //anadir y limpiar la grafica
        }


        public void QuickSort(int[] vector, int left, int right)
        {
            if (left < right)
            {
                int indicepivote = Partition(vector, left, right);
                QuickSort(vector, left, indicepivote - 1);
                QuickSort(vector, indicepivote + 1, right);
            }
        }

        public int Partition(int[] vector, int left, int right)
        {
            int pivot = vector[right];
            int i = left - 1;
            for (int j = left; j < right; j++)
            {
                if (vector[j] < pivot)
                {
                    i++;
                    int temp = vector[i];
                    vector[i] = vector[j];
                    vector[j] = temp;

                    for (int k = 0; k < n; k++)
                    {
                        matriz[filasMatriz, k] = vector[k];
                    }
                    filasMatriz++;   //codigo para guardar los pasos
                }
            }
            int temp2 = vector[i + 1];
            vector[i + 1] = vector[right];
            vector[right] = temp2;

            return i + 1;
        }
        

        private void burbuja_Click(object sender, EventArgs e)
        {
            n = ListaDesordenada.Items.Count;
            matriz = new int[50,n];
            vector = darVector();

            listaOrdenada.Items.Clear();  //para que no hayan residuos

            for (int k = 0; k < n; k++)
            {
                matriz[filasMatriz, k] = vector[k];
            }
            filasMatriz++;   //codigo para guardar los paso


            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (vector[j] > vector[j + 1])
                    {
                        int temporal = vector[j];
                        vector[j] = vector[j + 1];
                        vector[j + 1] = temporal;

                        for (int k = 0; k < n; k++)
                        {
                            matriz[filasMatriz, k] = vector[k];
                        }
                        filasMatriz++;   //codigo para guardar los pasos

                    }
             
                }
            }

            limiteTimer = filasMatriz;
            filasMatriz = 0;
            timer1.Start();
            timer1.Enabled = true;
            x = 0;

            z = 2;
            grafico.Series[z].Points.Clear();     //anadir y limpiar la grafica
        }

        private void gnome_Click(object sender, EventArgs e)
        {
            n = ListaDesordenada.Items.Count;
            matriz = new int[50, n];
            vector = darVector();

            listaOrdenada.Items.Clear();

            for (int k = 0; k < n; k++)
            {
                matriz[filasMatriz, k] = vector[k];
            }
            filasMatriz++;   //codigo para guardar los paso

            int indice = 0;
            while (indice < n)
            {
                if (indice == 0)
                    indice++;
                if (vector[indice] >= vector[indice - 1])
                    indice++;
                else
                {
                    int temporal = vector[indice];
                    vector[indice] = vector[indice - 1];
                    vector[indice - 1] = temporal;
                    indice--;
                    for (int k = 0; k < n; k++)
                    {
                        matriz[filasMatriz, k] = vector[k];
                    }
                    filasMatriz++;   //codigo para guardar los paso
                }
            }

            limiteTimer = filasMatriz;
            filasMatriz = 0;
            timer1.Start();
            timer1.Enabled = true;
            x = 0;

            z = 3;
            grafico.Series[z].Points.Clear();
        }

        private void bidimensional_Click(object sender, EventArgs e)
        {
            n = ListaDesordenada.Items.Count;
            matriz = new int[50, n];
            vector = darVector();
            //vector desordenado
            listaOrdenada.Items.Clear();

            for (int k = 0; k < n; k++)
            {
                matriz[filasMatriz, k] = vector[k];
            }
            filasMatriz++;
            //codigo
            int der = vector.Length - 1;
            int izq = 0;
            int aux = 0;
            int cont = 0;

            do
            {
                cont++;
                for (int i = izq; i < der; i++)
                {
                    if (vector[i] > vector[i + 1])
                    {
                        aux = vector[i];
                        vector[i] = vector[i + 1];
                        vector[i + 1] = aux;
                        for (int k = 0; k < n; k++)
                        {
                            matriz[filasMatriz, k] = vector[k];
                        }
                        filasMatriz++;
                    }
                }
                for (int j = der; j > izq; j--)
                {
                    if (vector[j] < vector[j - 1])
                    {
                        aux = vector[j];
                        vector[j] = vector[j - 1];
                        vector[j - 1] = aux;
                        for (int k = 0; k < n; k++)
                        {
                            matriz[filasMatriz, k] = vector[k];
                        }
                        filasMatriz++;
                    }
                }
                izq++;
                der--;

            } while (izq < der);

            //timer
            limiteTimer = filasMatriz;
            filasMatriz = 0;
            timer1.Start();
            timer1.Enabled = true;
            x = 0;

            z = 4;
            grafico.Series[z].Points.Clear();
        }

        private void shell_Click(object sender, EventArgs e)
        {
            n = ListaDesordenada.Items.Count;
            matriz = new int[50, n];
            vector = darVector();
            //vector desordenado
            listaOrdenada.Items.Clear();

            for (int k = 0; k < n; k++)
            {
                matriz[filasMatriz, k] = vector[k];
            }
            filasMatriz++;

            //Codigo

            for (int gap = vector.Length / 2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < vector.Length; i += 1)
                {
                    int temp = vector[i];
                    int j;
                    for (j = i; j >= gap && vector[j - gap] > temp; j -= gap)
                    {
                        vector[j] = vector[j - gap];
                    }
                    vector[j] = temp;
                }
                for (int k = 0; k < n; k++)
                {
                    matriz[filasMatriz, k] = vector[k];
                }
                filasMatriz++;
            }

            //timer
            limiteTimer = filasMatriz;
            filasMatriz = 0;
            timer1.Start();
            timer1.Enabled = true;
            x = 0;

            z = 5;
            grafico.Series[z].Points.Clear();
        }

        private void mezcla_Click(object sender, EventArgs e)
        {
            n = ListaDesordenada.Items.Count;
            matriz = new int[50, n];
            vector = darVector();

            listaOrdenada.Items.Clear();

            for (int k = 0; k < n; k++)
            {
                matriz[filasMatriz, k] = vector[k];
            }
            filasMatriz++;   //codigo para guardar los paso

            unificar(vector, 0, n - 1);

            limiteTimer = filasMatriz;
            filasMatriz = 0;
            timer1.Start();
            timer1.Enabled = true;
            x = 0;

            z = 6;
            grafico.Series[z].Points.Clear();
        }

        private void unificar(int[] arr, int l, int r)
        {
            if (l < r)
            {
                int m = (l + r) / 2;

                unificar(arr, l, m);
                unificar(arr, m + 1, r);

                unir(arr, l, m, r);
            }
        }

        private void unir(int[] arr, int l, int m, int r)
        {
            int i, j, k;
            int n1 = m - l + 1;
            int n2 = r - m;

            int[] L = new int[n1];
            int[] R = new int[n2];

            for (i = 0; i < n1; i++)
                L[i] = arr[l + i];
            for (j = 0; j < n2; j++)
                R[j] = arr[m + 1 + j];

            i = 0;
            j = 0;
            k = l;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }

            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }

            for (int x = 0; x < n; x++)
            {
                matriz[filasMatriz, x] = arr[x];
            }
            filasMatriz++;   //codigo para guardar los paso
        }

        private void monticulos_Click(object sender, EventArgs e)
        {
            n = ListaDesordenada.Items.Count;
            matriz = new int[50, n];
            vector = darVector();

            listaOrdenada.Items.Clear();
            // Construir un montículo máximo
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                int largest = i;
                int left = 2 * i + 1;
                int right = 2 * i + 2;

                if (left < n && vector[left] > vector[largest])
                    largest = left;

                if (right < n && vector[right] > vector[largest])
                    largest = right;

                if (largest != i)
                {
                    int temp = vector[i];
                    vector[i] = vector[largest];
                    vector[largest] = temp;

                    // Llamar a heapify en el subárbol reducido
                    for (int j = largest; j <= (n / 2 - 1); )
                    {
                        int leftChild = 2 * j + 1;
                        int rightChild = 2 * j + 2;
                        int maxChild = leftChild;

                        if (rightChild < n && vector[rightChild] > vector[leftChild])
                            maxChild = rightChild;

                        if (vector[j] < vector[maxChild])
                        {
                            temp = vector[j];
                            vector[j] = vector[maxChild];
                            vector[maxChild] = temp;
                            j = maxChild;
                        }
                        else
                        {
                            break;
                        }
                        for (int k = 0; k < n; k++)
                        {
                            matriz[filasMatriz, k] = vector[k];
                        }
                        filasMatriz++;   //codigo para guardar los pasos
                    }
                    for (int k = 0; k < n; k++)
                    {
                        matriz[filasMatriz, k] = vector[k];
                    }
                    filasMatriz++;   //codigo para guardar los pasos
                }
            }

            // Extraer elementos uno por uno desde el montículo
            for (int i = n - 1; i > 0; i--)
            {
                // Mover el elemento raíz actual al final del arreglo
                int temp = vector[0];
                vector[0] = vector[i];
                vector[i] = temp;

                // Llamar a heapify en el subárbol reducido
                for (int j = 0; j < i / 2; )
                {
                    int leftChild = 2 * j + 1;
                    int rightChild = 2 * j + 2;
                    int maxChild = leftChild;

                    if (rightChild < i && vector[rightChild] > vector[leftChild])
                        maxChild = rightChild;

                    if (vector[j] < vector[maxChild])
                    {
                        temp = vector[j];
                        vector[j] = vector[maxChild];
                        vector[maxChild] = temp;
                        j = maxChild;
                        for (int k = 0; k < n; k++)
                        {
                            matriz[filasMatriz, k] = vector[k];
                        }
                        filasMatriz++;   //codigo para guardar los pasos
                    }
                    else
                    {
                        for (int k = 0; k < n; k++)
                        {
                            matriz[filasMatriz, k] = vector[k];
                        }
                        filasMatriz++;   //codigo para guardar los pasos
                        break;
                    }
                }
            }
            for (int k = 0; k < n; k++)
            {
                matriz[filasMatriz, k] = vector[k];
            }
            filasMatriz++;   //codigo para guardar los pasos

            limiteTimer = filasMatriz;
            filasMatriz = 0;
            timer1.Start();
            timer1.Enabled = true;
            x = 0;

            z = 7;
            grafico.Series[z].Points.Clear();
        }

        private void peine_Click(object sender, EventArgs e)
        {
            n = ListaDesordenada.Items.Count;
            matriz = new int[50, n];
            vector = darVector();

            listaOrdenada.Items.Clear();

            for (int k = 0; k < n; k++)
            {
                matriz[filasMatriz, k] = vector[k];
            }
            filasMatriz++;   //codigo para guardar los pasos

            int gap = n;
            bool swapped = true;

            while (gap > 1 || swapped)
            {
                // Calcular el siguiente gap
                gap = (int)(gap / 1.3);

                if (gap < 1)
                    gap = 1;

                swapped = false;

                // Comparar elementos con el gap actual
                for (int i = 0; i + gap < n; i++)
                {
                    if (vector[i] > vector[i + gap])
                    {
                        int temp = vector[i];
                        vector[i] = vector[i + gap];
                        vector[i + gap] = temp;
                        swapped = true;
                        for (int k = 0; k < n; k++)
                        {
                            matriz[filasMatriz, k] = vector[k];
                        }
                        filasMatriz++;   //codigo para guardar los pasos
                    }
                }
            }

            limiteTimer = filasMatriz;
            filasMatriz = 0;
            timer1.Start();
            timer1.Enabled = true;
            x = 0;

            z = 8;
            grafico.Series[z].Points.Clear();
        }

        private void seleccion_Click(object sender, EventArgs e)
        {
            n = ListaDesordenada.Items.Count;
            matriz = new int[50, n];
            vector = darVector();
            listaOrdenada.Items.Clear();


            for (int k = 0; k < n; k++)
            {
                matriz[filasMatriz, k] = vector[k];
            }
            filasMatriz++;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;

                // Encontrar el índice del elemento mínimo en el subarreglo no ordenado
                for (int j = i + 1; j < n; j++)
                {
                    if (vector[j] < vector[minIndex])
                    {
                        minIndex = j;
                    }
                }
                // Intercambiar el elemento actual con el mínimo encontrado
                int temp = vector[minIndex];
                vector[minIndex] = vector[i];
                vector[i] = temp;

                for (int k = 0; k < n; k++)
                {
                    matriz[filasMatriz, k] = vector[k];
                }
                filasMatriz++;
            }

            limiteTimer = filasMatriz;
            filasMatriz = 0;
            timer1.Start();
            timer1.Enabled = true;
            x = 0;

            z = 9;
            grafico.Series[z].Points.Clear();
        }

        private void nuevoVector_Click(object sender, EventArgs e)
        {
            c = 0;
            ListaDesordenada.Items.Clear();
            listaOrdenada.Items.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (x < limiteTimer)
            {
                string muestra = "",adicion;
                grafico.Series[z].Points.Clear();
                for (int i = 0; i < ListaDesordenada.Items.Count-1; i++)
                {
                    adicion = String.Format(" {0, 3} -", matriz[x, i].ToString());
                    muestra = muestra + adicion;
                    grafico.Series[z].Points.AddXY(i,matriz[x,i]);
                }
                adicion = String.Format(" {0, 3}", matriz[x, ListaDesordenada.Items.Count - 1].ToString());
                muestra = muestra + adicion;
                grafico.Series[z].Points.AddXY(ListaDesordenada.Items.Count - 1, matriz[x, ListaDesordenada.Items.Count - 1]);
                
                listaOrdenada.Items.Add(muestra);
                x++;
            }
            else
            {
                listaOrdenada.Items.Add("Vector ordenado");
                timer1.Enabled = false;//deshabilita
                timer1.Stop(); //detiene el tempo
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                grafico.Series[i].Points.Clear();
            }
        }

        private void grafico_Click(object sender, EventArgs e)
        {

        }

        private void reanudar_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void pausar_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
