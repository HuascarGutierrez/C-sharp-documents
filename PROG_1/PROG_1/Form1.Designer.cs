namespace PROG_1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.aceptar = new System.Windows.Forms.Button();
            this.entrada = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.salida = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.serie_2 = new System.Windows.Forms.Button();
            this.serie_1 = new System.Windows.Forms.Button();
            this.impares = new System.Windows.Forms.Button();
            this.pares = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lista = new System.Windows.Forms.ListBox();
            this.limpiar = new System.Windows.Forms.Button();
            this.ingresar = new System.Windows.Forms.Button();
            this.nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.aceptar);
            this.groupBox1.Controls.Add(this.entrada);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 73);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entrada";
            // 
            // aceptar
            // 
            this.aceptar.ForeColor = System.Drawing.Color.Gray;
            this.aceptar.Location = new System.Drawing.Point(291, 34);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(81, 27);
            this.aceptar.TabIndex = 2;
            this.aceptar.Text = "Aceptar";
            this.aceptar.UseVisualStyleBackColor = true;
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // entrada
            // 
            this.entrada.BackColor = System.Drawing.SystemColors.Menu;
            this.entrada.ForeColor = System.Drawing.Color.Gray;
            this.entrada.Location = new System.Drawing.Point(185, 32);
            this.entrada.Name = "entrada";
            this.entrada.Size = new System.Drawing.Size(100, 29);
            this.entrada.TabIndex = 1;
            this.entrada.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduzca un numero";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.salida);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.groupBox2.Location = new System.Drawing.Point(12, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(378, 62);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Salida";
            // 
            // salida
            // 
            this.salida.AutoSize = true;
            this.salida.ForeColor = System.Drawing.Color.Gray;
            this.salida.Location = new System.Drawing.Point(16, 25);
            this.salida.Name = "salida";
            this.salida.Size = new System.Drawing.Size(83, 21);
            this.salida.TabIndex = 1;
            this.salida.Text = "En espera";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.serie_2);
            this.groupBox3.Controls.Add(this.serie_1);
            this.groupBox3.Controls.Add(this.impares);
            this.groupBox3.Controls.Add(this.pares);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.groupBox3.Location = new System.Drawing.Point(12, 179);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(210, 189);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Opciones";
            // 
            // serie_2
            // 
            this.serie_2.BackColor = System.Drawing.SystemColors.Menu;
            this.serie_2.ForeColor = System.Drawing.Color.DimGray;
            this.serie_2.Location = new System.Drawing.Point(10, 139);
            this.serie_2.Name = "serie_2";
            this.serie_2.Size = new System.Drawing.Size(157, 31);
            this.serie_2.TabIndex = 3;
            this.serie_2.Text = "0, 1, 1, 2, 3, 24, 120, ...";
            this.serie_2.UseVisualStyleBackColor = false;
            this.serie_2.Click += new System.EventHandler(this.serie_2_Click);
            // 
            // serie_1
            // 
            this.serie_1.BackColor = System.Drawing.SystemColors.Menu;
            this.serie_1.ForeColor = System.Drawing.Color.DimGray;
            this.serie_1.Location = new System.Drawing.Point(10, 102);
            this.serie_1.Name = "serie_1";
            this.serie_1.Size = new System.Drawing.Size(157, 31);
            this.serie_1.TabIndex = 2;
            this.serie_1.Text = "0, 1, 1, 2, 3, 5, ...";
            this.serie_1.UseVisualStyleBackColor = false;
            this.serie_1.Click += new System.EventHandler(this.serie_1_Click);
            // 
            // impares
            // 
            this.impares.BackColor = System.Drawing.SystemColors.Menu;
            this.impares.ForeColor = System.Drawing.Color.DimGray;
            this.impares.Location = new System.Drawing.Point(10, 65);
            this.impares.Name = "impares";
            this.impares.Size = new System.Drawing.Size(157, 31);
            this.impares.TabIndex = 1;
            this.impares.Text = "1, 3, 5, 7, 9, ...";
            this.impares.UseVisualStyleBackColor = false;
            this.impares.Click += new System.EventHandler(this.impares_Click);
            // 
            // pares
            // 
            this.pares.BackColor = System.Drawing.SystemColors.Menu;
            this.pares.ForeColor = System.Drawing.Color.DimGray;
            this.pares.Location = new System.Drawing.Point(10, 28);
            this.pares.Name = "pares";
            this.pares.Size = new System.Drawing.Size(157, 31);
            this.pares.TabIndex = 0;
            this.pares.Text = "0, 2, 4, 6, 8, 10, ...";
            this.pares.UseVisualStyleBackColor = false;
            this.pares.Click += new System.EventHandler(this.pares_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ingresar);
            this.groupBox4.Controls.Add(this.limpiar);
            this.groupBox4.Controls.Add(this.lista);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(228, 179);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(162, 189);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Lista";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // lista
            // 
            this.lista.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lista.FormattingEnabled = true;
            this.lista.ItemHeight = 20;
            this.lista.Items.AddRange(new object[] {
            "Ana ",
            "Jose  ",
            "Pedro",
            "Luisa ",
            "Esteban"});
            this.lista.Location = new System.Drawing.Point(16, 29);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(120, 124);
            this.lista.TabIndex = 0;
            this.lista.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(0, 160);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(69, 29);
            this.limpiar.TabIndex = 1;
            this.limpiar.Text = "Limpiar";
            this.limpiar.UseVisualStyleBackColor = true;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // ingresar
            // 
            this.ingresar.Location = new System.Drawing.Point(76, 160);
            this.ingresar.Name = "ingresar";
            this.ingresar.Size = new System.Drawing.Size(80, 29);
            this.ingresar.TabIndex = 2;
            this.ingresar.Text = "Ingresar";
            this.ingresar.UseVisualStyleBackColor = true;
            this.ingresar.Click += new System.EventHandler(this.ingresar_Click);
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(184, 415);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(200, 20);
            this.nombre.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 418);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ingrese su nombre:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(408, 447);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Programa";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox entrada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button aceptar;
        private System.Windows.Forms.Label salida;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button serie_2;
        private System.Windows.Forms.Button serie_1;
        private System.Windows.Forms.Button impares;
        private System.Windows.Forms.Button pares;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.Button ingresar;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label label2;
    }
}

