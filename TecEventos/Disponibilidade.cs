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
    public partial class Disponibilidade : Form
    {
        ConexaoBanco conexaoBanco;
        GetSetAgendarAlugueis dadosAluguel;
        private void AgendarAlugueis_Load(object sender, EventArgs e)
        {
            LoadChacarasDisponiveis();
        }
        public Disponibilidade()
        {
            InitializeComponent();
            conexaoBanco = new ConexaoBanco();
            dadosAluguel = new GetSetAgendarAlugueis();
            this.Load += AgendarAlugueis_Load;
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

                    if (dataTable.Rows.Count == 0)
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

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
            /*fecha a tela*/
        }
    }
}
