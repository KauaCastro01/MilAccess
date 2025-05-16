using MilAccess.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace MilAccess.View
{
    public partial class frmCivil : Form
    {
        public frmCivil(string nome, string cargo)
        {
            InitializeComponent();
            lblNome.Text = nome;
            lblCargo.Text = cargo;
        }

        private void btnMilitar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal menuPrincipal = new frmMenuPrincipal(lblNome.Text, lblCargo.Text);
            menuPrincipal.Show();
            this.Close();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Length < 4)
            {
                ShowError("Quantidade De Caracteres Inválido No Nome", "Ação Inválida");
                return;
            }
            if (txtDocumentos.Text.Length != 11 || string.IsNullOrEmpty(txtDocumentos.Text))
            {
                ShowError("Quantidade De Números Inválido Na Identidade", "Ação Inválidas");
                return;
            }
            if (string.IsNullOrEmpty(txtAcompanhantes.Text))
            {
                ShowError("Informe A Quantidade De Acompanhantes", "Ação Inválidas");
                return;
            }
            if (txtLocal.Text.Length < 2)
            {
                ShowError("Quantidade De Caracteres Inválido No Local", "Ação Inválidas");
                return;
            }
            else
            {
                RegistroEntradaCivil entrada = new RegistroEntradaCivil();
                entrada.EntradaCivil(txtUsuario.Text, txtDocumentos.Text, Convert.ToInt32(txtAcompanhantes.Text), txtLocal.Text);
            }
        }
        private void ShowError(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtUsuario.Clear();
            txtDocumentos.Clear();
            txtAcompanhantes.Clear();
            txtLocal.Clear();
            txtUsuario.Focus();
        }

        private void btnVeiculo_Click(object sender, EventArgs e)
        {
            frmVeiculo frmVeiculo = new frmVeiculo(lblNome.Text, lblCargo.Text);
            frmVeiculo.Show();
            this.Close();
        }

        private void txtDocumentos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnSaida_Click(object sender, EventArgs e)
        {
            frmSaida frmSaida = new frmSaida(lblNome.Text, lblCargo.Text);
            frmSaida.Show();
            this.Close();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            frmRelatorio frmRelatorio = new frmRelatorio(lblNome.Text, lblCargo.Text);
            frmRelatorio.Show();
            this.Close();
        }
    }
}
