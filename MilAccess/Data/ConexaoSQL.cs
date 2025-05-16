using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilAccess
{
    public class ConexaoSQL
    {
        public SqlConnection cn = new SqlConnection("Data Source = LAPTOPZEMBER;Integrated Security = SSPI; Initial Catalog = MilAccess");
        public SqlCommand cmd = new SqlCommand();
        public SqlDataReader dr;
        public string cargo = "";
        //Metodo Para Conectar Ao Banco De Dados
        public void Conectar()
        {
            if (cn.State == ConnectionState.Closed) { cn.Open(); }
        }
        //Metodo Para Desconectar Ao Banco De Dados
        public void Desconectar()
        {
            if (cn.State == ConnectionState.Open) { cn.Close(); }
        }
        //Metodo Para Efetuar O Login
        public string Login(string nome, string senha)
        {
            try
            {
                Conectar();
                cmd.Parameters.Clear();
                cmd.CommandText = "Select * From Usuarios Where Nome = @nome";
                cmd.Parameters.AddWithValue("nome", nome);
                cmd.Connection = cn;
                dr = cmd.ExecuteReader();
                if (dr.HasRows) 
                {
                    dr.Read();
                    cargo = dr["Cargo"].ToString();
                    return cargo;
                }
                else { return "Erro"; }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro {ex.ToString()}", "Ocorreu Um Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "Erro";
            }
            finally { Desconectar(); }
        }
        //Metodo Para Efetuar O Cadastro
        public bool Cadastro(string nome, string senha, string cargo)
        {
            try
            {
                string retorno = Login(nome, senha);
                if (retorno != "Erro")
                {
                    MessageBox.Show($"Usuário Já Cadastrado!", "Algo Incorreto!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    Conectar();
                    cmd.Parameters.Clear();
                    cmd.CommandText = "Insert Into Usuarios(Nome, Senha, Cargo) Values(@nome, @senha, @cargo)";
                    cmd.Parameters.AddWithValue("nome", nome);
                    cmd.Parameters.AddWithValue("senha", senha);
                    cmd.Parameters.AddWithValue("cargo", cargo);
                    cmd.Connection = cn;
                    int linhas = cmd.ExecuteNonQuery();
                    if (linhas > 0) { return true; }
                    else
                    {
                        MessageBox.Show($"Usuário Não Cadastrado!", "Algo Incorreto!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro {ex.ToString()}", "Ocorreu Um Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally { Desconectar(); }
        }


    }
}
