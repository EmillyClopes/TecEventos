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
    public partial class Precificacao : Form
    {
        ConexaoBanco conexaoBanco;
        GetSetPrecificacao precificacao;
        private int chacaraIdSelecionado;
        private void Precificacao_Load(object sender, EventArgs e)
        {
            LoadChacarasDisponiveis();
        }
        public Precificacao()
        {
            InitializeComponent();
            conexaoBanco = new ConexaoBanco();
            precificacao = new GetSetPrecificacao();
            this.Load += Precificacao_Load;
        }
        private void LoadChacarasDisponiveis()
        {
            string query = "SELECT entrada_data, saida_data, usuario_id, chacara_id, valor_agendamento " +
                "FROM agendamento";

            using (MySqlConnection connection = new MySqlConnection(conexaoBanco.getConnectionString()))
            {
                try
                {
                    connection.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                    DataTable datatable = new DataTable();
                    adapter.Fill(datatable);
                    dataGridView1.DataSource = datatable;

                    if (datatable.Rows.Count == 0)
                    {
                        MessageBox.Show("Nenhuma chácara disponível!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    dataGridView1.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar ao banco de dados!", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
            /*fecha a tela*/
        }

        private void btnCadastrarChacara_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO valores_diaria(valor, dia_semana) VALUES " +
                "(@valor, @dia_semana)";
            precificacao.setValores(comboBox1.Text, double.Parse(TxtValorPre.Text));

            using (MySqlConnection connection = new MySqlConnection(conexaoBanco.getConnectionString()))
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@valor", precificacao.getDiaSemana());
                    command.Parameters.AddWithValue("@dia_semana", precificacao.getValor());
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Erro ao inserir os dados! " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Verifica se a linha clicada é válida
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                // Supondo que o ID da chácara está na primeira coluna (ajuste o índice da coluna conforme necessário)
                chacaraIdSelecionado = Convert.ToInt32(row.Cells[0].Value);
            }
        }
    }
}
