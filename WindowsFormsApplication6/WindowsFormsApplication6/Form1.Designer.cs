namespace WindowsFormsApplication6
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
            this.tiempo = new System.Windows.Forms.Timer(this.components);
            this.cont = new System.Windows.Forms.Label();
            this.inicio = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.boom = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boom)).BeginInit();
            this.SuspendLayout();
            // 
            // tiempo
            // 
            this.tiempo.Tick += new System.EventHandler(this.tiempo_Tick);
            // 
            // cont
            // 
            this.cont.AutoSize = true;
            this.cont.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cont.ForeColor = System.Drawing.Color.Red;
            this.cont.Location = new System.Drawing.Point(294, 265);
            this.cont.Name = "cont";
            this.cont.Size = new System.Drawing.Size(22, 26);
            this.cont.TabIndex = 0;
            this.cont.Text = "0";
            this.cont.Click += new System.EventHandler(this.label1_Click);
            // 
            // inicio
            // 
            this.inicio.ForeColor = System.Drawing.Color.Red;
            this.inicio.Location = new System.Drawing.Point(257, 294);
            this.inicio.Name = "inicio";
            this.inicio.Size = new System.Drawing.Size(97, 33);
            this.inicio.TabIndex = 1;
            this.inicio.Text = "Inicio";
            this.inicio.UseVisualStyleBackColor = true;
            this.inicio.Click += new System.EventHandler(this.button1_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(153, 333);
            this.trackBar1.Minimum = -10;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(307, 45);
            this.trackBar1.TabIndex = 3;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // boom
            // 
            this.boom.Image = global::WindowsFormsApplication6.Properties.Resources._1;
            this.boom.Location = new System.Drawing.Point(105, 12);
            this.boom.Name = "boom";
            this.boom.Size = new System.Drawing.Size(416, 250);
            this.boom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boom.TabIndex = 2;
            this.boom.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 418);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.boom);
            this.Controls.Add(this.inicio);
            this.Controls.Add(this.cont);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cont;
        private System.Windows.Forms.Button inicio;
        private System.Windows.Forms.PictureBox boom;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Timer tiempo;
    }
}

