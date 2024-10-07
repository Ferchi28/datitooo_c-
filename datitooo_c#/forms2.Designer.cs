namespace datitooo_c_
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.tbEdad = new System.Windows.Forms.TextBox();
            this.tbEstatura = new System.Windows.Forms.TextBox();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rbHombre = new System.Windows.Forms.RadioButton();
            this.rbMujer = new System.Windows.Forms.RadioButton();
            this.Borrar = new System.Windows.Forms.Button();
            this.Guardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTRO DE DATOS ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Edad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Estatura:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Telefono: ";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(119, 98);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(229, 26);
            this.tbNombre.TabIndex = 6;
            this.tbNombre.TextChanged += new System.EventHandler(this.tbNombre_TextChanged);
            // 
            // tbApellido
            // 
            this.tbApellido.Location = new System.Drawing.Point(119, 142);
            this.tbApellido.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(229, 26);
            this.tbApellido.TabIndex = 7;
            // 
            // tbEdad
            // 
            this.tbEdad.Location = new System.Drawing.Point(119, 192);
            this.tbEdad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbEdad.Name = "tbEdad";
            this.tbEdad.Size = new System.Drawing.Size(112, 26);
            this.tbEdad.TabIndex = 8;
            // 
            // tbEstatura
            // 
            this.tbEstatura.Location = new System.Drawing.Point(119, 250);
            this.tbEstatura.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbEstatura.Name = "tbEstatura";
            this.tbEstatura.Size = new System.Drawing.Size(112, 26);
            this.tbEstatura.TabIndex = 9;
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(119, 302);
            this.tbTelefono.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(206, 26);
            this.tbTelefono.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 396);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Genero";
            // 
            // rbHombre
            // 
            this.rbHombre.AutoSize = true;
            this.rbHombre.Location = new System.Drawing.Point(50, 435);
            this.rbHombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbHombre.Name = "rbHombre";
            this.rbHombre.Size = new System.Drawing.Size(91, 24);
            this.rbHombre.TabIndex = 12;
            this.rbHombre.TabStop = true;
            this.rbHombre.Text = "Hombre";
            this.rbHombre.UseVisualStyleBackColor = true;
            // 
            // rbMujer
            // 
            this.rbMujer.AutoSize = true;
            this.rbMujer.Location = new System.Drawing.Point(187, 435);
            this.rbMujer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbMujer.Name = "rbMujer";
            this.rbMujer.Size = new System.Drawing.Size(73, 24);
            this.rbMujer.TabIndex = 13;
            this.rbMujer.TabStop = true;
            this.rbMujer.Text = "Mujer";
            this.rbMujer.UseVisualStyleBackColor = true;
            // 
            // Borrar
            // 
            this.Borrar.Location = new System.Drawing.Point(264, 519);
            this.Borrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Borrar.Name = "Borrar";
            this.Borrar.Size = new System.Drawing.Size(84, 29);
            this.Borrar.TabIndex = 14;
            this.Borrar.Text = "Borrar";
            this.Borrar.UseVisualStyleBackColor = true;
            this.Borrar.Click += new System.EventHandler(this.Borrar_Click);
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(330, 431);
            this.Guardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(152, 29);
            this.Guardar.TabIndex = 15;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 562);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.Borrar);
            this.Controls.Add(this.rbMujer);
            this.Controls.Add(this.rbHombre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbTelefono);
            this.Controls.Add(this.tbEstatura);
            this.Controls.Add(this.tbEdad);
            this.Controls.Add(this.tbApellido);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.TextBox tbEdad;
        private System.Windows.Forms.TextBox tbEstatura;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbHombre;
        private System.Windows.Forms.RadioButton rbMujer;
        private System.Windows.Forms.Button Borrar;
        private System.Windows.Forms.Button Guardar;
    }
}

