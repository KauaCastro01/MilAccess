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
    public class RegistroEntradaVeiculo : ConexaoSQL
    {
        public void EntradaVeiculo(string nome, string status, string identidade, string placa, string veiculo,string cor, int acompanhantes, string local)
        {
            try
            {
                bool busca = PesquisarVeiculoSaida(identidade);
                if (busca) { }
                else
                {
                    Conectar();
                    cmd.Parameters.Clear();
                    cmd.CommandText = "INSERT INTO Veiculo (Nome, TipoPessoa, Documentos, Placa, Veiculo, Cor, Acompanhantes, Destino, Entrada) " +
                  "VALUES (@nome, @tipoPessoa, @documentos, @placa, @veiculo, @cor, @acompanhantes, @destino, @entrada)";

                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@tipoPessoa", status);
                    cmd.Parameters.AddWithValue("@documentos", identidade);
                    cmd.Parameters.AddWithValue("@placa", placa);
                    cmd.Parameters.AddWithValue("@veiculo", veiculo);
                    cmd.Parameters.AddWithValue("@cor", cor);
                    cmd.Parameters.AddWithValue("@acompanhantes", acompanhantes);
                    cmd.Parameters.AddWithValue("@destino", local);
                    cmd.Parameters.AddWithValue("@entrada", DateTime.Now);

                    cmd.Connection = cn;
                    int linhas = cmd.ExecuteNonQuery();
                    if (linhas > 0) { MessageBox.Show("Entrada De Veiculo Registrada!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                    else { MessageBox.Show("Entrada De Veiculo Não Registrada!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro {ex.ToString()}", "Ocorreu Um Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { Desconectar(); }
        }

        public bool PesquisarVeiculoSaida(string documento)
        {
            try
            {
                Conectar();
                cmd.Parameters.Clear();
                cmd.CommandText = "SELECT * FROM Veiculo WHERE Documentos = @documento AND Saida IS NULL";
                cmd.Parameters.AddWithValue("documento", documento);
                cmd.Connection = cn;
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    MessageBox.Show("Veiculo Ainda Não Saiu Do Local", "Ação Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        public void SaidaVeiculo(string identidade)
        {
            try
            {
                Conectar();
                cmd.Parameters.Clear();
                cmd.CommandText = "UPDATE Veiculo SET Saida = @saida WHERE Documentos = @identidade AND Saida IS NULL";
                cmd.Parameters.AddWithValue("@identidade", identidade);
                cmd.Parameters.AddWithValue("@saida", DateTime.Now);
                cmd.Connection = cn;
                int linhas = cmd.ExecuteNonQuery();
                if (linhas > 0) { MessageBox.Show("Saida De Veiculo Registrada!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                else { MessageBox.Show("Saida De Veiculo Já Registrada ou Entrada Não Registrada!", "Saida De Veiculo Não Registrada!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro {ex.ToString()}", "Ocorreu Um Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { Desconectar(); }
        }

        public DataTable RelatorioVeiculo(DateTime dataInicio)
        {
            try
            {
                Conectar();
                cmd.Parameters.Clear();
                cmd.CommandText = "SELECT * FROM Veiculo WHERE Entrada BETWEEN @inicio AND @fim";
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
