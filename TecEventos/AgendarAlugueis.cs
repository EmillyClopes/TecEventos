using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// CS0108.cs
// compile with: /W:2
using System;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using Mysqlx.Prepare;

namespace TecEventos
{
    public partial class AgendarAlugueis : Form
    {
        ConexaoBanco conexaoBanco;
        GetSetAgendarAlugueis dadosAluguel;
        private int chacaraIdSelecionado; // Variável para armazenar o ID da chácara selecionada

        private void AgendarAlugueis_Load(object sender, EventArgs e)
        {
            LoadChacarasDisponiveis();
        }
        public AgendarAlugueis()
        {
            InitializeComponent();
            conexaoBanco = new ConexaoBanco();
            dadosAluguel = new GetSetAgendarAlugueis();
            this.Load += AgendarAlugueis_Load;
            GridViewChacarasDisponiveis.ReadOnly = true;
            GridViewChacarasDisponiveis.AllowUserToAddRows = false;
            GridViewChacarasDisponiveis.AllowUserToDeleteRows = false;
            GridViewChacarasDisponiveis.MultiSelect = false;
            GridViewChacarasDisponiveis.Enabled = false;
        }
        private void LoadChacarasDisponiveis()
        {
            string query = "SELECT id, nome FROM Chacara WHERE id NOT IN (SELECT chacara_id FROM Agendamento WHERE entrada_data <= CURDATE() AND saida_data >= CURDATE())";

            using (MySqlConnection connection = new MySqlConnection(conexaoBanco.getConnectionString()))
            {
                try
                {
                    connection.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    GridViewChacarasDisponiveis.DataSource = dataTable;

                    if(dataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("Nenhuma chácara disponível!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    GridViewChacarasDisponiveis.Refresh();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message, "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtDiaSaida.Text = "";
            txtMesSaida.Text = "";
            txtAnoSaida.Text = "";
            txtNomeCliente.Text = "";
            txtContatoCliente.Text = "";
            comboBox1.Text = "";
            txtTotal.Text = "";
            txtDiaEntrada.Text = "";
            txtMesEntrada.Text = "";
            txtAnoEntrada.Text = "";
        }
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (chacaraIdSelecionado == 0)
            {
                MessageBox.Show("Por favor, selecione uma chácara.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DateTime entradaData = new DateTime(int.Parse(txtAnoEntrada.Text), int.Parse(txtMesEntrada.Text), int.Parse(txtDiaEntrada.Text));
            DateTime saidaData = new DateTime(int.Parse(txtAnoSaida.Text), int.Parse(txtMesSaida.Text), int.Parse(txtDiaSaida.Text));

            dadosAluguel.setDiaMesAno(int.Parse(txtDiaEntrada.Text), int.Parse(txtMesEntrada.Text), int.Parse(txtAnoEntrada.Text),
                int.Parse(txtDiaSaida.Text), int.Parse(txtMesSaida.Text), int.Parse(txtAnoSaida.Text));
            dadosAluguel.setInfoCliente(txtNomeCliente.Text, txtContatoCliente.Text);
            dadosAluguel.setValorTotal(double.Parse(txtTotal.Text));

            string queryUsuarioId = "SELECT id FROM usuarios WHERE nome = @nome";

            string queryAgendamento = "INSERT INTO agendamento (entrada_data, saida_data, usuario_id, chacara_id, valor_agendamento, status) " +
                                      "VALUES (@entradaData, @saidaData, @usuarioId, @chacaraId, @valor_agendamento, @status)";

            using (MySqlConnection connection = new MySqlConnection(conexaoBanco.getConnectionString()))
            {
                try
                {
                    connection.Open();

                    int usuarioId;
                    using (MySqlCommand commandUsuarioId = new MySqlCommand(queryUsuarioId, connection))
                    {
                        commandUsuarioId.Parameters.AddWithValue("@nome", txtNomeCliente.Text);

                        object result = commandUsuarioId.ExecuteScalar();

                        if (result != null)
                        {
                            usuarioId = Convert.ToInt32(result);
                        }
                        else
                        {
                            MessageBox.Show("Usuário não encontrado com o contato fornecido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    using (MySqlCommand commandAgendamento = new MySqlCommand(queryAgendamento, connection))
                    {
                        commandAgendamento.Parameters.AddWithValue("@entradaData", entradaData);
                        commandAgendamento.Parameters.AddWithValue("@saidaData", saidaData);
                        commandAgendamento.Parameters.AddWithValue("@usuarioId", usuarioId);
                        commandAgendamento.Parameters.AddWithValue("@chacaraId", chacaraIdSelecionado);
                        commandAgendamento.Parameters.AddWithValue("@valor_agendamento", dadosAluguel.getValorTotal());
                        commandAgendamento.Parameters.AddWithValue("@status", comboBox1.Text);

                        int linhasAfetadas = commandAgendamento.ExecuteNonQuery();
                        if (linhasAfetadas > 0)
                        {
                            MessageBox.Show("Agendamento realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Erro ao realizar o agendamento.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message, "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void GridViewChacarasDisponiveis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Verifica se a linha clicada é válida
            {
                DataGridViewRow row = GridViewChacarasDisponiveis.Rows[e.RowIndex];
                // Supondo que o ID da chácara está na primeira coluna (ajuste o índice da coluna conforme necessário)
                chacaraIdSelecionado = Convert.ToInt32(row.Cells[0].Value);   
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
            /*fecha a tela*/
        }
    }
}
