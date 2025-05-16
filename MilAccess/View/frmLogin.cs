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
    public partial class frmLogin : Form
    {
        ConexaoSQL sql = new ConexaoSQL();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnOlho_Click(object sender, EventArgs e)
        {
            txtSenha.UseSystemPasswordChar = !txtSenha.UseSystemPasswordChar;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string retorno = sql.Login(txtUsuario.Text, txtSenha.Text);
            if (retorno != "Erro")
            {
                frmMenuPrincipal menuPrincipal = new frmMenuPrincipal(txtUsuario.Text, retorno);
                menuPrincipal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show($"Usuário/Senha Incorretos", "Algo Incorreto!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
