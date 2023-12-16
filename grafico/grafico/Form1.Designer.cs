namespace grafico
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.graficar = new System.Windows.Forms.Button();
            this.grafica = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tiempo = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grafica)).BeginInit();
            this.SuspendLayout();
            // 
            // graficar
            // 
            this.graficar.Location = new System.Drawing.Point(571, 362);
            this.graficar.Name = "graficar";
            this.graficar.Size = new System.Drawing.Size(95, 31);
            this.graficar.TabIndex = 0;
            this.graficar.Text = "Graficar";
            this.graficar.UseVisualStyleBackColor = true;
            this.graficar.Click += new System.EventHandler(this.button1_Click);
            // 
            // grafica
            // 
            chartArea4.Name = "ChartArea1";
            this.grafica.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.grafica.Legends.Add(legend4);
            this.grafica.Location = new System.Drawing.Point(12, 12);
            this.grafica.Name = "grafica";
            series7.BorderWidth = 3;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series7.Legend = "Legend1";
            series7.MarkerBorderWidth = 10;
            series7.MarkerSize = 10;
            series7.Name = "Series1";
            series8.BorderWidth = 3;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series8.Legend = "Legend1";
            series8.Name = "Series2";
            this.grafica.Series.Add(series7);
            this.grafica.Series.Add(series8);
            this.grafica.Size = new System.Drawing.Size(502, 381);
            this.grafica.TabIndex = 1;
            this.grafica.Text = "chart1";
            // 
            // tiempo
            // 
            this.tiempo.Tick += new System.EventHandler(this.tiempo_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 429);
            this.Controls.Add(this.grafica);
            this.Controls.Add(this.graficar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.grafica)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button graficar;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafica;
        private System.Windows.Forms.Timer tiempo;
    }
}

