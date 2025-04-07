using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PilaGrafica_real_no_fake_
{
    public partial class Form1 : Form
    {

        private Compilador compilador;
        private TaulaLlista<string> expressions;

        public Form1()
        {
            InitializeComponent();
            compilador = new Compilador();
            expressions = new TaulaLlista<string>();

            ActualitzarEstat();

        }

        private void ActualitzarEstat()
        {
            lblEstat.Text = $"Expressions: {expressions.Count}";
        }
        private void entraExpressio_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void MostrarExpressions()
        {
            llistaExpressions.Items.Clear();
            foreach (string expr in expressions)
            {
                llistaExpressions.Items.Add(expr);
            }
        }

        private void fitxer_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Arxius de text (*.txt)|*.txt|Tots els arxius (*.*)|*.*",
                Title = "Selecciona un fitxer amb expressions"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    expressions.Clear();
                    bool totesCorrectes = true;
                    string primeraIncorrecta = null;

                    // Llegir totes les línies del fitxer
                    string[] linies = File.ReadAllLines(openFileDialog.FileName);

                    foreach (string linia in linies)
                    {
                        if (!string.IsNullOrWhiteSpace(linia))
                        {
                            expressions.Add(linia);

                            if (!compilador.Validar(linia) && totesCorrectes)
                            {
                                totesCorrectes = false;
                                primeraIncorrecta = linia;
                            }
                        }
                    }

                    // Mostrar resultats
                    if (expressions.Count == 0)
                    {
                        MessageBox.Show("El fitxer no conté expressions vàlides", "Avís",
                                      MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (totesCorrectes)
                    {
                        MessageBox.Show("TOTES les expressions del fitxer estan balancejades correctament",
                                      "Resultat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"El fitxer conté expressions NO balancejades.\nPrimera incorrecta: {primeraIncorrecta}",
                                      "Resultat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    // Mostrar les expressions carregades
                    MostrarExpressions();
                    ActualitzarEstat();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error en processar el fitxer: {ex.Message}", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void Comprovar_btn_Click(object sender, EventArgs e)
        {
            string expressio = entraExpressio_txt.Text;
            bool esValida = compilador.Validar(expressio);

            if (esValida)
            {
                MessageBox.Show("L'expressió ESTÀ balancejada correctament", "Resultat",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("L'expressió NO està balancejada correctament", "Resultat",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

      
        private void btnNetejar_Click(object sender, EventArgs e)
        {
            expressions.Clear();
            llistaExpressions.Items.Clear();
            entraExpressio_txt.Clear();
            ActualitzarEstat();
        }
    }
}
