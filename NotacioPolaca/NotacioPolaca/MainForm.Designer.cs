namespace NotacioPolaca
{
    partial class MainForm
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
            this.btnPotencia = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnLimipiar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtExpression = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPotencia
            // 
            this.btnPotencia.Location = new System.Drawing.Point(604, 106);
            this.btnPotencia.Name = "btnPotencia";
            this.btnPotencia.Size = new System.Drawing.Size(75, 23);
            this.btnPotencia.TabIndex = 17;
            this.btnPotencia.Text = "^";
            this.btnPotencia.UseVisualStyleBackColor = true;
            this.btnPotencia.Click += new System.EventHandler(this.btnOperador_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(482, 135);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(75, 23);
            this.btnDiv.TabIndex = 16;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnOperador_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Location = new System.Drawing.Point(563, 135);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(75, 23);
            this.btnMultiplicar.TabIndex = 15;
            this.btnMultiplicar.Text = "*";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnOperador_Click);
            // 
            // btnResta
            // 
            this.btnResta.Location = new System.Drawing.Point(523, 106);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(75, 23);
            this.btnResta.TabIndex = 14;
            this.btnResta.Text = "-";
            this.btnResta.UseVisualStyleBackColor = true;
            this.btnResta.Click += new System.EventHandler(this.btnOperador_Click);
            // 
            // btnSuma
            // 
            this.btnSuma.Location = new System.Drawing.Point(442, 106);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(75, 23);
            this.btnSuma.TabIndex = 13;
            this.btnSuma.Text = "+";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnOperador_Click);
            // 
            // btnLimipiar
            // 
            this.btnLimipiar.Location = new System.Drawing.Point(698, 322);
            this.btnLimipiar.Name = "btnLimipiar";
            this.btnLimipiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimipiar.TabIndex = 12;
            this.btnLimipiar.Text = "Limpiar";
            this.btnLimipiar.UseVisualStyleBackColor = true;
            this.btnLimipiar.Click += new System.EventHandler(this.btnLimipiar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(698, 106);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 11;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(27, 156);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(44, 16);
            this.lblResultado.TabIndex = 10;
            this.lblResultado.Text = "label1";
            // 
            // txtExpression
            // 
            this.txtExpression.Location = new System.Drawing.Point(27, 106);
            this.txtExpression.Name = "txtExpression";
            this.txtExpression.Size = new System.Drawing.Size(390, 22);
            this.txtExpression.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPotencia);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.btnLimipiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtExpression);
            this.Name = "MainForm";
            this.Text = "Calculadora Notació Polaca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPotencia;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnLimipiar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtExpression;
    }
}

