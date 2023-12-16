namespace WindowsFormsApplication7
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
            this.label2 = new System.Windows.Forms.Label();
            this.salida = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.aceptar = new System.Windows.Forms.Button();
            this.entrada = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.b_Sumatoria = new System.Windows.Forms.Button();
            this.b_Medir_Serie_Pares = new System.Windows.Forms.Button();
            this.tiempo = new System.Windows.Forms.Timer(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.s_Tiempo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Int el valor de N";
            // 
            // salida
            // 
            this.salida.AutoSize = true;
            this.salida.Location = new System.Drawing.Point(53, 51);
            this.salida.Name = "salida";
            this.salida.Size = new System.Drawing.Size(227, 38);
            this.salida.TabIndex = 2;
            this.salida.Text = "Resultado del proceso";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.aceptar);
            this.groupBox1.Controls.Add(this.entrada);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Uighur", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 97);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entrada";
            // 
            // aceptar
            // 
            this.aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aceptar.Location = new System.Drawing.Point(352, 41);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(81, 27);
            this.aceptar.TabIndex = 3;
            this.aceptar.Text = "Aceptar";
            this.aceptar.UseVisualStyleBackColor = true;
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // entrada
            // 
            this.entrada.Location = new System.Drawing.Point(225, 37);
            this.entrada.Name = "entrada";
            this.entrada.Size = new System.Drawing.Size(100, 42);
            this.entrada.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.b_Sumatoria);
            this.groupBox2.Controls.Add(this.b_Medir_Serie_Pares);
            this.groupBox2.Controls.Add(this.salida);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Uighur", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Teal;
            this.groupBox2.Location = new System.Drawing.Point(12, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(487, 237);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Proceso";
            // 
            // b_Sumatoria
            // 
            this.b_Sumatoria.Location = new System.Drawing.Point(98, 175);
            this.b_Sumatoria.Name = "b_Sumatoria";
            this.b_Sumatoria.Size = new System.Drawing.Size(284, 44);
            this.b_Sumatoria.TabIndex = 5;
            this.b_Sumatoria.Text = "Sumatoria 1+2+3+4+...+n";
            this.b_Sumatoria.UseVisualStyleBackColor = true;
            this.b_Sumatoria.Click += new System.EventHandler(this.b_Sumatoria_Click);
            // 
            // b_Medir_Serie_Pares
            // 
            this.b_Medir_Serie_Pares.Location = new System.Drawing.Point(98, 108);
            this.b_Medir_Serie_Pares.Name = "b_Medir_Serie_Pares";
            this.b_Medir_Serie_Pares.Size = new System.Drawing.Size(284, 44);
            this.b_Medir_Serie_Pares.TabIndex = 4;
            this.b_Medir_Serie_Pares.Text = "Medir Serie Pares";
            this.b_Medir_Serie_Pares.UseVisualStyleBackColor = true;
            this.b_Medir_Serie_Pares.Click += new System.EventHandler(this.b_Medir_Serie_Pares_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.s_Tiempo);
            this.groupBox3.Location = new System.Drawing.Point(12, 370);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(487, 76);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tiempo de ejecuciones";
            // 
            // s_Tiempo
            // 
            this.s_Tiempo.AutoSize = true;
            this.s_Tiempo.Location = new System.Drawing.Point(211, 20);
            this.s_Tiempo.Name = "s_Tiempo";
            this.s_Tiempo.Size = new System.Drawing.Size(38, 13);
            this.s_Tiempo.TabIndex = 0;
            this.s_Tiempo.Text = "tiempo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 458);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label salida;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button aceptar;
        private System.Windows.Forms.TextBox entrada;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button b_Sumatoria;
        private System.Windows.Forms.Button b_Medir_Serie_Pares;
        private System.Windows.Forms.Timer tiempo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label s_Tiempo;

    }
}

