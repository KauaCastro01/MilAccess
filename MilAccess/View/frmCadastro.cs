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
    public partial class frmCadastro : Form
    {
        ConexaoSQL sql = new ConexaoSQL();
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void btnOlho_Click(object sender, EventArgs e)
        {
            txtSenha.UseSystemPasswordChar = !txtSenha.UseSystemPasswordChar;
            txtSenhaNovamente.UseSystemPasswordChar = !txtSenhaNovamente.UseSystemPasswordChar;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!txtSenha.Text.Equals(txtSenhaNovamente.Text))
            {
                ShowError("As Senhas Não Se Correspodem!", "Senhas Inválidas");
                return;
            }

            if (cmbCargo.Text == "Selecione")
            {
                ShowError("Escolha Um Cargo!", "Erro");
                return;
            }

            if (txtUsuario.Text.Length < 4)
            {
                ShowError("O Usuário Deve Possuir No Minímo 4 Caracteres!", "Quantidade Inválida De Caracteres");
                return;
            }

            if (txtSenha.Text.Length < 6)
            {
                ShowError("A Senha Deve Possuir No Minímo 6 Caracteres!", "Quantidade Inválida De Caracteres");
                return;
            }
            else
            {
                bool booleano = sql.Cadastro(txtUsuario.Text, txtSenha.Text, cmbCargo.Text);
                if (booleano)
                {
                    frmMenuPrincipal menuPrincipal = new frmMenuPrincipal(txtUsuario.Text, cmbCargo.Text);
                    menuPrincipal.Show();
                    this.Hide();
                }
            }
        }

        private void ShowError(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
