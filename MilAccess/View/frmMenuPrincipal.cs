using MilAccess.Data;
using MilAccess.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilAccess
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal(string nome, string cargo)
        {
            InitializeComponent();
            lblNome.Text = nome;
            lblCargo.Text = cargo;
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void txtDocumentos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(txtUsuario.Text.Length < 4)
            {
                ShowError("Quantidade De Caracteres Inválido No Nome", "Ação Inválida");
                return;
            }
            if (cmbCargo.Text == "Selecione")
            {
                ShowError("Informe A Patente Do Militar", "Ação Inválidas");
                return;
            }
            if (txtDocumentos.Text.Length != 10)
            {
                ShowError("Quantidade De Números Inválido Na Identidade", "Ação Inválidas");
                return;
            }
            if(txtOM.Text.Length < 2)
            {
                ShowError("Quantidade De Caracteres Inválido Na OM", "Ação Inválidas");
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
                RegistroEntradaMilitar entrada = new RegistroEntradaMilitar();
                entrada.EntradaMilitar(txtUsuario.Text, cmbCargo.Text, txtDocumentos.Text, txtOM.Text, Convert.ToInt32(txtAcompanhantes.Text), txtLocal.Text);
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
            txtOM.Clear();
            txtAcompanhantes.Clear();
            txtLocal.Clear();
            cmbCargo.Text = "Selecione";
            txtUsuario.Focus();
        }

        private void btnCivil_Click(object sender, EventArgs e)
        {
            frmCivil civil = new frmCivil(lblNome.Text, lblCargo.Text);
            civil.Show();
            this.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void btnVeiculo_Click(object sender, EventArgs e)
        {
            frmVeiculo frmVeiculo = new frmVeiculo(lblNome.Text, lblCargo.Text);
            frmVeiculo.Show();
            this.Close();
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
