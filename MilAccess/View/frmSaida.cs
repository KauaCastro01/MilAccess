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
    public partial class frmSaida : Form
    {
        public frmSaida(string nome, string cargo)
        {
            InitializeComponent();
            lblNome.Text = nome;
            lblCargo.Text = cargo;
        }

        private void txtDocumentos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            cmbPessoa.Text = "Selecione";
            txtDocumentos.Clear();
            txtDocumentos.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtDocumentos.Text.Length < 10)
            {
                MessageBox.Show("Quantidade De Caracteres Inválido Na Identidade", "Ação Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                switch (cmbPessoa.Text)
                {
                    case "Militar":
                        RegistroEntradaMilitar registroEntradaMilitar = new RegistroEntradaMilitar();
                        registroEntradaMilitar.SaidaMilitar(txtDocumentos.Text);
                        break;
                    case "Civil":
                        RegistroEntradaCivil registroEntradaCivil = new RegistroEntradaCivil();
                        registroEntradaCivil.SaidaCivil(txtDocumentos.Text);
                        break;
                    case "Veiculo":
                        RegistroEntradaVeiculo registroEntradaVeiculo = new RegistroEntradaVeiculo();
                        registroEntradaVeiculo.SaidaVeiculo(txtDocumentos.Text);
                        break;
                    default:
                        MessageBox.Show("Selecione O Tipo De Pessoa", "Ação Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                }
            }   
        }

        private void btnMilitar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal frmMenuPrincipal = new frmMenuPrincipal(lblNome.Text, lblCargo.Text);
            frmMenuPrincipal.Show();
            this.Close();
        }

        private void btnCivil_Click(object sender, EventArgs e)
        {
            frmCivil frmCivil = new frmCivil(lblNome.Text, lblCargo.Text);
            frmCivil.Show();
            this.Close();
        }

        private void btnVeiculo_Click(object sender, EventArgs e)
        {
            frmVeiculo frmVeiculo = new frmVeiculo(lblNome.Text, lblCargo.Text);
            frmVeiculo.Show();
            this.Close();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            frmRelatorio frmRelatorio = new frmRelatorio(lblNome.Text, lblCargo.Text);
            frmRelatorio.Show();
            this.Close();
        }
    }
}
