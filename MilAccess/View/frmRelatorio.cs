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
    public partial class frmRelatorio : Form
    {
        public frmRelatorio(string nome, string cargo)
        {
            InitializeComponent();
            lblNome.Text = nome;
            lblCargo.Text = cargo;
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void btnMilitar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal menu = new frmMenuPrincipal(lblNome.Text, lblCargo.Text);
            menu.Show();
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

        private void btnSaida_Click(object sender, EventArgs e)
        {
            frmSaida frmSaida = new frmSaida(lblNome.Text, lblCargo.Text);
            frmSaida.Show();
            this.Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            switch (cmbTipo.Text)
            {
                case "Militar":
                    RegistroEntradaMilitar militar = new RegistroEntradaMilitar();
                    dgvDados.DataSource = militar.RelatorioMilitar(Tempo.Value.Date);
                    break;
                case "Civil":
                    RegistroEntradaCivil civil = new RegistroEntradaCivil();
                    dgvDados.DataSource = civil.RelatorioCivil(Tempo.Value.Date);
                    break;
                case "Veiculo":
                    RegistroEntradaVeiculo veiculo = new RegistroEntradaVeiculo();
                    dgvDados.DataSource = veiculo.RelatorioVeiculo(Tempo.Value.Date);
                    break;
                default:
                    MessageBox.Show("Selecione um tipo de relatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }
    }
}
