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

namespace TecEventos
{
    public partial class AgendarAlugueis : Form
    {
        ConexaoBanco conexaoBanco;
        GetSetAgendarAlugueis dadosAluguel;
        private int chacaraIdSelecionado; // Variável para armazenar o ID da chácara selecionada

        public AgendarAlugueis()
        {
            InitializeComponent();
            conexaoBanco = new ConexaoBanco();
            dadosAluguel = new GetSetAgendarAlugueis();
        }
        private void LoadChacarasDisponiveis()
        {
            conexaoBanco.getConnectionString();
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
        public enum Status
        {
            Confirmada,
            Pendente,
            Cancelada,
        }
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            /*string entradaData = $"{txtAnoEntrada.Text}-{txtMesEntrada.Text.PadLeft(2, '0')}-{txtDiaEntrada.Text.PadLeft(2, '0')}";
            string saidaData = $"{txtAnoSaida.Text}-{txtMesSaida.Text.PadLeft(2, '0')}-{txtDiaSaida.Text.PadLeft(2, '0')}";
            string nomeCliente = txtNomeCliente.Text;
            string contatoCliente = txtContatoCliente.Text;
            string status = comboBox1.Text;
            decimal total = decimal.Parse(txtTotal.Text);*/
            dadosAluguel.setDiaMesAno(int.Parse(txtDiaEntrada.Text), int.Parse(txtMesEntrada.Text), int.Parse(txtAnoEntrada.Text), int.Parse(txtDiaSaida.Text), int.Parse(txtMesSaida.Text), int.Parse(txtAnoSaida.Text));
            dadosAluguel.setInfoCliente(txtNomeCliente.Text, txtContatoCliente.Text);
            dadosAluguel.setValorTotal(double.Parse(txtTotal.Text));

            // Verifica se a chácara foi selecionada
            if (chacaraIdSelecionado == 0)
            {
                MessageBox.Show("Por favor, selecione uma chácara.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int usuarioId = 1; // Ajustar conforme necessário

            string query = "INSERT INTO Agendamento (entrada_data, saida_data, nome_cliente, telefone_cliente, status, valor_total, chacara_id, usuario_id) " +
                           "VALUES (@entradaData, @saidaData, @nomeCliente, @contatoCliente, @status, @total, @chacaraId, @usuarioId)";
            string queryStatus = "SELECT status FROM Agendamento WHERE (SELECT id, chacara_id FROM Chacara JOIN Agendamento ON id = chacara_id";

            using (MySqlConnection connection = new MySqlConnection(conexaoBanco.getConnectionString()))
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand commandStatus = new MySqlCommand(queryStatus, connection))
                    {
                        commandStatus.Parameters.AddWithValue("@chacara_id", chacaraIdSelecionado);

                        using (MySqlDataReader reader = commandStatus.ExecuteReader())
                        {
                            if(reader.Read())
                            {
                                string status = reader["status"].ToString();
                            }

                        }
                    }

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@entradaData", $"{dadosAluguel.getAnoEntrada()}-{dadosAluguel.getMesEntrada()}-{dadosAluguel.getAnoEntrada()}");
                    command.Parameters.AddWithValue("@saidaData", $"{dadosAluguel.getAnoSaida()}-{dadosAluguel.getMesSaida()}-{dadosAluguel.getDiaSaida()}");
                    command.Parameters.AddWithValue("@nomeCliente", dadosAluguel.getNomeCliente());
                    command.Parameters.AddWithValue("@contatoCliente", dadosAluguel.getContatoCliente());
                    //command.Parameters.AddWithValue("@status", //Passar a variável status pra ca????);
                    command.Parameters.AddWithValue("@total", dadosAluguel.getValorTotal());
                    command.Parameters.AddWithValue("@chacaraId", chacaraIdSelecionado);
                    command.Parameters.AddWithValue("@usuarioId", usuarioId);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Agendamento realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Erro ao realizar o agendamento.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
