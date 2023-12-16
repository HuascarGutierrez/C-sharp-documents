namespace grafos
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lAristas = new System.Windows.Forms.ListBox();
            this.lNodos = new System.Windows.Forms.ListBox();
            this.aceptar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.entrada = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.mMatriz = new System.Windows.Forms.Button();
            this.Mat = new System.Windows.Forms.DataGridView();
            this.caminoFinal = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Mat)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lAristas);
            this.groupBox2.Controls.Add(this.lNodos);
            this.groupBox2.Controls.Add(this.aceptar);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.entrada);
            this.groupBox2.Location = new System.Drawing.Point(12, 285);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(705, 181);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "entrada del grafo";
            // 
            // lAristas
            // 
            this.lAristas.FormattingEnabled = true;
            this.lAristas.HorizontalScrollbar = true;
            this.lAristas.Location = new System.Drawing.Point(579, 39);
            this.lAristas.Name = "lAristas";
            this.lAristas.Size = new System.Drawing.Size(120, 95);
            this.lAristas.TabIndex = 6;
            this.lAristas.SelectedIndexChanged += new System.EventHandler(this.lAristas_SelectedIndexChanged);
            // 
            // lNodos
            // 
            this.lNodos.FormattingEnabled = true;
            this.lNodos.Location = new System.Drawing.Point(453, 39);
            this.lNodos.Name = "lNodos";
            this.lNodos.Size = new System.Drawing.Size(120, 95);
            this.lNodos.TabIndex = 5;
            // 
            // aceptar
            // 
            this.aceptar.Location = new System.Drawing.Point(173, 120);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(75, 23);
            this.aceptar.TabIndex = 4;
            this.aceptar.Text = "Aceptar";
            this.aceptar.UseVisualStyleBackColor = true;
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(197, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "nodo";
            // 
            // entrada
            // 
            this.entrada.Location = new System.Drawing.Point(20, 68);
            this.entrada.Multiline = true;
            this.entrada.Name = "entrada";
            this.entrada.Size = new System.Drawing.Size(382, 46);
            this.entrada.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.caminoFinal);
            this.groupBox3.Controls.Add(this.mMatriz);
            this.groupBox3.Controls.Add(this.Mat);
            this.groupBox3.Location = new System.Drawing.Point(12, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(705, 266);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "matriz";
            // 
            // mMatriz
            // 
            this.mMatriz.Location = new System.Drawing.Point(606, 94);
            this.mMatriz.Name = "mMatriz";
            this.mMatriz.Size = new System.Drawing.Size(75, 23);
            this.mMatriz.TabIndex = 1;
            this.mMatriz.Text = "mostrar";
            this.mMatriz.UseVisualStyleBackColor = true;
            this.mMatriz.Click += new System.EventHandler(this.mMatriz_Click);
            // 
            // Mat
            // 
            this.Mat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Mat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Mat.Location = new System.Drawing.Point(20, 19);
            this.Mat.Name = "Mat";
            this.Mat.Size = new System.Drawing.Size(537, 220);
            this.Mat.TabIndex = 0;
            // 
            // caminoFinal
            // 
            this.caminoFinal.AutoSize = true;
            this.caminoFinal.Location = new System.Drawing.Point(576, 153);
            this.caminoFinal.Name = "caminoFinal";
            this.caminoFinal.Size = new System.Drawing.Size(91, 13);
            this.caminoFinal.TabIndex = 2;
            this.caminoFinal.Text = "Camino mas corto";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 478);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Mat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lAristas;
        private System.Windows.Forms.ListBox lNodos;
        private System.Windows.Forms.Button aceptar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox entrada;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView Mat;
        private System.Windows.Forms.Button mMatriz;
        private System.Windows.Forms.Label caminoFinal;
    }
}

