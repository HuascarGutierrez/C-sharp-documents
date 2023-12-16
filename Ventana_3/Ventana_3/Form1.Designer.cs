namespace Ventana_3
{
    partial class Ventana_3
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.datos_G = new System.Windows.Forms.TabPage();
            this.datos_p = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.f_nacimiento = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.datos_u = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.datos_G.SuspendLayout();
            this.datos_p.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.datos_u.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(104, 210);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(163, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Perú";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.datos_G);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(8, 16);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(528, 329);
            this.tabControl1.TabIndex = 1;
            // 
            // datos_G
            // 
            this.datos_G.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.datos_G.Controls.Add(this.datos_p);
            this.datos_G.Controls.Add(this.datos_u);
            this.datos_G.Location = new System.Drawing.Point(4, 22);
            this.datos_G.Margin = new System.Windows.Forms.Padding(2);
            this.datos_G.Name = "datos_G";
            this.datos_G.Padding = new System.Windows.Forms.Padding(2);
            this.datos_G.Size = new System.Drawing.Size(520, 303);
            this.datos_G.TabIndex = 0;
            this.datos_G.Text = "Datos Generales ";
            this.datos_G.UseVisualStyleBackColor = true;
            // 
            // datos_p
            // 
            this.datos_p.Controls.Add(this.checkBox1);
            this.datos_p.Controls.Add(this.fecha);
            this.datos_p.Controls.Add(this.f_nacimiento);
            this.datos_p.Controls.Add(this.pictureBox1);
            this.datos_p.Location = new System.Drawing.Point(310, 31);
            this.datos_p.Margin = new System.Windows.Forms.Padding(2);
            this.datos_p.Name = "datos_p";
            this.datos_p.Padding = new System.Windows.Forms.Padding(2);
            this.datos_p.Size = new System.Drawing.Size(185, 256);
            this.datos_p.TabIndex = 2;
            this.datos_p.TabStop = false;
            this.datos_p.Text = "Datos del Perfil";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(23, 214);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(152, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Desea Mostrar estos datos";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // fecha
            // 
            this.fecha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fecha.Checked = false;
            this.fecha.CustomFormat = "01/11/2014";
            this.fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fecha.Location = new System.Drawing.Point(23, 187);
            this.fecha.Margin = new System.Windows.Forms.Padding(2);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(97, 20);
            this.fecha.TabIndex = 2;
            this.fecha.Value = new System.DateTime(2023, 2, 14, 0, 0, 0, 0);
            // 
            // f_nacimiento
            // 
            this.f_nacimiento.AutoSize = true;
            this.f_nacimiento.Location = new System.Drawing.Point(21, 164);
            this.f_nacimiento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.f_nacimiento.Name = "f_nacimiento";
            this.f_nacimiento.Size = new System.Drawing.Size(96, 13);
            this.f_nacimiento.TabIndex = 1;
            this.f_nacimiento.Text = "Fecha Nacimiento:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::Ventana_3.Properties.Resources.Daco_50972561;
            this.pictureBox1.Location = new System.Drawing.Point(41, 27);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // datos_u
            // 
            this.datos_u.Controls.Add(this.label5);
            this.datos_u.Controls.Add(this.radioButton2);
            this.datos_u.Controls.Add(this.radioButton1);
            this.datos_u.Controls.Add(this.label4);
            this.datos_u.Controls.Add(this.textBox3);
            this.datos_u.Controls.Add(this.label3);
            this.datos_u.Controls.Add(this.textBox2);
            this.datos_u.Controls.Add(this.label2);
            this.datos_u.Controls.Add(this.textBox1);
            this.datos_u.Controls.Add(this.label1);
            this.datos_u.Controls.Add(this.comboBox1);
            this.datos_u.Location = new System.Drawing.Point(16, 31);
            this.datos_u.Margin = new System.Windows.Forms.Padding(2);
            this.datos_u.Name = "datos_u";
            this.datos_u.Padding = new System.Windows.Forms.Padding(2);
            this.datos_u.Size = new System.Drawing.Size(279, 256);
            this.datos_u.TabIndex = 1;
            this.datos_u.TabStop = false;
            this.datos_u.Text = "Datos del Ususario";
            this.datos_u.Enter += new System.EventHandler(this.datos_u_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 213);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nacionalidad:";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(96, 174);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(71, 17);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.Text = "Femenino";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(96, 155);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(73, 17);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Masculino";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(21, 156);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sexo:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox3.Location = new System.Drawing.Point(104, 108);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(163, 20);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = "Diaz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(21, 109);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Apellido M:";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox2.Location = new System.Drawing.Point(104, 70);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(163, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "Arcila";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(21, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellido P:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox1.Location = new System.Drawing.Point(104, 35);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Juan Carlos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(21, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(520, 303);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Datos Opcionales";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Ventana_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(547, 365);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ventana_3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uso de Formularios";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.datos_G.ResumeLayout(false);
            this.datos_p.ResumeLayout(false);
            this.datos_p.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.datos_u.ResumeLayout(false);
            this.datos_u.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage datos_G;
        private System.Windows.Forms.GroupBox datos_p;
        private System.Windows.Forms.GroupBox datos_u;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.Label f_nacimiento;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

