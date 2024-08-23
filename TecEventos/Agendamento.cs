using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TecEventos
{
    public partial class Agendamento : Form
    {
        ConexaoBanco conexaoBanco;
        public Agendamento()
        {
            InitializeComponent();
            conexaoBanco = new ConexaoBanco();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
            /*fecha a tela*/
        }

        private void btnExluir_Click(object sender, EventArgs e)
        {

        }

        private void GridViewAgendamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string query = "SELECT entrada_data, saida_data, nome_cliente, telefone_cliente, status, valor_total FROM Agendamento WHERE" +
                "(SELECT id, chacara_id FROM Chacara JOIN Agendamento WHERE Chacara.id = Agendamento.chacara_id)";
            using (MySqlConnection connection = new MySqlConnection(conexaoBanco.getConnectionString()))
            {
                try
                {
                    connection.Open(); //Abre a conexão com o banco

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    GridViewAgendamentos.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message, "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }
        public enum Status
        {
            Confirmada,
            Pendente,
            Cancelada,
        }
    }
    
}
