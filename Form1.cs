using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PesoIdeal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtAltura.Clear();
            cmbSexo.Text = "";
            txtNome.Focus();   
        }

        private void btnPesoIdeal_Click(object sender, EventArgs e)
        {
            try
            {
                double altura = 0, pesoIdeal = 0;
                altura = double.Parse(txtAltura.Text);

                if (cmbSexo.Text.ToLower() == "feminino")
                {
                    pesoIdeal = (62.7 * altura) - 44.7;
                    MessageBox.Show(txtNome.Text + " seu peso ideal é: " + pesoIdeal.ToString() + "Kg", "Peso Ideal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (cmbSexo.Text.ToLower() == "masculino")
                {
                    pesoIdeal = (72.7 * altura) - 58;
                    MessageBox.Show(txtNome.Text + " seu peso ideal é: " + pesoIdeal.ToString() + "Kg", "Peso Ideal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Escolha o sexo", "Peso Ideal", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Verifique os valores informados: " + ex.Message, "Peso Ideal:" + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbSexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
