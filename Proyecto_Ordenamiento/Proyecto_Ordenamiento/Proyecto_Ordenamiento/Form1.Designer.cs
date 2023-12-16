namespace Proyecto_Ordenamiento
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series41 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series42 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series43 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series44 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series45 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series46 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series47 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series48 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series49 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series50 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.agregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.entrada = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.peine = new System.Windows.Forms.Button();
            this.seleccion = new System.Windows.Forms.Button();
            this.monticulos = new System.Windows.Forms.Button();
            this.mezcla = new System.Windows.Forms.Button();
            this.shell = new System.Windows.Forms.Button();
            this.bidimensional = new System.Windows.Forms.Button();
            this.gnome = new System.Windows.Forms.Button();
            this.burbuja = new System.Windows.Forms.Button();
            this.rapido = new System.Windows.Forms.Button();
            this.insercion = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.clear = new System.Windows.Forms.Button();
            this.grafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ListaDesordenada = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.listaOrdenada = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.limpiarLista = new System.Windows.Forms.Button();
            this.reanudar = new System.Windows.Forms.Button();
            this.pausar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grafico)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.agregar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.entrada);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 89);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entrada";
            // 
            // agregar
            // 
            this.agregar.Location = new System.Drawing.Point(117, 45);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(109, 38);
            this.agregar.TabIndex = 2;
            this.agregar.Text = "Agregar";
            this.agregar.UseVisualStyleBackColor = true;
            this.agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Agregue dato por dato";
            // 
            // entrada
            // 
            this.entrada.Location = new System.Drawing.Point(11, 51);
            this.entrada.Name = "entrada";
            this.entrada.Size = new System.Drawing.Size(100, 26);
            this.entrada.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.peine);
            this.groupBox2.Controls.Add(this.seleccion);
            this.groupBox2.Controls.Add(this.monticulos);
            this.groupBox2.Controls.Add(this.mezcla);
            this.groupBox2.Controls.Add(this.shell);
            this.groupBox2.Controls.Add(this.bidimensional);
            this.groupBox2.Controls.Add(this.gnome);
            this.groupBox2.Controls.Add(this.burbuja);
            this.groupBox2.Controls.Add(this.rapido);
            this.groupBox2.Controls.Add(this.insercion);
            this.groupBox2.Location = new System.Drawing.Point(12, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(232, 425);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo de ordenamiento";
            // 
            // peine
            // 
            this.peine.Location = new System.Drawing.Point(6, 328);
            this.peine.Name = "peine";
            this.peine.Size = new System.Drawing.Size(220, 35);
            this.peine.TabIndex = 9;
            this.peine.Text = "Ordenamiento peine";
            this.peine.UseVisualStyleBackColor = true;
            this.peine.Click += new System.EventHandler(this.peine_Click);
            // 
            // seleccion
            // 
            this.seleccion.Location = new System.Drawing.Point(6, 369);
            this.seleccion.Name = "seleccion";
            this.seleccion.Size = new System.Drawing.Size(220, 32);
            this.seleccion.TabIndex = 8;
            this.seleccion.Text = "Ordenamiento por selección";
            this.seleccion.UseVisualStyleBackColor = true;
            this.seleccion.Click += new System.EventHandler(this.seleccion_Click);
            // 
            // monticulos
            // 
            this.monticulos.Location = new System.Drawing.Point(6, 289);
            this.monticulos.Name = "monticulos";
            this.monticulos.Size = new System.Drawing.Size(220, 33);
            this.monticulos.TabIndex = 7;
            this.monticulos.Text = "Ord. por montículos";
            this.monticulos.UseVisualStyleBackColor = true;
            this.monticulos.Click += new System.EventHandler(this.monticulos_Click);
            // 
            // mezcla
            // 
            this.mezcla.Location = new System.Drawing.Point(6, 248);
            this.mezcla.Name = "mezcla";
            this.mezcla.Size = new System.Drawing.Size(220, 35);
            this.mezcla.TabIndex = 6;
            this.mezcla.Text = "Ordenamiento por mezcla";
            this.mezcla.UseVisualStyleBackColor = true;
            this.mezcla.Click += new System.EventHandler(this.mezcla_Click);
            // 
            // shell
            // 
            this.shell.Location = new System.Drawing.Point(6, 213);
            this.shell.Name = "shell";
            this.shell.Size = new System.Drawing.Size(220, 29);
            this.shell.TabIndex = 5;
            this.shell.Text = "Ordenamiento Shell";
            this.shell.UseVisualStyleBackColor = true;
            this.shell.Click += new System.EventHandler(this.shell_Click);
            // 
            // bidimensional
            // 
            this.bidimensional.Location = new System.Drawing.Point(6, 176);
            this.bidimensional.Name = "bidimensional";
            this.bidimensional.Size = new System.Drawing.Size(220, 31);
            this.bidimensional.TabIndex = 4;
            this.bidimensional.Text = "burbuja bidimensional";
            this.bidimensional.UseVisualStyleBackColor = true;
            this.bidimensional.Click += new System.EventHandler(this.bidimensional_Click);
            // 
            // gnome
            // 
            this.gnome.Location = new System.Drawing.Point(6, 140);
            this.gnome.Name = "gnome";
            this.gnome.Size = new System.Drawing.Size(220, 30);
            this.gnome.TabIndex = 3;
            this.gnome.Text = "Ordenamiento Gnome";
            this.gnome.UseVisualStyleBackColor = true;
            this.gnome.Click += new System.EventHandler(this.gnome_Click);
            // 
            // burbuja
            // 
            this.burbuja.Location = new System.Drawing.Point(6, 102);
            this.burbuja.Name = "burbuja";
            this.burbuja.Size = new System.Drawing.Size(220, 32);
            this.burbuja.TabIndex = 2;
            this.burbuja.Text = "Ordenamiento burbuja";
            this.burbuja.UseVisualStyleBackColor = true;
            this.burbuja.Click += new System.EventHandler(this.burbuja_Click);
            // 
            // rapido
            // 
            this.rapido.Location = new System.Drawing.Point(6, 65);
            this.rapido.Name = "rapido";
            this.rapido.Size = new System.Drawing.Size(220, 31);
            this.rapido.TabIndex = 1;
            this.rapido.Text = "Ordenamiento rápido";
            this.rapido.UseVisualStyleBackColor = true;
            this.rapido.Click += new System.EventHandler(this.rapido_Click);
            // 
            // insercion
            // 
            this.insercion.Location = new System.Drawing.Point(6, 25);
            this.insercion.Name = "insercion";
            this.insercion.Size = new System.Drawing.Size(220, 34);
            this.insercion.TabIndex = 0;
            this.insercion.Text = "Ordenamiento por inserción";
            this.insercion.UseVisualStyleBackColor = true;
            this.insercion.Click += new System.EventHandler(this.insercion_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pausar);
            this.groupBox3.Controls.Add(this.reanudar);
            this.groupBox3.Controls.Add(this.clear);
            this.groupBox3.Controls.Add(this.grafico);
            this.groupBox3.Location = new System.Drawing.Point(259, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(769, 520);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Gráfico";
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(495, 464);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(183, 41);
            this.clear.TabIndex = 2;
            this.clear.Text = "Limpiar gráfica";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // grafico
            // 
            chartArea5.Name = "ChartArea1";
            this.grafico.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.grafico.Legends.Add(legend5);
            this.grafico.Location = new System.Drawing.Point(19, 33);
            this.grafico.Name = "grafico";
            this.grafico.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series41.ChartArea = "ChartArea1";
            series41.Legend = "Legend1";
            series41.Name = "Inserción";
            series42.ChartArea = "ChartArea1";
            series42.Legend = "Legend1";
            series42.Name = "Rápido";
            series43.ChartArea = "ChartArea1";
            series43.Legend = "Legend1";
            series43.Name = "Burbuja";
            series44.ChartArea = "ChartArea1";
            series44.Legend = "Legend1";
            series44.Name = "Gnome";
            series45.ChartArea = "ChartArea1";
            series45.Legend = "Legend1";
            series45.Name = "B. bidimensional.";
            series46.ChartArea = "ChartArea1";
            series46.Legend = "Legend1";
            series46.Name = "Shell";
            series47.ChartArea = "ChartArea1";
            series47.Legend = "Legend1";
            series47.Name = "Por mezcla";
            series48.ChartArea = "ChartArea1";
            series48.Legend = "Legend1";
            series48.Name = "Montículos";
            series49.ChartArea = "ChartArea1";
            series49.Legend = "Legend1";
            series49.Name = "Peine";
            series50.ChartArea = "ChartArea1";
            series50.Legend = "Legend1";
            series50.Name = "Selección";
            this.grafico.Series.Add(series41);
            this.grafico.Series.Add(series42);
            this.grafico.Series.Add(series43);
            this.grafico.Series.Add(series44);
            this.grafico.Series.Add(series45);
            this.grafico.Series.Add(series46);
            this.grafico.Series.Add(series47);
            this.grafico.Series.Add(series48);
            this.grafico.Series.Add(series49);
            this.grafico.Series.Add(series50);
            this.grafico.Size = new System.Drawing.Size(733, 418);
            this.grafico.TabIndex = 0;
            this.grafico.Text = "chart1";
            this.grafico.Click += new System.EventHandler(this.grafico_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.limpiarLista);
            this.groupBox4.Controls.Add(this.ListaDesordenada);
            this.groupBox4.Location = new System.Drawing.Point(1034, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(222, 302);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Datos";
            // 
            // ListaDesordenada
            // 
            this.ListaDesordenada.FormattingEnabled = true;
            this.ListaDesordenada.ItemHeight = 20;
            this.ListaDesordenada.Location = new System.Drawing.Point(6, 25);
            this.ListaDesordenada.Name = "ListaDesordenada";
            this.ListaDesordenada.Size = new System.Drawing.Size(210, 204);
            this.ListaDesordenada.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.listaOrdenada);
            this.groupBox5.Location = new System.Drawing.Point(1034, 316);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(222, 216);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Datos ordenados";
            // 
            // listaOrdenada
            // 
            this.listaOrdenada.FormattingEnabled = true;
            this.listaOrdenada.HorizontalScrollbar = true;
            this.listaOrdenada.ItemHeight = 20;
            this.listaOrdenada.Location = new System.Drawing.Point(6, 25);
            this.listaOrdenada.Name = "listaOrdenada";
            this.listaOrdenada.Size = new System.Drawing.Size(204, 184);
            this.listaOrdenada.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // limpiarLista
            // 
            this.limpiarLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpiarLista.Location = new System.Drawing.Point(35, 235);
            this.limpiarLista.Name = "limpiarLista";
            this.limpiarLista.Size = new System.Drawing.Size(154, 41);
            this.limpiarLista.TabIndex = 3;
            this.limpiarLista.Text = "Limpiar lista";
            this.limpiarLista.UseVisualStyleBackColor = true;
            this.limpiarLista.Click += new System.EventHandler(this.nuevoVector_Click);
            // 
            // reanudar
            // 
            this.reanudar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reanudar.Location = new System.Drawing.Point(64, 464);
            this.reanudar.Name = "reanudar";
            this.reanudar.Size = new System.Drawing.Size(183, 41);
            this.reanudar.TabIndex = 3;
            this.reanudar.Text = "Reanudar";
            this.reanudar.UseVisualStyleBackColor = true;
            this.reanudar.Click += new System.EventHandler(this.reanudar_Click);
            // 
            // pausar
            // 
            this.pausar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pausar.Location = new System.Drawing.Point(281, 464);
            this.pausar.Name = "pausar";
            this.pausar.Size = new System.Drawing.Size(183, 41);
            this.pausar.TabIndex = 4;
            this.pausar.Text = "Pausar";
            this.pausar.UseVisualStyleBackColor = true;
            this.pausar.Click += new System.EventHandler(this.pausar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 544);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grafico)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox entrada;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox ListaDesordenada;
        private System.Windows.Forms.Button peine;
        private System.Windows.Forms.Button seleccion;
        private System.Windows.Forms.Button monticulos;
        private System.Windows.Forms.Button mezcla;
        private System.Windows.Forms.Button shell;
        private System.Windows.Forms.Button bidimensional;
        private System.Windows.Forms.Button gnome;
        private System.Windows.Forms.Button burbuja;
        private System.Windows.Forms.Button rapido;
        private System.Windows.Forms.Button insercion;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListBox listaOrdenada;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafico;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.Button limpiarLista;
        private System.Windows.Forms.Button pausar;
        private System.Windows.Forms.Button reanudar;
    }
}

