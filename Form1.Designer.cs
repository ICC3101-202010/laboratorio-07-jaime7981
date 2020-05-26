namespace Calculadora
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
            this.BotonHistorial = new System.Windows.Forms.Button();
            this.BotonBorrar = new System.Windows.Forms.Button();
            this.BotonOcho = new System.Windows.Forms.Button();
            this.BotonSiete = new System.Windows.Forms.Button();
            this.BotonDos = new System.Windows.Forms.Button();
            this.BotonUno = new System.Windows.Forms.Button();
            this.BotonCinco = new System.Windows.Forms.Button();
            this.BotonCuatro = new System.Windows.Forms.Button();
            this.BotonTres = new System.Windows.Forms.Button();
            this.BotonSeis = new System.Windows.Forms.Button();
            this.BotonNueve = new System.Windows.Forms.Button();
            this.BotonClear = new System.Windows.Forms.Button();
            this.BotonSuma = new System.Windows.Forms.Button();
            this.BotonResta = new System.Windows.Forms.Button();
            this.BotonMultiplicacion = new System.Windows.Forms.Button();
            this.BotonDivision = new System.Windows.Forms.Button();
            this.BotonIgual = new System.Windows.Forms.Button();
            this.BotonCero = new System.Windows.Forms.Button();
            this.BotonComa = new System.Windows.Forms.Button();
            this.CajaDeNumeros = new System.Windows.Forms.TextBox();
            this.CajaResultadoAnterior = new System.Windows.Forms.TextBox();
            this.ListaHistorial = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BotonVoler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BotonHistorial
            // 
            this.BotonHistorial.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonHistorial.Location = new System.Drawing.Point(12, 122);
            this.BotonHistorial.Name = "BotonHistorial";
            this.BotonHistorial.Size = new System.Drawing.Size(88, 72);
            this.BotonHistorial.TabIndex = 0;
            this.BotonHistorial.Text = "Historial";
            this.BotonHistorial.UseVisualStyleBackColor = true;
            this.BotonHistorial.Click += new System.EventHandler(this.BotonHistorial_Click);
            // 
            // BotonBorrar
            // 
            this.BotonBorrar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonBorrar.Location = new System.Drawing.Point(106, 122);
            this.BotonBorrar.Name = "BotonBorrar";
            this.BotonBorrar.Size = new System.Drawing.Size(90, 72);
            this.BotonBorrar.TabIndex = 1;
            this.BotonBorrar.Text = "CE";
            this.BotonBorrar.UseVisualStyleBackColor = true;
            this.BotonBorrar.Click += new System.EventHandler(this.BotonBorrar_Click);
            // 
            // BotonOcho
            // 
            this.BotonOcho.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonOcho.Location = new System.Drawing.Point(106, 200);
            this.BotonOcho.Name = "BotonOcho";
            this.BotonOcho.Size = new System.Drawing.Size(90, 72);
            this.BotonOcho.TabIndex = 3;
            this.BotonOcho.Text = "8";
            this.BotonOcho.UseVisualStyleBackColor = true;
            this.BotonOcho.Click += new System.EventHandler(this.Number_Click);
            // 
            // BotonSiete
            // 
            this.BotonSiete.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonSiete.Location = new System.Drawing.Point(12, 200);
            this.BotonSiete.Name = "BotonSiete";
            this.BotonSiete.Size = new System.Drawing.Size(88, 72);
            this.BotonSiete.TabIndex = 2;
            this.BotonSiete.Text = "7";
            this.BotonSiete.UseVisualStyleBackColor = true;
            this.BotonSiete.Click += new System.EventHandler(this.Number_Click);
            // 
            // BotonDos
            // 
            this.BotonDos.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonDos.Location = new System.Drawing.Point(106, 356);
            this.BotonDos.Name = "BotonDos";
            this.BotonDos.Size = new System.Drawing.Size(90, 72);
            this.BotonDos.TabIndex = 7;
            this.BotonDos.Text = "2";
            this.BotonDos.UseVisualStyleBackColor = true;
            this.BotonDos.Click += new System.EventHandler(this.Number_Click);
            // 
            // BotonUno
            // 
            this.BotonUno.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonUno.Location = new System.Drawing.Point(12, 356);
            this.BotonUno.Name = "BotonUno";
            this.BotonUno.Size = new System.Drawing.Size(88, 72);
            this.BotonUno.TabIndex = 6;
            this.BotonUno.Text = "1";
            this.BotonUno.UseVisualStyleBackColor = true;
            this.BotonUno.Click += new System.EventHandler(this.Number_Click);
            // 
            // BotonCinco
            // 
            this.BotonCinco.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonCinco.Location = new System.Drawing.Point(106, 278);
            this.BotonCinco.Name = "BotonCinco";
            this.BotonCinco.Size = new System.Drawing.Size(90, 72);
            this.BotonCinco.TabIndex = 5;
            this.BotonCinco.Text = "5";
            this.BotonCinco.UseVisualStyleBackColor = true;
            this.BotonCinco.Click += new System.EventHandler(this.Number_Click);
            // 
            // BotonCuatro
            // 
            this.BotonCuatro.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonCuatro.Location = new System.Drawing.Point(12, 278);
            this.BotonCuatro.Name = "BotonCuatro";
            this.BotonCuatro.Size = new System.Drawing.Size(88, 72);
            this.BotonCuatro.TabIndex = 4;
            this.BotonCuatro.Text = "4";
            this.BotonCuatro.UseVisualStyleBackColor = true;
            this.BotonCuatro.Click += new System.EventHandler(this.Number_Click);
            // 
            // BotonTres
            // 
            this.BotonTres.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonTres.Location = new System.Drawing.Point(202, 356);
            this.BotonTres.Name = "BotonTres";
            this.BotonTres.Size = new System.Drawing.Size(90, 72);
            this.BotonTres.TabIndex = 11;
            this.BotonTres.Text = "3";
            this.BotonTres.UseVisualStyleBackColor = true;
            this.BotonTres.Click += new System.EventHandler(this.Number_Click);
            // 
            // BotonSeis
            // 
            this.BotonSeis.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonSeis.Location = new System.Drawing.Point(202, 278);
            this.BotonSeis.Name = "BotonSeis";
            this.BotonSeis.Size = new System.Drawing.Size(90, 72);
            this.BotonSeis.TabIndex = 10;
            this.BotonSeis.Text = "6";
            this.BotonSeis.UseVisualStyleBackColor = true;
            this.BotonSeis.Click += new System.EventHandler(this.Number_Click);
            // 
            // BotonNueve
            // 
            this.BotonNueve.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonNueve.Location = new System.Drawing.Point(202, 200);
            this.BotonNueve.Name = "BotonNueve";
            this.BotonNueve.Size = new System.Drawing.Size(90, 72);
            this.BotonNueve.TabIndex = 9;
            this.BotonNueve.Text = "9";
            this.BotonNueve.UseVisualStyleBackColor = true;
            this.BotonNueve.Click += new System.EventHandler(this.Number_Click);
            // 
            // BotonClear
            // 
            this.BotonClear.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonClear.Location = new System.Drawing.Point(202, 122);
            this.BotonClear.Name = "BotonClear";
            this.BotonClear.Size = new System.Drawing.Size(90, 72);
            this.BotonClear.TabIndex = 8;
            this.BotonClear.Text = "C";
            this.BotonClear.UseVisualStyleBackColor = true;
            this.BotonClear.Click += new System.EventHandler(this.BotonClear_Click);
            // 
            // BotonSuma
            // 
            this.BotonSuma.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonSuma.Location = new System.Drawing.Point(298, 356);
            this.BotonSuma.Name = "BotonSuma";
            this.BotonSuma.Size = new System.Drawing.Size(90, 72);
            this.BotonSuma.TabIndex = 15;
            this.BotonSuma.Text = "+";
            this.BotonSuma.UseVisualStyleBackColor = true;
            this.BotonSuma.Click += new System.EventHandler(this.Operador_Click);
            // 
            // BotonResta
            // 
            this.BotonResta.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonResta.Location = new System.Drawing.Point(298, 278);
            this.BotonResta.Name = "BotonResta";
            this.BotonResta.Size = new System.Drawing.Size(90, 72);
            this.BotonResta.TabIndex = 14;
            this.BotonResta.Text = "-";
            this.BotonResta.UseVisualStyleBackColor = true;
            this.BotonResta.Click += new System.EventHandler(this.Operador_Click);
            // 
            // BotonMultiplicacion
            // 
            this.BotonMultiplicacion.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonMultiplicacion.Location = new System.Drawing.Point(298, 200);
            this.BotonMultiplicacion.Name = "BotonMultiplicacion";
            this.BotonMultiplicacion.Size = new System.Drawing.Size(90, 72);
            this.BotonMultiplicacion.TabIndex = 13;
            this.BotonMultiplicacion.Text = "*";
            this.BotonMultiplicacion.UseVisualStyleBackColor = true;
            this.BotonMultiplicacion.Click += new System.EventHandler(this.Operador_Click);
            // 
            // BotonDivision
            // 
            this.BotonDivision.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonDivision.Location = new System.Drawing.Point(298, 122);
            this.BotonDivision.Name = "BotonDivision";
            this.BotonDivision.Size = new System.Drawing.Size(90, 72);
            this.BotonDivision.TabIndex = 12;
            this.BotonDivision.Text = "/";
            this.BotonDivision.UseVisualStyleBackColor = true;
            this.BotonDivision.Click += new System.EventHandler(this.Operador_Click);
            // 
            // BotonIgual
            // 
            this.BotonIgual.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonIgual.Location = new System.Drawing.Point(202, 434);
            this.BotonIgual.Name = "BotonIgual";
            this.BotonIgual.Size = new System.Drawing.Size(186, 72);
            this.BotonIgual.TabIndex = 19;
            this.BotonIgual.Text = "=";
            this.BotonIgual.UseVisualStyleBackColor = true;
            this.BotonIgual.Click += new System.EventHandler(this.BotonIgual_Click);
            // 
            // BotonCero
            // 
            this.BotonCero.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonCero.Location = new System.Drawing.Point(106, 434);
            this.BotonCero.Name = "BotonCero";
            this.BotonCero.Size = new System.Drawing.Size(90, 72);
            this.BotonCero.TabIndex = 17;
            this.BotonCero.Text = "0";
            this.BotonCero.UseVisualStyleBackColor = true;
            this.BotonCero.Click += new System.EventHandler(this.Number_Click);
            // 
            // BotonComa
            // 
            this.BotonComa.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonComa.Location = new System.Drawing.Point(12, 434);
            this.BotonComa.Name = "BotonComa";
            this.BotonComa.Size = new System.Drawing.Size(88, 72);
            this.BotonComa.TabIndex = 16;
            this.BotonComa.Text = ",";
            this.BotonComa.UseVisualStyleBackColor = true;
            this.BotonComa.Click += new System.EventHandler(this.Number_Click);
            // 
            // CajaDeNumeros
            // 
            this.CajaDeNumeros.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CajaDeNumeros.Location = new System.Drawing.Point(12, 73);
            this.CajaDeNumeros.Multiline = true;
            this.CajaDeNumeros.Name = "CajaDeNumeros";
            this.CajaDeNumeros.Size = new System.Drawing.Size(376, 43);
            this.CajaDeNumeros.TabIndex = 20;
            this.CajaDeNumeros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CajaResultadoAnterior
            // 
            this.CajaResultadoAnterior.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CajaResultadoAnterior.Location = new System.Drawing.Point(12, 22);
            this.CajaResultadoAnterior.Multiline = true;
            this.CajaResultadoAnterior.Name = "CajaResultadoAnterior";
            this.CajaResultadoAnterior.Size = new System.Drawing.Size(376, 45);
            this.CajaResultadoAnterior.TabIndex = 22;
            this.CajaResultadoAnterior.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ListaHistorial
            // 
            this.ListaHistorial.FormattingEnabled = true;
            this.ListaHistorial.Location = new System.Drawing.Point(12, 122);
            this.ListaHistorial.Name = "ListaHistorial";
            this.ListaHistorial.Size = new System.Drawing.Size(376, 394);
            this.ListaHistorial.TabIndex = 23;
            this.ListaHistorial.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(22, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 23);
            this.label1.TabIndex = 24;
            this.label1.Text = "Ultimo Resultado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(22, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 23);
            this.label2.TabIndex = 25;
            this.label2.Text = "Resultado";
            // 
            // BotonVoler
            // 
            this.BotonVoler.Location = new System.Drawing.Point(324, 122);
            this.BotonVoler.Name = "BotonVoler";
            this.BotonVoler.Size = new System.Drawing.Size(64, 30);
            this.BotonVoler.TabIndex = 26;
            this.BotonVoler.Text = "Volver";
            this.BotonVoler.UseVisualStyleBackColor = true;
            this.BotonVoler.Visible = false;
            this.BotonVoler.Click += new System.EventHandler(this.BotonVoler_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 524);
            this.Controls.Add(this.ListaHistorial);
            this.Controls.Add(this.BotonVoler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CajaResultadoAnterior);
            this.Controls.Add(this.CajaDeNumeros);
            this.Controls.Add(this.BotonIgual);
            this.Controls.Add(this.BotonCero);
            this.Controls.Add(this.BotonComa);
            this.Controls.Add(this.BotonSuma);
            this.Controls.Add(this.BotonResta);
            this.Controls.Add(this.BotonMultiplicacion);
            this.Controls.Add(this.BotonDivision);
            this.Controls.Add(this.BotonTres);
            this.Controls.Add(this.BotonSeis);
            this.Controls.Add(this.BotonNueve);
            this.Controls.Add(this.BotonClear);
            this.Controls.Add(this.BotonDos);
            this.Controls.Add(this.BotonUno);
            this.Controls.Add(this.BotonCinco);
            this.Controls.Add(this.BotonCuatro);
            this.Controls.Add(this.BotonOcho);
            this.Controls.Add(this.BotonSiete);
            this.Controls.Add(this.BotonBorrar);
            this.Controls.Add(this.BotonHistorial);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BotonHistorial;
        private System.Windows.Forms.Button BotonBorrar;
        private System.Windows.Forms.Button BotonOcho;
        private System.Windows.Forms.Button BotonSiete;
        private System.Windows.Forms.Button BotonDos;
        private System.Windows.Forms.Button BotonUno;
        private System.Windows.Forms.Button BotonCinco;
        private System.Windows.Forms.Button BotonCuatro;
        private System.Windows.Forms.Button BotonTres;
        private System.Windows.Forms.Button BotonSeis;
        private System.Windows.Forms.Button BotonNueve;
        private System.Windows.Forms.Button BotonClear;
        private System.Windows.Forms.Button BotonSuma;
        private System.Windows.Forms.Button BotonResta;
        private System.Windows.Forms.Button BotonMultiplicacion;
        private System.Windows.Forms.Button BotonDivision;
        private System.Windows.Forms.Button BotonIgual;
        private System.Windows.Forms.Button BotonCero;
        private System.Windows.Forms.Button BotonComa;
        private System.Windows.Forms.TextBox CajaDeNumeros;
        private System.Windows.Forms.TextBox CajaResultadoAnterior;
        private System.Windows.Forms.ListBox ListaHistorial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BotonVoler;
    }
}

