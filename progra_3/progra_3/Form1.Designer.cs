namespace progra_3
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.frase = new System.Windows.Forms.Label();
            this.aceptar = new System.Windows.Forms.Button();
            this.tamano = new System.Windows.Forms.Button();
            this.pantalla = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.vocales = new System.Windows.Forms.Button();
            this.palabras = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(35, 33);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(469, 63);
            this.textBox1.TabIndex = 0;
            // 
            // frase
            // 
            this.frase.AutoSize = true;
            this.frase.Location = new System.Drawing.Point(35, 14);
            this.frase.Name = "frase";
            this.frase.Size = new System.Drawing.Size(30, 13);
            this.frase.TabIndex = 1;
            this.frase.Text = "frase";
            // 
            // aceptar
            // 
            this.aceptar.Location = new System.Drawing.Point(429, 112);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(75, 23);
            this.aceptar.TabIndex = 3;
            this.aceptar.Text = "aceptar";
            this.aceptar.UseVisualStyleBackColor = true;
            // 
            // tamano
            // 
            this.tamano.Location = new System.Drawing.Point(6, 29);
            this.tamano.Name = "tamano";
            this.tamano.Size = new System.Drawing.Size(182, 23);
            this.tamano.TabIndex = 4;
            this.tamano.Text = "tamano";
            this.tamano.UseVisualStyleBackColor = true;
            // 
            // pantalla
            // 
            this.pantalla.FormattingEnabled = true;
            this.pantalla.Location = new System.Drawing.Point(263, 143);
            this.pantalla.Name = "pantalla";
            this.pantalla.Size = new System.Drawing.Size(241, 121);
            this.pantalla.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.palabras);
            this.groupBox1.Controls.Add(this.vocales);
            this.groupBox1.Controls.Add(this.tamano);
            this.groupBox1.Location = new System.Drawing.Point(35, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 139);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "opciones";
            // 
            // vocales
            // 
            this.vocales.Location = new System.Drawing.Point(6, 58);
            this.vocales.Name = "vocales";
            this.vocales.Size = new System.Drawing.Size(182, 23);
            this.vocales.TabIndex = 5;
            this.vocales.Text = "contar vocales";
            this.vocales.UseVisualStyleBackColor = true;
            // 
            // palabras
            // 
            this.palabras.Location = new System.Drawing.Point(6, 87);
            this.palabras.Name = "palabras";
            this.palabras.Size = new System.Drawing.Size(182, 23);
            this.palabras.TabIndex = 6;
            this.palabras.Text = "contar palabras";
            this.palabras.UseVisualStyleBackColor = true;
            this.palabras.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 283);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pantalla);
            this.Controls.Add(this.aceptar);
            this.Controls.Add(this.frase);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label frase;
        private System.Windows.Forms.Button aceptar;
        private System.Windows.Forms.Button tamano;
        private System.Windows.Forms.ListBox pantalla;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button palabras;
        private System.Windows.Forms.Button vocales;
    }
}

