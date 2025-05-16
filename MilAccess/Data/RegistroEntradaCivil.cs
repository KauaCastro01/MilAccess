using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilAccess.Data
{
    public class RegistroEntradaCivil : ConexaoSQL
    {
        public void EntradaCivil(string nome, string identidade, int acompanhantes, string local)
        {
            try
            {
                bool busca = PesquisarCivilSaida(identidade);
                if (busca) { }
                else
                {
                    Conectar();
                    cmd.Parameters.Clear();
                    cmd.CommandText = "INSERT INTO Civil (Nome, Documentos, Acompanhantes, Destino, Entrada) " +
                   "VALUES (@nome, @identidade, @acompanhantes, @local, @entrada)";
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@identidade", identidade);
                    cmd.Parameters.AddWithValue("@acompanhantes", acompanhantes);
                    cmd.Parameters.AddWithValue("@local", local);
                    cmd.Parameters.AddWithValue("@entrada", DateTime.Now);
                    cmd.Connection = cn;
                    int linhas = cmd.ExecuteNonQuery();
                    if (linhas > 0) { MessageBox.Show("Entrada De Civil Registrada!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                    else { MessageBox.Show("Entrada De Civil Não Registrada!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro {ex.ToString()}", "Ocorreu Um Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { Desconectar(); }
        }

        public bool PesquisarCivilSaida(string documento)
        {
            try
            {
                Conectar();
                cmd.Parameters.Clear();
                cmd.CommandText = "SELECT * FROM Civil WHERE Documentos = @documento AND Saida IS NULL";
                cmd.Parameters.AddWithValue("documento", documento);
                cmd.Connection = cn;
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    MessageBox.Show("Civil Ainda Não Saiu Do Local", "Ação Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return true;
                }
                else { return false; }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro {ex.ToString()}", "Ocorreu Um Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            finally { Desconectar(); }
        }

        public void SaidaCivil(string identidade)
        {
            try
            {
                Conectar();
                cmd.Parameters.Clear();
                cmd.CommandText = "UPDATE Civil SET Saida = @saida WHERE Documentos = @identidade AND Saida IS NULL";
                cmd.Parameters.AddWithValue("@identidade", identidade);
                cmd.Parameters.AddWithValue("@saida", DateTime.Now);
                cmd.Connection = cn;
                int linhas = cmd.ExecuteNonQuery();
                if (linhas > 0) { MessageBox.Show("Saida De Civil Registrada!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                else { MessageBox.Show("Saida De Civil Já Registrada ou Entrada Não Registrada!", "Saida De Civil Não Registrada!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro {ex.ToString()}", "Ocorreu Um Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { Desconectar(); }
        }

        public DataTable RelatorioCivil(DateTime dataInicio)
        {
            try
            {
                Conectar();
                cmd.Parameters.Clear();
                cmd.CommandText = "SELECT * FROM Civil WHERE Entrada BETWEEN @inicio AND @fim";
                cmd.Parameters.AddWithValue("@inicio", dataInicio);
                cmd.Parameters.AddWithValue("@fim", DateTime.Now);
                cmd.Connection = cn;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable tabela = new DataTable();
                adapter.Fill(tabela);
                return tabela;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro {ex.ToString()}", "Ocorreu Um Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally { Desconectar(); }
        }

    }
}
