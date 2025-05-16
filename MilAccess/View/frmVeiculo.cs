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

namespace MilAccess.View
{
    public partial class frmVeiculo : Form
    {
        string status = "";
        public frmVeiculo(string nome, string cargo)
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

        private void btnCivil_Click(object sender, EventArgs e)
        {
            frmCivil civil = new frmCivil(lblNome.Text, lblCargo.Text);
            civil.Show();
            this.Close();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            {
                cmbPessoa.Text = "Selecione";
                txtUsuario.Clear();
                txtDocumentos.Clear();
                txtPlaca.Clear();
                cmbVeiculo.Text = "Selecione";
                txtCor.Clear();
                txtAcompanhantes.Clear();
                txtLocal.Clear();
                txtUsuario.Focus();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (cmbPessoa.Text == "Selecione")
            {
                ShowError("Informe A Status Da Pessoa", "Ação Inválidas");
                return;
            }
            if (txtUsuario.Text.Length < 4)
            {
                ShowError("Quantidade De Caracteres Inválido No Nome", "Ação Inválida");
                return;
            }
            if (txtDocumentos.Text.Length != 10 && status == "Militar" || txtDocumentos.Text.Length != 11 && status == "Civil")
            {
                ShowError("Quantidade De Números Inválido Na Identidade", "Ação Inválidas");
                return;
            }
            if (txtPlaca.Text.Length < 7)
            {
                ShowError("Quantidade De Caracteres Inválido Na Placa", "Ação Inválidas");
                return;
            }
            if (cmbVeiculo.Text == "Selecione")
            {
                ShowError("Informe O Tipo De Veiculo", "Ação Inválidas");
                return;
            }
            if(txtCor.Text.Length < 3)
            {
                ShowError("Quantidade De Caracteres Inválido Na Cor", "Ação Inválidas");
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
                RegistroEntradaVeiculo entrada = new RegistroEntradaVeiculo();
                entrada.EntradaVeiculo(txtUsuario.Text, status, txtDocumentos.Text, txtPlaca.Text, cmbVeiculo.Text, txtCor.Text, Convert.ToInt32(txtAcompanhantes.Text), txtLocal.Text);
                btnLimpar_Click(sender, e);
            }
        }
        private void ShowError(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void cmbPessoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPessoa.Text == "Militar")
            {
                status = "Militar";
                txtDocumentos.MaxLength = 10;
            }
            else if (cmbPessoa.Text == "Civil" || cmbPessoa.Text == "Outro")
            {
                status = "Civil";
                txtDocumentos.MaxLength = 11;
            }
            else
            {
                status = "";
            }
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
            frmSaida saida = new frmSaida(lblNome.Text, lblCargo.Text);
            saida.Show();
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
