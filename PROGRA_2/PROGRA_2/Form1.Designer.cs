namespace PROGRA_2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.aceptar = new System.Windows.Forms.Button();
            this.columnas = new System.Windows.Forms.TextBox();
            this.filas = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.binario = new System.Windows.Forms.Button();
            this.mostrar = new System.Windows.Forms.Button();
            this.estrella = new System.Windows.Forms.Button();
            this.identidad = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tabla = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.aceptar);
            this.groupBox1.Controls.Add(this.columnas);
            this.groupBox1.Controls.Add(this.filas);
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(705, 95);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entrada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Introducir el numero de columnas:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Introducir el numero de filas:";
            // 
            // aceptar
            // 
            this.aceptar.Location = new System.Drawing.Point(624, 39);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(75, 23);
            this.aceptar.TabIndex = 2;
            this.aceptar.Text = "Aceptar";
            this.aceptar.UseVisualStyleBackColor = true;
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // columnas
            // 
            this.columnas.Location = new System.Drawing.Point(511, 58);
            this.columnas.Name = "columnas";
            this.columnas.Size = new System.Drawing.Size(100, 20);
            this.columnas.TabIndex = 1;
            // 
            // filas
            // 
            this.filas.Location = new System.Drawing.Point(511, 19);
            this.filas.Name = "filas";
            this.filas.Size = new System.Drawing.Size(100, 20);
            this.filas.TabIndex = 0;
            this.filas.TextChanged += new System.EventHandler(this.filas_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.binario);
            this.groupBox2.Controls.Add(this.mostrar);
            this.groupBox2.Controls.Add(this.estrella);
            this.groupBox2.Controls.Add(this.identidad);
            this.groupBox2.Location = new System.Drawing.Point(13, 137);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(172, 277);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones";
            // 
            // binario
            // 
            this.binario.Location = new System.Drawing.Point(27, 114);
            this.binario.Name = "binario";
            this.binario.Size = new System.Drawing.Size(75, 23);
            this.binario.TabIndex = 3;
            this.binario.Text = "binario";
            this.binario.UseVisualStyleBackColor = true;
            this.binario.Click += new System.EventHandler(this.binario_Click);
            // 
            // mostrar
            // 
            this.mostrar.Location = new System.Drawing.Point(25, 207);
            this.mostrar.Name = "mostrar";
            this.mostrar.Size = new System.Drawing.Size(75, 23);
            this.mostrar.TabIndex = 2;
            this.mostrar.Text = "MOSTRAR";
            this.mostrar.UseVisualStyleBackColor = true;
            this.mostrar.Click += new System.EventHandler(this.mostrar_Click);
            // 
            // estrella
            // 
            this.estrella.Location = new System.Drawing.Point(25, 73);
            this.estrella.Name = "estrella";
            this.estrella.Size = new System.Drawing.Size(75, 23);
            this.estrella.TabIndex = 1;
            this.estrella.Text = "estrella";
            this.estrella.UseVisualStyleBackColor = true;
            this.estrella.Click += new System.EventHandler(this.matriz_Click);
            // 
            // identidad
            // 
            this.identidad.Location = new System.Drawing.Point(25, 32);
            this.identidad.Name = "identidad";
            this.identidad.Size = new System.Drawing.Size(75, 23);
            this.identidad.TabIndex = 0;
            this.identidad.Text = "identidad";
            this.identidad.UseVisualStyleBackColor = true;
            this.identidad.Click += new System.EventHandler(this.identidad_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tabla);
            this.groupBox3.Location = new System.Drawing.Point(207, 137);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(510, 277);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tabla";
            // 
            // tabla
            // 
            this.tabla.AllowUserToAddRows = false;
            this.tabla.AllowUserToDeleteRows = false;
            this.tabla.AllowUserToResizeColumns = false;
            this.tabla.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tabla.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabla.BackgroundColor = System.Drawing.Color.White;
            this.tabla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tabla.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla.ColumnHeadersVisible = false;
            this.tabla.Cursor = System.Windows.Forms.Cursors.Cross;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(139)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabla.DefaultCellStyle = dataGridViewCellStyle2;
            this.tabla.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(242)))));
            this.tabla.Location = new System.Drawing.Point(18, 19);
            this.tabla.MultiSelect = false;
            this.tabla.Name = "tabla";
            this.tabla.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(162)))), ((int)(((byte)(162)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.tabla.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.tabla.Size = new System.Drawing.Size(486, 258);
            this.tabla.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 440);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button aceptar;
        private System.Windows.Forms.TextBox columnas;
        private System.Windows.Forms.TextBox filas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView tabla;
        private System.Windows.Forms.Button identidad;
        private System.Windows.Forms.Button estrella;
        private System.Windows.Forms.Button mostrar;
        private System.Windows.Forms.Button binario;
    }
}

