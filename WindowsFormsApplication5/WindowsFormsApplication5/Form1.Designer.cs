namespace WindowsFormsApplication5
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
            this.palabras = new System.Windows.Forms.TextBox();
            this.vocales = new System.Windows.Forms.ListBox();
            this.vocal = new System.Windows.Forms.Button();
            this.palabra = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.inicio = new System.Windows.Forms.NumericUpDown();
            this.final = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cadena = new System.Windows.Forms.Button();
            this.Indice = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.minuscula = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.reem_a = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.reem_b = new System.Windows.Forms.TextBox();
            this.f_trim = new System.Windows.Forms.Button();
            this.contiene = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.contenido = new System.Windows.Forms.TextBox();
            this.cortar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.inicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.final)).BeginInit();
            this.SuspendLayout();
            // 
            // palabras
            // 
            this.palabras.Location = new System.Drawing.Point(38, 30);
            this.palabras.Multiline = true;
            this.palabras.Name = "palabras";
            this.palabras.Size = new System.Drawing.Size(556, 73);
            this.palabras.TabIndex = 0;
            this.palabras.TextChanged += new System.EventHandler(this.frase_TextChanged);
            // 
            // vocales
            // 
            this.vocales.FormattingEnabled = true;
            this.vocales.Location = new System.Drawing.Point(245, 158);
            this.vocales.Name = "vocales";
            this.vocales.Size = new System.Drawing.Size(349, 134);
            this.vocales.TabIndex = 2;
            // 
            // vocal
            // 
            this.vocal.Location = new System.Drawing.Point(69, 141);
            this.vocal.Name = "vocal";
            this.vocal.Size = new System.Drawing.Size(121, 23);
            this.vocal.TabIndex = 3;
            this.vocal.Text = "contar palabras";
            this.vocal.UseVisualStyleBackColor = true;
            this.vocal.Click += new System.EventHandler(this.vocal_Click);
            // 
            // palabra
            // 
            this.palabra.Location = new System.Drawing.Point(69, 170);
            this.palabra.Name = "palabra";
            this.palabra.Size = new System.Drawing.Size(121, 23);
            this.palabra.TabIndex = 4;
            this.palabra.Text = "contar palabras";
            this.palabra.UseVisualStyleBackColor = true;
            this.palabra.Click += new System.EventHandler(this.palabra_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(69, 199);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "tamano";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "opciones";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "frase";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(69, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "MAYUSCULAS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // inicio
            // 
            this.inicio.Location = new System.Drawing.Point(38, 280);
            this.inicio.Name = "inicio";
            this.inicio.Size = new System.Drawing.Size(47, 20);
            this.inicio.TabIndex = 10;
            // 
            // final
            // 
            this.final.Location = new System.Drawing.Point(168, 280);
            this.final.Name = "final";
            this.final.Size = new System.Drawing.Size(47, 20);
            this.final.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "inicio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "final";
            // 
            // cadena
            // 
            this.cadena.Location = new System.Drawing.Point(69, 305);
            this.cadena.Name = "cadena";
            this.cadena.Size = new System.Drawing.Size(121, 23);
            this.cadena.TabIndex = 14;
            this.cadena.Text = "Extraer cadenas";
            this.cadena.UseVisualStyleBackColor = true;
            this.cadena.Click += new System.EventHandler(this.cadena_Click);
            // 
            // Indice
            // 
            this.Indice.Location = new System.Drawing.Point(69, 334);
            this.Indice.Name = "Indice";
            this.Indice.Size = new System.Drawing.Size(121, 23);
            this.Indice.TabIndex = 15;
            this.Indice.Text = "Indice";
            this.Indice.UseVisualStyleBackColor = true;
            this.Indice.Click += new System.EventHandler(this.Indice_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(245, 336);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(80, 20);
            this.textBox1.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(245, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Ingrese el caracter que desear buscar";
            // 
            // minuscula
            // 
            this.minuscula.Location = new System.Drawing.Point(69, 363);
            this.minuscula.Name = "minuscula";
            this.minuscula.Size = new System.Drawing.Size(121, 23);
            this.minuscula.TabIndex = 18;
            this.minuscula.Text = "minusculas";
            this.minuscula.UseVisualStyleBackColor = true;
            this.minuscula.Click += new System.EventHandler(this.minuscula_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(69, 392);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "reemplazar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(242, 373);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Ingrese lo que quiere reemplazar";
            // 
            // reem_a
            // 
            this.reem_a.Location = new System.Drawing.Point(242, 395);
            this.reem_a.Name = "reem_a";
            this.reem_a.Size = new System.Drawing.Size(128, 20);
            this.reem_a.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(434, 373);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Ingrese por lo que quiere reemplazar";
            // 
            // reem_b
            // 
            this.reem_b.Location = new System.Drawing.Point(434, 395);
            this.reem_b.Name = "reem_b";
            this.reem_b.Size = new System.Drawing.Size(117, 20);
            this.reem_b.TabIndex = 22;
            // 
            // f_trim
            // 
            this.f_trim.Location = new System.Drawing.Point(70, 421);
            this.f_trim.Name = "f_trim";
            this.f_trim.Size = new System.Drawing.Size(121, 23);
            this.f_trim.TabIndex = 24;
            this.f_trim.Text = "quitar espacios extra";
            this.f_trim.UseVisualStyleBackColor = true;
            this.f_trim.Click += new System.EventHandler(this.f_trim_Click);
            // 
            // contiene
            // 
            this.contiene.Location = new System.Drawing.Point(69, 450);
            this.contiene.Name = "contiene";
            this.contiene.Size = new System.Drawing.Size(121, 23);
            this.contiene.TabIndex = 25;
            this.contiene.Text = "contiene?";
            this.contiene.UseVisualStyleBackColor = true;
            this.contiene.Click += new System.EventHandler(this.contiene_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(242, 431);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(188, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "ingrese lo que quiere saber si contiene";
            // 
            // contenido
            // 
            this.contenido.Location = new System.Drawing.Point(242, 453);
            this.contenido.Name = "contenido";
            this.contenido.Size = new System.Drawing.Size(128, 20);
            this.contenido.TabIndex = 26;
            // 
            // cortar
            // 
            this.cortar.Location = new System.Drawing.Point(70, 479);
            this.cortar.Name = "cortar";
            this.cortar.Size = new System.Drawing.Size(121, 23);
            this.cortar.TabIndex = 28;
            this.cortar.Text = "split";
            this.cortar.UseVisualStyleBackColor = true;
            this.cortar.Click += new System.EventHandler(this.cortar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 521);
            this.Controls.Add(this.cortar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.contenido);
            this.Controls.Add(this.contiene);
            this.Controls.Add(this.f_trim);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.reem_b);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.reem_a);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.minuscula);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Indice);
            this.Controls.Add(this.cadena);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.final);
            this.Controls.Add(this.inicio);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.palabra);
            this.Controls.Add(this.vocal);
            this.Controls.Add(this.vocales);
            this.Controls.Add(this.palabras);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.inicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.final)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox palabras;
        private System.Windows.Forms.ListBox vocales;
        private System.Windows.Forms.Button vocal;
        private System.Windows.Forms.Button palabra;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown inicio;
        private System.Windows.Forms.NumericUpDown final;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cadena;
        private System.Windows.Forms.Button Indice;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button minuscula;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox reem_a;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox reem_b;
        private System.Windows.Forms.Button f_trim;
        private System.Windows.Forms.Button contiene;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox contenido;
        private System.Windows.Forms.Button cortar;
    }
}

