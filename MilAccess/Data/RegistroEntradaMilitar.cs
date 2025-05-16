using MilAccess.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MilAccess.Data
{
    public class RegistroEntradaMilitar : ConexaoSQL
    {
        public void EntradaMilitar(string nome, string patente, string identidade, string om, int acompanhantes, string local)
        {
            try
            {
                bool busca = PesquisarMilitarSaida(identidade);
                if (busca) { }
                else
                {
                    Conectar();
                    cmd.Parameters.Clear();
                    cmd.CommandText = "INSERT INTO Militares (Nome, Patente, Documentos, OM, Acompanhantes, Destino, Entrada) " +
                   "VALUES (@nome, @patente, @identidade, @om, @acompanhantes, @local, @entrada)";
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@patente", patente);
                    cmd.Parameters.AddWithValue("@identidade", identidade);
                    cmd.Parameters.AddWithValue("@om", om);
                    cmd.Parameters.AddWithValue("@acompanhantes", acompanhantes);
                    cmd.Parameters.AddWithValue("@local", local);
                    cmd.Parameters.AddWithValue("@entrada", DateTime.Now);
                    cmd.Connection = cn;
                    int linhas = cmd.ExecuteNonQuery();
                    if (linhas > 0) { MessageBox.Show("Entrada De Militar Registrada!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                    else { MessageBox.Show("Entrada De Militar Não Registrada!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro {ex.ToString()}", "Ocorreu Um Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { Desconectar(); }
        }

        public bool PesquisarMilitarSaida(string documento)
        {
            try
            {
                Conectar();
                cmd.Parameters.Clear();
                cmd.CommandText = "SELECT * FROM Militares WHERE Documentos = @documento AND Saida IS NULL";
                cmd.Parameters.AddWithValue("documento", documento);
                cmd.Connection = cn;
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    MessageBox.Show("Militar Ainda Não Saiu Do Local", "Ação Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        public void SaidaMilitar(string identidade)
        {
            try
            {
                Conectar();
                cmd.Parameters.Clear();
                cmd.CommandText = "UPDATE Militares SET Saida = @saida WHERE Documentos = @identidade AND Saida IS NULL";
                cmd.Parameters.AddWithValue("@identidade", identidade);
                cmd.Parameters.AddWithValue("@saida", DateTime.Now);
                cmd.Connection = cn;
                int linhas = cmd.ExecuteNonQuery();
                if (linhas > 0) { MessageBox.Show("Saida De Militar Registrada!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                else { MessageBox.Show("Saida De Militar Já Registrada ou Entrada Não Registrada!", "Saida De Militar Não Registrada!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro {ex.ToString()}", "Ocorreu Um Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { Desconectar(); }
        }

        public DataTable RelatorioMilitar(DateTime dataInicio)
        {
            try
            {
                Conectar();
                cmd.Parameters.Clear();
                cmd.CommandText = "SELECT * FROM Militares WHERE Entrada BETWEEN @inicio AND @fim";
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
