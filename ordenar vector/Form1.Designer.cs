namespace ordenar_vector
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
            this.btngenerar = new System.Windows.Forms.Button();
            this.btnordenar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstNumeros = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txttamaño = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btngenerar
            // 
            this.btngenerar.Location = new System.Drawing.Point(599, 26);
            this.btngenerar.Name = "btngenerar";
            this.btngenerar.Size = new System.Drawing.Size(68, 35);
            this.btngenerar.TabIndex = 0;
            this.btngenerar.Text = "generar";
            this.btngenerar.UseVisualStyleBackColor = true;
            this.btngenerar.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnordenar
            // 
            this.btnordenar.Location = new System.Drawing.Point(599, 77);
            this.btnordenar.Name = "btnordenar";
            this.btnordenar.Size = new System.Drawing.Size(68, 50);
            this.btnordenar.TabIndex = 1;
            this.btnordenar.Text = "ordenar";
            this.btnordenar.UseVisualStyleBackColor = true;
            this.btnordenar.Click += new System.EventHandler(this.btnordenar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(599, 152);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(68, 39);
            this.btnsalir.TabIndex = 2;
            this.btnsalir.Text = "salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "limite  numeros aleatorios";
            // 
            // lstNumeros
            // 
            this.lstNumeros.FormattingEnabled = true;
            this.lstNumeros.Location = new System.Drawing.Point(74, 77);
            this.lstNumeros.Name = "lstNumeros";
            this.lstNumeros.Size = new System.Drawing.Size(141, 147);
            this.lstNumeros.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "tamaño del vector";
            // 
            // txttamaño
            // 
            this.txttamaño.Location = new System.Drawing.Point(343, 45);
            this.txttamaño.Name = "txttamaño";
            this.txttamaño.Size = new System.Drawing.Size(101, 20);
            this.txttamaño.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txttamaño);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstNumeros);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnordenar);
            this.Controls.Add(this.btngenerar);
            this.Name = "Form1";
            this.Text = "ordenar vector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btngenerar;
        private System.Windows.Forms.Button btnordenar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstNumeros;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttamaño;
    }
}

