using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotacioPolaca
{
    public partial class MainForm : Form
    {
        private CalculadoraPolaca calculadora;

        public MainForm()
        {
            InitializeComponent();
            calculadora = new CalculadoraPolaca();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                string expresion = txtExpression.Text.Trim();
                if (!string.IsNullOrEmpty(expresion))
                {
                    double resultado = calculadora.EvaluarExpresionPostfija(expresion);
                    lblResultado.Text = $"Resultado: {resultado}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimipiar_Click(object sender, EventArgs e)
        {
            txtExpression.Clear();
            lblResultado.Text = "";
        }

        private void btnOperador_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtExpression.Text += " " + btn.Text + " ";
            txtExpression.Focus();
            txtExpression.SelectionStart = txtExpression.Text.Length;
        }
    }
}
