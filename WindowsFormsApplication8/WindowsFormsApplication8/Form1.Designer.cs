namespace WindowsFormsApplication8
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.grafica = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.baceptar = new System.Windows.Forms.Button();
            this.tentrada = new System.Windows.Forms.TextBox();
            this.bmedirSP = new System.Windows.Forms.Button();
            this.lresultado = new System.Windows.Forms.TextBox();
            this.Lsalidatiempo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grafica)).BeginInit();
            this.SuspendLayout();
            // 
            // grafica
            // 
            chartArea1.Name = "ChartArea1";
            this.grafica.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.grafica.Legends.Add(legend1);
            this.grafica.Location = new System.Drawing.Point(49, 41);
            this.grafica.Name = "grafica";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.grafica.Series.Add(series1);
            this.grafica.Size = new System.Drawing.Size(300, 300);
            this.grafica.TabIndex = 0;
            this.grafica.Text = "chart1";
            this.grafica.Click += new System.EventHandler(this.grafica_Click);
            // 
            // baceptar
            // 
            this.baceptar.Location = new System.Drawing.Point(411, 102);
            this.baceptar.Name = "baceptar";
            this.baceptar.Size = new System.Drawing.Size(75, 23);
            this.baceptar.TabIndex = 1;
            this.baceptar.Text = "aceptar";
            this.baceptar.UseVisualStyleBackColor = true;
            this.baceptar.Click += new System.EventHandler(this.baceptar_Click);
            // 
            // tentrada
            // 
            this.tentrada.Location = new System.Drawing.Point(377, 62);
            this.tentrada.Name = "tentrada";
            this.tentrada.Size = new System.Drawing.Size(136, 20);
            this.tentrada.TabIndex = 2;
            // 
            // bmedirSP
            // 
            this.bmedirSP.Location = new System.Drawing.Point(411, 157);
            this.bmedirSP.Name = "bmedirSP";
            this.bmedirSP.Size = new System.Drawing.Size(75, 23);
            this.bmedirSP.TabIndex = 3;
            this.bmedirSP.Text = "medir";
            this.bmedirSP.UseVisualStyleBackColor = true;
            this.bmedirSP.Click += new System.EventHandler(this.bmedirSP_Click);
            // 
            // lresultado
            // 
            this.lresultado.Location = new System.Drawing.Point(377, 201);
            this.lresultado.Multiline = true;
            this.lresultado.Name = "lresultado";
            this.lresultado.Size = new System.Drawing.Size(136, 103);
            this.lresultado.TabIndex = 4;
            // 
            // Lsalidatiempo
            // 
            this.Lsalidatiempo.Location = new System.Drawing.Point(377, 335);
            this.Lsalidatiempo.Multiline = true;
            this.Lsalidatiempo.Name = "Lsalidatiempo";
            this.Lsalidatiempo.Size = new System.Drawing.Size(136, 63);
            this.Lsalidatiempo.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 435);
            this.Controls.Add(this.Lsalidatiempo);
            this.Controls.Add(this.lresultado);
            this.Controls.Add(this.bmedirSP);
            this.Controls.Add(this.tentrada);
            this.Controls.Add(this.baceptar);
            this.Controls.Add(this.grafica);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.grafica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart grafica;
        private System.Windows.Forms.Button baceptar;
        private System.Windows.Forms.TextBox tentrada;
        private System.Windows.Forms.Button bmedirSP;
        private System.Windows.Forms.TextBox lresultado;
        private System.Windows.Forms.TextBox Lsalidatiempo;
    }
}

