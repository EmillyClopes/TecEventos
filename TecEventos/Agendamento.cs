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
        GetSetAgendamento agendamento;
        private int chacaraIdSelecionado;
        private void Agendamento_Load(object sender, EventArgs e)
        {
            LoadChacarasDisponiveis();
        }
        public Agendamento()
        {
            InitializeComponent();
            conexaoBanco = new ConexaoBanco();
            agendamento = new GetSetAgendamento();
            this.Load += Agendamento_Load;
            GridViewAgendamentos.ReadOnly = true;
            GridViewAgendamentos.AllowUserToAddRows = false;
            GridViewAgendamentos.AllowUserToDeleteRows = false;
            GridViewAgendamentos.MultiSelect = false;
            GridViewAgendamentos.Enabled = false;
        }
        private void LoadChacarasDisponiveis()
        {
            string query = "SELECT entrada_data as Entrada, saida_data as Saída, u.nome as Cliente, u.telefone as Telefone, c.nome as Chacara, a.valor_agendamento as 'Valor Agendamento', a.status as 'Status Agendamento' FROM agendamento a\r\njoin usuarios u on u.id = a.usuario_id\r\njoin chacara c on c.id =a.chacara_id;\r\n\r\n";

            using (MySqlConnection connection = new MySqlConnection(conexaoBanco.getConnectionString()))
            {
                try
                {
                    connection.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                    DataTable datatable = new DataTable();
                    adapter.Fill(datatable);
                    GridViewAgendamentos.DataSource = datatable;

                    if (datatable.Rows.Count == 0)
                    {
                        MessageBox.Show("Nenhuma chácara disponível!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    GridViewAgendamentos.Refresh();
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

        private void btnExluir_Click(object sender, EventArgs e)
        {
            if (GridViewAgendamentos.SelectedRows.Count > 0)
            {
                DataGridViewRow linhaSelecionada = GridViewAgendamentos.SelectedRows[0];

                if (linhaSelecionada.Index >= 0)
                { 
                    GridViewAgendamentos.Rows.Remove(linhaSelecionada);
                }
                else
                {
                    MessageBox.Show("Nenhuma linha selecionada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecione uma linha para excluir.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void GridViewAgendamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Verifica se a linha clicada é válida
            {
                //DataGridViewRow row = GridViewAgendamentos.Rows[e.RowIndex];
                // Supondo que o ID da chácara está na primeira coluna (ajuste o índice da coluna conforme necessário)
                //chacaraIdSelecionado = Convert.ToInt32(row.Cells[0].Value);
            }
        }
    }
    
}
