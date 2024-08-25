using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TecEventos
{
    public partial class ListaChacaras : Form
    {
        ConexaoBanco conexaoBanco;
        private void ListaChacara_Load(object sender, EventArgs e)
        {
            LoadChacarasDisponiveis();
        }
        public ListaChacaras()
        {
            InitializeComponent();
            this.Load += ListaChacara_Load;
            conexaoBanco = new ConexaoBanco();
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
                    GridViewChacarasCadastradas.DataSource = dataTable;

                    if (dataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("Nenhuma chácara disponível!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    GridViewChacarasCadastradas.Refresh();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message, "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
            /*fecha a tela*/
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            string query = "SELECT id, nome FROM chacara WHERE nome LIKE @nome";
            using (MySqlConnection connection = new MySqlConnection(conexaoBanco.getConnectionString()))
            {
                try
                {
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@nome", "%" + txtNomeChacara.Text + "%");
                    connection.Open();

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    GridViewChacarasCadastradas.DataSource = dataTable;
                    

                    if(dataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("Chácara não encontrada", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    GridViewChacarasCadastradas.Refresh();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void GridViewChacarasCadastradas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
