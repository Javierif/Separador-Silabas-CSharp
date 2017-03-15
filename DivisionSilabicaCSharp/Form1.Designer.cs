namespace DivisionSilabicaCSharp
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
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
            this.btnSeparar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.tbSilabas = new System.Windows.Forms.TextBox();
            this.tbPalabras = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSeparar
            // 
            this.btnSeparar.Location = new System.Drawing.Point(153, 90);
            this.btnSeparar.Name = "btnSeparar";
            this.btnSeparar.Size = new System.Drawing.Size(127, 49);
            this.btnSeparar.TabIndex = 0;
            this.btnSeparar.Text = "Separar";
            this.btnSeparar.UseVisualStyleBackColor = true;
            this.btnSeparar.Click += new System.EventHandler(this.btnSeparar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(12, 90);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(128, 49);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // tbSilabas
            // 
            this.tbSilabas.Location = new System.Drawing.Point(12, 64);
            this.tbSilabas.Name = "tbSilabas";
            this.tbSilabas.Size = new System.Drawing.Size(268, 20);
            this.tbSilabas.TabIndex = 2;
            // 
            // tbPalabras
            // 
            this.tbPalabras.Location = new System.Drawing.Point(12, 25);
            this.tbPalabras.Name = "tbPalabras";
            this.tbPalabras.Size = new System.Drawing.Size(268, 20);
            this.tbPalabras.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Palabra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Silabas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 141);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPalabras);
            this.Controls.Add(this.tbSilabas);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnSeparar);
            this.Name = "Form1";
            this.Text = "Separador Silabico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSeparar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox tbSilabas;
        private System.Windows.Forms.TextBox tbPalabras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

