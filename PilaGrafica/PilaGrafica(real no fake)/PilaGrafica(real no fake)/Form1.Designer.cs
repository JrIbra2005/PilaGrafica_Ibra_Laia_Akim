namespace PilaGrafica_real_no_fake_
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
            this.entraExpressio_txt = new System.Windows.Forms.TextBox();
            this.Comprovar_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fitxer_btn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnNetejar = new System.Windows.Forms.Button();
            this.lblEstat = new System.Windows.Forms.Label();
            this.llistaExpressions = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // entraExpressio_txt
            // 
            this.entraExpressio_txt.Location = new System.Drawing.Point(348, 133);
            this.entraExpressio_txt.Name = "entraExpressio_txt";
            this.entraExpressio_txt.Size = new System.Drawing.Size(115, 22);
            this.entraExpressio_txt.TabIndex = 0;
            this.entraExpressio_txt.TextChanged += new System.EventHandler(this.entraExpressio_txt_TextChanged);
            // 
            // Comprovar_btn
            // 
            this.Comprovar_btn.Location = new System.Drawing.Point(413, 175);
            this.Comprovar_btn.Name = "Comprovar_btn";
            this.Comprovar_btn.Size = new System.Drawing.Size(87, 31);
            this.Comprovar_btn.TabIndex = 1;
            this.Comprovar_btn.Text = "Comprovar";
            this.Comprovar_btn.UseVisualStyleBackColor = true;
            this.Comprovar_btn.Click += new System.EventHandler(this.Comprovar_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Entra una operació per comprovar";
            // 
            // fitxer_btn
            // 
            this.fitxer_btn.Location = new System.Drawing.Point(304, 175);
            this.fitxer_btn.Name = "fitxer_btn";
            this.fitxer_btn.Size = new System.Drawing.Size(91, 31);
            this.fitxer_btn.TabIndex = 4;
            this.fitxer_btn.Text = "Fitxer";
            this.fitxer_btn.UseVisualStyleBackColor = true;
            this.fitxer_btn.Click += new System.EventHandler(this.fitxer_btn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnNetejar
            // 
            this.btnNetejar.Location = new System.Drawing.Point(514, 133);
            this.btnNetejar.Name = "btnNetejar";
            this.btnNetejar.Size = new System.Drawing.Size(75, 23);
            this.btnNetejar.TabIndex = 5;
            this.btnNetejar.Text = "Neteja";
            this.btnNetejar.UseVisualStyleBackColor = true;
            this.btnNetejar.Click += new System.EventHandler(this.btnNetejar_Click);
            // 
            // lblEstat
            // 
            this.lblEstat.AutoSize = true;
            this.lblEstat.Location = new System.Drawing.Point(12, 435);
            this.lblEstat.Name = "lblEstat";
            this.lblEstat.Size = new System.Drawing.Size(44, 16);
            this.lblEstat.TabIndex = 6;
            this.lblEstat.Text = "label2";
            // 
            // llistaExpressions
            // 
            this.llistaExpressions.AccessibleDescription = "llistaExpressions";
            this.llistaExpressions.AccessibleName = "llistaExpressions";
            this.llistaExpressions.FormattingEnabled = true;
            this.llistaExpressions.ItemHeight = 16;
            this.llistaExpressions.Location = new System.Drawing.Point(782, 447);
            this.llistaExpressions.Name = "llistaExpressions";
            this.llistaExpressions.Size = new System.Drawing.Size(16, 4);
            this.llistaExpressions.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.llistaExpressions);
            this.Controls.Add(this.lblEstat);
            this.Controls.Add(this.btnNetejar);
            this.Controls.Add(this.fitxer_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Comprovar_btn);
            this.Controls.Add(this.entraExpressio_txt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox entraExpressio_txt;
        private System.Windows.Forms.Button Comprovar_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button fitxer_btn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnNetejar;
        private System.Windows.Forms.Label lblEstat;
        private System.Windows.Forms.ListBox llistaExpressions;
    }
}

